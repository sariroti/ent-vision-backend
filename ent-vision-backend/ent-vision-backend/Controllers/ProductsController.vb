Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class ProductsController
        Inherits ApiController

        Public Function GetProducts() As IEnumerable(Of Model.Product)
            Using ctx As EntVisionContext = New EntVisionContext()
                Return ctx.Product.ToList()
            End Using

        End Function

        Public Function GetProducts(columnName As String, value As String) As IEnumerable(Of Model.Product)
            Using ctx As EntVisionContext = New EntVisionContext()
                Dim products As List(Of Model.Product) = New List(Of Model.Product)

                If columnName = "categoryName" Then
                    products = ctx.Product.Where(Function(p) p.CategoryName = value).ToList()
                End If

                If columnName = "partNumber" Then
                    products = ctx.Product.Where(Function(p) p.PartNumber = value).ToList()
                End If

                Return products
            End Using

        End Function

    End Class
End Namespace