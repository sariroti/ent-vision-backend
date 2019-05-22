Imports System.ComponentModel.DataAnnotations
Namespace Model
    Public Class Product
        Public Property Id As Integer
        Public Property PartNumber As String
        Public Property ProductName As String
        Public Property QuantityPerUnit As String
        Public Property UnitPrice As Decimal
        Public Property UnitsInStock As Integer
        Public Property UnitsOnOrder As Integer
        Public Property ReorderLevel As Integer
        Public Property Discontinued As Boolean
        Public Property CategoryName As String
    End Class
End Namespace

