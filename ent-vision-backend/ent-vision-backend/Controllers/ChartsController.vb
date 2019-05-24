Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Cors

Namespace Controllers
    Public Class ChartsController
        Inherits ApiController
        <EnableCors("http://localhost:4200", "*", "*")>
        <Route("api/charts/GetProductTotalByCategories")>
        Public Function GetProductTotalByCategories() As IEnumerable(Of Model.GoogleLineChart)
            Using ctx As EntVisionContext = New EntVisionContext()
                Dim query = (From p In ctx.Product
                             Group p By p.CategoryName Into CategoryGroup = Group
                             Select CategoryName, CategoryGroup.Count()).ToList()

                Dim googleLineChartList As List(Of Model.GoogleLineChart) = New List(Of Model.GoogleLineChart)()

                For Each q In query
                    Dim googleLineChart As Model.GoogleLineChart = New Model.GoogleLineChart()
                    googleLineChart.Rows = Tuple.Create(q.CategoryName, q.Count)

                    googleLineChartList.Add(googleLineChart)
                Next

                Return googleLineChartList

            End Using
        End Function

    End Class
End Namespace