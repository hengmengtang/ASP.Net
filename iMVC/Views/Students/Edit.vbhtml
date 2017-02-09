@ModelType Student
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Student</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.StudentId)

         <div class="form-group">
             <label class="col-sm-2 control-label">Student Name</label>
             <div class="col-md-10">
                 @Html.TextBoxFor(Function(model) model.StudentName, New With {.class = "form-control", .placeholder = "Student Name"})
                 @Html.ValidationMessageFor(Function(model) model.StudentName)
             </div>
         </div>

         <div class="form-group">
             <label class="col-sm-2 control-label">Student Name In Khmer</label>
             <div class="col-md-10">
                 @Html.TextBoxFor(Function(model) model.StudentNameInKhmer, New With {.class = "form-control", .placeholder = "Student Name In Khmer"})
                 @Html.ValidationMessageFor(Function(model) model.StudentNameInKhmer)
             </div>
         </div>

         <div class="form-group">
             <label class="col-sm-2 control-label">Sex</label>
             <div class="col-md-10">
                 <label class="radio-inline col-md-1">
                     Male  @Html.RadioButtonFor(Function(model) model.Sex, "Male", New With {.checked = "checked"})
                 </label>
                 <label class="radio-inline col-md-2">
                     Female @Html.RadioButtonFor(Function(model) model.Sex, "Female")
                 </label>
                 @Html.ValidationMessageFor(Function(model) model.Sex)
             </div>
         </div>

         <div class="form-group">
             <label class="col-sm-2 control-label">Date of Birth</label>
             <div class="col-md-3">
                 <div class='input-group date'>
                     @Html.TextBoxFor(Function(model) model.BirthDate, New With {.class = "form-control", .placeholder = "Date of Birth", .id = "datetimepicker1"})
                     <span class="input-group-addon">
                         <span class="glyphicon glyphicon-calendar"></span>
                     </span>
                 </div>
                 @Html.ValidationMessageFor(Function(model) model.BirthDate)
             </div>
         </div>
         <div class="form-group">
             <label class="col-sm-2 control-label">Phone Number</label>
             <div class="col-md-10">
                 @Html.TextBoxFor(Function(model) model.PhoneNumber, New With {.class = "form-control", .placeholder = "Phone Number"})
                 @Html.ValidationMessageFor(Function(model) model.PhoneNumber)
             </div>
         </div>

         <div class="form-group">
             <label class="col-sm-2 control-label">Address</label>
             <div class="col-md-10">
                 @Html.TextBoxFor(Function(model) model.Address, New With {.class = "form-control", .placeholder = "Address"})
                 @Html.ValidationMessageFor(Function(model) model.Address)
             </div>
         </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-warning" />
            </div>
        </div>
    </div>
End Using

<div>
   <a class="btn btn-primary" href="@Url.Action("Index")">Back</a>
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
    <script src="~/Scripts/jquery-ui.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#datetimepicker1').datepicker();
        });
    </script>
End Section
