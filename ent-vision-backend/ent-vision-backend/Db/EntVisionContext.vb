Imports System.Data.Entity
Imports ent_vision_backend.Model

Public Class EntVisionContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("EntVisionConnectionStrings")
        Database.SetInitializer(New CreateDatabaseIfNotExists(Of EntVisionContext)())
    End Sub

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Configurations.Add(New DbConfiguration.Order())
    End Sub

    Public Property Product As DbSet(Of Product)
    Public Property Order As DbSet(Of Order)
    Public Property OrderDetail As DbSet(Of OrderDetail)

End Class
