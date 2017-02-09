Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations

Public Class Student
    Public Property StudentId As Integer

    '<Required(ErrorMessage:="ត្រូវសរសេរឈ្មោះជាអក្សរឡាតំាង"), StringLength(1, ErrorMessage:="")>
    <Display(Name:="ឈ្មោះនិសិ្សតជាអក្សរឡាតំាង")>
    Public Property StudentName As String

    <Display(Name:="ឈ្មោះនិសិ្សតជាអក្សរខ្មែរ")>
    Public Property StudentNameInKhmer As String

    <Display(Name:="ភេទ")>
    Public Property Sex As String

    <Display(Name:="ថ្ងៃខែឆ្នាំកំណើត")>
    Public Property BirthDate As String

    <Display(Name:="លេខទូរសព្ទ័")>
    Public Property PhoneNumber As String

    <Display(Name:="អាស័យដ្ធាន")>
    Public Property Address As String
End Class

Public Class StudentDBContext
    Inherits DbContext
    Public Property Students As DbSet(Of Student)
End Class
