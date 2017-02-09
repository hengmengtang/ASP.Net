Imports System.Web.Mvc

Public Class ActionController
    Inherits Controller

    Function DefaultView(Visitor As String) As ActionResult
        ViewBag.Visitor = Visitor

        Return View()
    End Function

    Function IndexView(Visitor As String) As ActionResult
        ViewBag.Visitor = Visitor

        Return View("DefaultView")
    End Function

    Function TextContent(Visitor As String) As ActionResult
        Return Content("Visitor: " & Visitor)
    End Function

    Function LinkContent(Visitor As String) As ActionResult
        Return Content("<a href='E2.html'>" & Visitor & "</a>")
    End Function

    Function OpenFile() As ActionResult

        Return File("~/Files/datatype.doc", "application/doc")
    End Function

    Function DownloadFile() As ActionResult
        Return File("", "", "")
    End Function

    Function RedirecToURL() As ActionResult
        Return Redirect("http://www.rupp.edu.kh")
    End Function

    Function RedirectToMethod() As ActionResult
        Return RedirectToRoute(New With {.Controller = "Home", .Acton = "About"})
    End Function
End Class