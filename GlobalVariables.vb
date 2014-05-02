Imports System.Data
Imports System.Data.SqlClient

Public Class GlobalVariables
    '====================
    'Connection Variables
    '====================
    '#1
    Public Shared gsTipoConexion1 As String
    Public Shared gsDataServer1 As String
    Public Shared gsDataBase1 As String
    Public Shared gsUserId1 As String
    Public Shared gsPassword1 As String
    'Genericas desde INI
    Public Shared gsConnectTimeout As String
    Public Shared gsPWD As String
    Public Shared gsDirExp As String
    Public Shared gsDirReports As String
    Public Shared gsRNCSEH As String
    Public Shared gsArea As String
    Public Shared gsSistema As String
    'Para Manejo de Registros
    Public Shared strSQL As String
    Public Shared Conn As New SqlConnection
    Public Shared rsXDA As SqlDataAdapter
    Public Shared rsXDT As DataTable
    Public Shared rsXJDA As SqlDataAdapter
    Public Shared rsXJDT As DataTable
    Public Shared cmdSQL As New SqlCommand

    '================
    'String Variables
    '================
    Public Shared gsUsuario As String
    Public Shared gsUsrSesion As String
    Public Shared gsSiglas As String
    Public Shared FullCode1_x As String
    Public Shared FullCode2_x As String
    Public Shared ID_x As String
    Public Shared isreceta As String
    Public Shared codArt As String

    '================
    'Long Variables
    '================
    Public Shared glToday As Long
End Class
