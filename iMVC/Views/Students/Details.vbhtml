@ModelType Student
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Student</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.StudentName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StudentName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.StudentNameInKhmer)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StudentNameInKhmer)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sex)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sex)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BirthDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BirthDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PhoneNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PhoneNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>

    </dl>
</div>
<p>
    <a class="btn btn-primary" href="@Url.Action("Edit", New With {.id = Model.StudentId})">Edit</a> |
    <a href="@Url.Action("Index")" class="btn btn-primary">Back to List</a>
</p>
