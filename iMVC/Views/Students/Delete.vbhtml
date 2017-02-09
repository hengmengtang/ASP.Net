@ModelType Student
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions">
            <input type="submit" value="Delete" class="btn btn-primary"  /> |
            <a class="btn btn-primary" href="@Url.Action("Index")">Back to List</a>
        </div>
    End Using
</div>
