$(document).ready(function () {
  $("ul").hide();
  $("#btnadd").click(function () {
    $("ul").show();
    var input = $("#input").val(); // Corrected .val() function call
    if (!input) {
      $("#todo").addClass("todo");
      $("#todo").text("New Todo *");
      $("#input").addClass("is-invalid");
      $("#add").text("Please fill out this field.");
      return;
    }
    $("#ul").append(
      "<li>" +
        input +
        '<i class="fa-solid fa-rectangle-xmark cancel"></i>' +
        '<i class="fa-solid fa-pen-fancy text-danger edit"></i>' +
        '<i class="fa-solid fa-trash-can text-danger delete"></i>' +
        "</li>"
    );
    $("#todo").text("New Todo:");
    $("#input").val(""); // Corrected appending format
    $("#add").empty();
    $("#input").removeClass("is-invalid");
    $("#txtedit").removeClass("is-invalid");
    $("#todo").removeClass("todo");
    $(".cancel").hide();
  });

  $("#ul").on("click", ".delete", function () {
    var confirmation = confirm("Are you sure?");
    if (confirmation) {
      $("#input").prop("readonly", false);
      $("#txtedit").prop("disabled", true);
      $(this).parent("li").remove();
      $("#txtedit").val("");
    }
  });

  var add = $("#txtedit");
  if (add.val() == "") {
    // If txtedit is empty
    $("#txtedit").prop("disabled", true);
  }
  $("#ul").on("click", ".edit", function () {
    var confirmation = confirm("Are you Edit?");
    if (confirmation) {
      var listItem = $(this).parent("li");
      var textValue = listItem.text().trim();

      // Set the value of input field #txtedit
      $("#txtedit").prop("disabled", false);
      $("#input").prop("readonly", true);
      listItem.find(".edit").hide();
      listItem.find(".delete").hide();
      listItem.find(".cancel").show();
      $("#txtedit").val(textValue);
      // Store the listItem in a data attribute for later use
      $("#txtedit").data("listItem", listItem);
    }
  });

  $("#ul").on("click", ".cancel", function () {
    var confirmation = confirm("Are you cancel");
    if (confirmation) {
      var olddata = $(this).parent("li");
      var listItem = olddata.data("listItem");
      $("#txtedit").val("");
      $("#input").prop("readonly", false);
      $("#txtedit").prop("disabled", true);
      olddata.find(".edit").show();
      olddata.find(".delete").show();
      olddata.find(".cancel").hide();
      $("#txtedit").removeClass("is-invalid");
      listItem.html(
        olddata +
          '<i class="fa-solid fa-pen-fancy text-danger edit"></i>' +
          '<i class="fa-solid fa-trash-can text-danger delete"></i>'
      );
    }
  });

  $("#btnsave").click(function () {
    var editedText = $("#txtedit").val();

    if (!editedText) {
      $("#txtedit").addClass("is-invalid");
      return;
    }
    var listItem = $("#txtedit").data("listItem");
    console.log(listItem); // Retrieve the listItem from data attribute
    $("#txtedit").val("");
    $("#input").prop("readonly", false);
    $("#txtedit").prop("disabled", true);

    listItem.html(
      editedText +
        '<i class="fa-solid fa-rectangle-xmark cancel"></i>' +
        '<i class="fa-solid fa-pen-fancy text-danger edit"></i>' +
        '<i class="fa-solid fa-trash-can text-danger delete"></i>'
    ); // Update the text of the listItem
    $("#txtedit").removeClass("is-invalid");
    $(".cancel").hide();
  });
});
