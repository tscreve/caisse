Imports System
Imports Microsoft.VisualBasic


Module FonctionsApi
#Region "Constantes"
    Public Const TOKEN_ADJUST_PRIVILEGES As Integer = &H20
    Public Const TOKEN_QUERY As Integer = &H8
    Public Const SE_PRIVILEGE_ENABLED As Integer = &H2
    Public Const EWX_LOGOFF As Integer = 0
    Public Const EWX_REBOOT As Integer = 2
    Public Const EWX_FORCE As Integer = 4
    Public Const EWX_POWEROFF As Integer = 8
    Public Const EWX_FORCEIFHUNG As Integer = 12               '2000/XP seulement
    Public Const VER_PLATFORM_WIN32_NT As Integer = 2
    Public uFlags As Integer

    Private WM_QUERYENDSESSION As Integer = &H11

#End Region
#Region "Structures"
    ' a noter la différence de déclarations par rapport à VB6
    Private Structure OSVERSIONINFO
        Dim OSVSize As Integer
        Dim dwVerMajor As Integer
        Dim dwVerMinor As Integer
        Dim dwBuildNumber As Integer
        Dim PlatformID As Integer
        Dim szCSDVersion As String
    End Structure

    Private Structure LUID
        Dim dwLowPart As Integer
        Dim dwHighPart As Integer
    End Structure

    Private Structure LUID_AND_ATTRIBUTES
        Dim udtLUID As LUID
        Dim dwAttributes As Integer
    End Structure

    Private Structure TOKEN_PRIVILEGES
        Dim PrivilegeCount As Integer
        Dim laa As LUID_AND_ATTRIBUTES
    End Structure
#End Region
#Region "declare API"
    Public Declare Function ExitWindowsEx Lib "user32" _
            (ByVal dwOptions As Long, _
            ByVal dwReserved As Long) As Long

    Private Declare Function GetCurrentProcess Lib "kernel32" () As Integer

    Private Declare Function OpenProcessToken Lib "advapi32" _
            (ByVal ProcessHandle As Integer, _
            ByVal DesiredAccess As Integer, _
    ByRef TokenHandle As Integer) As Integer

    Private Declare Function LookupPrivilegeValue Lib "advapi32" _
            Alias "LookupPrivilegeValueA" _
            (ByVal lpSystemName As String, _
            ByVal lpName As String, _
            ByRef lpLuid As LUID) As Integer

    Private Declare Function AdjustTokenPrivileges Lib "advapi32" _
            (ByVal TokenHandle As Integer, _
            ByVal DisableAllPrivileges As Boolean, _
    ByRef NewState As TOKEN_PRIVILEGES, _
            ByVal BufferLength As Integer, _
    ByRef PreviousState As TOKEN_PRIVILEGES, _
    ByRef ReturnLength As Integer) As Integer

    Private Declare Function GetVersionEx Lib "kernel32" _
            Alias "GetVersionExA" _
            (ByRef lpVersionInformation As OSVERSIONINFO) As Integer
#End Region
#Region "fonctions"
    Public Function IsWinNTPlus() As Boolean

        'retourne True si windows NT,
        'Windows 2000, Windows XP, ou .net server
        '#If Win32 Then

'        Dim OSV As OSVERSIONINFO
'        Dim i As Integer

'        OSV.szCSDVersion = Space(128)
'        OSV.OSVSize = Len(OSV)
'        Environment.OSVersion.ToString()
'        MsgBox(Environment.SystemDirectory())
        If LCase(Environment.OSVersion.Platform.ToString) = "win32nt" Then '" Then

            ''IsWinNTPlus = (OSV.PlatformID = VER_PLATFORM_WIN32_NT) And _
            ''        (OSV.dwVerMajor >= 4)
            Return True
        Else
            Return False
        End If

        '#End If

    End Function


    Public Function EnableShutdownPrivledges() As Boolean

        Dim hProcessHandle As System.IntPtr
        Dim hTokenHandle As Integer
        Dim lpv_la As LUID
        Dim token As TOKEN_PRIVILEGES
        Dim iProcessHandle As Integer
        Dim mNewtoken As TOKEN_PRIVILEGES

        iProcessHandle = GetCurrentProcess()
       
        If iProcessHandle <> 0 Then

            'ouvre l'associé symbolique d'accès 
            'au hTokenHandle de processus courant 
            'retourne une poignée identifiant 
            'la marque nouveau-ouverte d'accès 
            If OpenProcessToken(iProcessHandle, _
                    (TOKEN_ADJUST_PRIVILEGES Or TOKEN_QUERY), _
                    hTokenHandle) <> 0 Then

                'obtenez la marque localement unique 
                '(LUID) employée sur le système indiqué 
                'pour représenter localement 
                'le nom indiqué de privilège. 
                'Passing(vbNullString) 'fait essayer l'api de trouver 
                'le nom de privilège sur le système local. 
                If LookupPrivilegeValue(vbNullString, _
                        "SeShutdownPrivilege", _
                        lpv_la) <> 0 Then

                    'TOKEN_PRIVILEGES contient l'information au sujet 
                    'd'un ensemble de privilèges pour une marque d'accès. 'préparez la structure de TOKEN_PRIVILEGES 
                    'en permettant un privilège. 
                    With token
                        .PrivilegeCount = 1
                        .laa.udtLUID = lpv_la
                        .laa.dwAttributes = SE_PRIVILEGE_ENABLED
                    End With
                    'permet le privilège d'arrêt de ce processus. 
                    'hTokenHandle: accés à la marque contenant le prvvilège à modifier
                    'DisableAllPrivileges: si True la fonction
                    '  disables tous les privileges et ignore le paramêtre
                    '  si FALSE, la
                    '  fonction modifie les privileges basées sur
                    '  les informations dirigée  par NewState
                    'token: Structure d'OKEN_PRIVILEGES indiquant 
                    'un choix de privilèges et de leurs attributs.  

                    '
                    'Since were just adjusting to shut down,
                    'BufferLength, PreviousState and ReturnLength
                    'can be passed as null.

                    'If AdjustTokenPrivileges(hTokenHandle, False, token, uFlags, 0&, 0&) <> 0 Then
                    If AdjustTokenPrivileges(hTokenHandle, False, token, 4 + (12 * token.PrivilegeCount), mNewtoken, 4 + (12 * mNewtoken.PrivilegeCount)) <> 0 Then
                        'si réussi, retourne True
                        EnableShutdownPrivledges = True

                    End If                                     'AdjustTokenPrivileges
                End If                                         'LookupPrivilegeValue
            End If                                             'OpenProcessToken
        End If                                                 'hProcessHandle

    End Function
#End Region



End Module
