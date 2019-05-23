Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class OrdersController
        Inherits ApiController

        Public Function PostOrders(<FromBody()> vorder As Model.VOrder) As String
            Using ctx As EntVisionContext = New EntVisionContext()
                If vorder.Order.OrderDetails.Count() = 0 Then
                    Return "orderDetails cannot be empty"
                End If
                ctx.Order.Add(vorder.Order)

                Return If(ctx.SaveChanges() > 0, "Success", "Nothing Added")
            End Using

        End Function

    End Class
End Namespace