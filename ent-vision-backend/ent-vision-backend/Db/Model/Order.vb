﻿Imports System.ComponentModel.DataAnnotations
Namespace Model
    Public Class Order
        Public Property Id As Integer
        Public Property RequiredDate As Date
        Public Property ShipName As String
        <Required>
        Public Property ShipAddress As String
        Public Property ShipCity As String
        Public Property ShipPostalCode As String
        Public Property ShipCountry As String
        Public Property CustomerID As String
        <Required>
        Public Property OrderDetails As ICollection(Of OrderDetail)
    End Class

    Public Class VOrder
        Public Property Order As Order
    End Class
End Namespace
