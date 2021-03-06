﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()
        config.EnableCors()
        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )


        GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(New System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                                     "text/html",
                                     StringComparison.InvariantCultureIgnoreCase,
                                     True,
                                     "application/json"))
    End Sub
End Module
