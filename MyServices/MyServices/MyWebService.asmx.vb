Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class MyWebService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Olá, Mundo"
    End Function

    <WebMethod()>
    Public Function AddUp(a As Integer, b As Integer) As Integer
        Return a + b
    End Function
End Class