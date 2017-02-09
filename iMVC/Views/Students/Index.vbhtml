@ModelType IEnumerable(Of Student)
@Code
ViewData("Title") = "Index"
End Code
<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table table-striped table-bordered">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.StudentName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.StudentNameInKhmer)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sex)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BirthDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PhoneNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address)
        </th>
        <th style="text-align:center">Action</th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StudentName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StudentNameInKhmer)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sex)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BirthDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PhoneNumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Address)
        </td>
        <td style="text-align : center">
            <a class="btn btn-primary" href="@Url.Action("Edit", New With {.id = item.StudentId })">កែប្រែ</a> 
            <a class="btn btn-success" href="@Url.Action("Details",New With {.id = item.StudentId})">Details</a>
            <a class="btn btn-danger" href="@Url.Action("Delete",New With {.id = item.StudentId})">លុប</a> 
        </td>
    </tr>
Next

</table>
