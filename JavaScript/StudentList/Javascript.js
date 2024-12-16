var selectedRow = null;
var n = 1;
function myFunction(e) {
  event.preventDefault();
  var Name = document.getElementById("Name").value.trim();
  var gender = document.getElementById("gender").value;
  var age = document.getElementById("age").value;
  var email = document.getElementById("email").value;
  var province = document.getElementById("province").value.trim();
  if (!Name & (gender == "Gender") & !age & !email & !province) {
    alert("Please fill in all required fields.");

    return;
  } else {
    if (!Name) {
      // alert("Please fill in name required fields.");
      document.getElementById("Name").classList.add("is-invalid");
      document.getElementById("Name").focus();
      return;
    }

    document.getElementById("Name").classList.remove("is-invalid");
    if (gender == "Gender") {
      // alert("Please select in gender required fields.");
      document.getElementById("gender").classList.add("is-invalid");
      document.getElementById("gender").focus();
      return;
    }
    document.getElementById("gender").classList.remove("is-invalid");
    if (!age) {
      // alert("Please fill in age required fields.");
      document.getElementById("age").classList.add("is-invalid");
      document.getElementById("age").focus();
      return;
    }
    document.getElementById("age").classList.remove("is-invalid");
    if (!email) {
      // alert("Please fill in email required fields.");
      document.getElementById("email").classList.add("is-invalid");
      document.getElementById("email").focus();

      return;
    }
    document.getElementById("email").classList.remove("is-invalid");
    if (!province) {
      // alert("Please fill in province required fields.");
      document.getElementById("province").classList.add("is-invalid");
      document.getElementById("province").focus();
      return;
    }
    document.getElementById("province").classList.remove("is-invalid");
  }

  //check age
  if (isNaN(age) || age <= 0 || age > 150) {
    alert("Input age again between 1 to 150.");
    return;
  }

  // check email
  if (!isValidEmail(email)) {
    alert("Invalid email.");

    return;
  }
  var formData = readFormData();
  if (selectedRow == null) {
    insertNewRecord(formData);
  }
}

function readFormData() {
  var formData = {};
  formData["auto"] = document.getElementById("auto").value;
  formData["Name"] = document.getElementById("Name").value;
  formData["gender"] = document.getElementById("gender").value;
  formData["age"] = document.getElementById("age").value;
  formData["email"] = document.getElementById("email").value;
  formData["province"] = document.getElementById("province").value;
  return formData;
}

function insertNewRecord(data) {
  console.log(data);
  var table = document
    .getElementById("myTable")
    .getElementsByTagName("tbody")[0];

  var isDuplicate = false;

  for (var i = 0; i < table.rows.length; i++) {
    if (table.rows[i].cells[4].innerHTML === data.email) {
      isDuplicate = true;
      break;
    }
  }

  if (isDuplicate) {
    alert("You have entered duplicate Email data.");
    return; // Return without inserting or clearing form
  }

  var newRow = table.insertRow(table.length);
  var cell1 = newRow.insertCell(0);
  var cell2 = newRow.insertCell(1);
  var cell3 = newRow.insertCell(2);
  var cell4 = newRow.insertCell(3);
  var cell5 = newRow.insertCell(4);
  var cell6 = newRow.insertCell(5);
  var cell7 = newRow.insertCell(6);

  cell1.innerHTML = n++;
  cell2.innerHTML = data.Name;
  cell3.innerHTML = data.gender;
  cell4.innerHTML = data.age;
  cell5.innerHTML = data.email;
  cell6.innerHTML = data.province;
  cell7.innerHTML = `<button type="button" class="btn btn-info me-2" onclick='onEdit(this)'>Edit</button>
                    <button type="button" class="btn btn-danger" onclick='onDelete(this)'>Delete</button>`;
  resetForm();
}

function onEdit(td) {
  console.log(td.parentElement.parentElement.parentElement);
  selectedRow = td.parentElement.parentElement;
  document.getElementById("auto").value = selectedRow.cells[0].innerHTML;
  document.getElementById("Name").value = selectedRow.cells[1].innerHTML;
  document.getElementById("gender").value = selectedRow.cells[2].innerHTML;
  document.getElementById("age").value = selectedRow.cells[3].innerHTML;
  document.getElementById("email").value = selectedRow.cells[4].innerHTML;
  document.getElementById("province").value = selectedRow.cells[5].innerHTML;
  // Show Update and Cancel buttons
  selectedRow.cells[6].innerHTML = `<button type="button" class="btn btn-success me-2" onclick='updateRow()'>Update</button>
   <button type="button" class="btn btn-warning" onclick='cancelEdit()'>Cancel</button>`;

  // Hide Add button
  document.getElementById("btnadd").style.display = "none";
}
function updateRecord(formData) {
  selectedRow.cells[0].innerHTML = formData.auto;
  selectedRow.cells[1].innerHTML = formData.Name;
  selectedRow.cells[2].innerHTML = formData.gender;
  selectedRow.cells[3].innerHTML = formData.age;
  selectedRow.cells[4].innerHTML = formData.email;
  selectedRow.cells[5].innerHTML = formData.province;
}
function onDelete(td) {
  var row = td.parentElement.parentElement;

  // Show confirmation dialog
  if (confirm("Are you sure you want to delete this record?")) {
    document.getElementById("myTable").deleteRow(row.rowIndex);
    n--; // Decrement the row number variable
    updateIDs(); // Update the row numbers in the table
    resetForm();
  }
}

function resetForm() {
  document.getElementById("auto").value = "";
  document.getElementById("Name").value = "";
  document.getElementById("gender").value = "Gender";
  document.getElementById("age").value = "";
  document.getElementById("email").value = "";
  document.getElementById("province").value = "";
}
function updateIDs() {
  var table = document
    .getElementById("myTable")
    .getElementsByTagName("tbody")[0];
  var rows = table.getElementsByTagName("tr");
  for (var i = 0; i < rows.length; i++) {
    rows[i].cells[0].innerHTML = i + 1;
  }
}
function isValidEmail(email) {
  // Regular expression pattern for validating email addresses
  const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return emailPattern.test(email);
}
function inputage(evt) {
  var ch = String.fromCharCode(evt.which);
  if (!/[0-9]/.test(ch)) {
    evt.preventDefault();
  }
}
function inputname(evt) {
  var ch = String.fromCharCode(evt.which);
  if (!/[a-zA-Z\s]/.test(ch) || evt.keyCode === 46) {
    evt.preventDefault();
  }
}
function updateRow() {
  var formData = readFormData();

  var table = document
    .getElementById("myTable")
    .getElementsByTagName("tbody")[0];

  var isDuplicate = false;

  for (var i = 0; i < table.rows.length; i++) {
    if (
      table.rows[i].cells[4].innerHTML === formData.email &&
      table.rows[i] !== selectedRow
    ) {
      isDuplicate = true;
      break;
    }
  }

  if (isDuplicate) {
    alert("You have entered duplicate Email data.");
    return; // Return without updating
  }

  var confirmation = confirm("Are you okay with the changes?");
  if (!confirmation) {
    return; // User clicked cancel, so we return without updating
  }

  updateRecord(formData);
  resetForm();

  selectedRow.cells[6].innerHTML = `<button type="button" class="btn btn-info me-2" onclick='onEdit(this)'>Edit</button>
                                   <button type="button" class="btn btn-danger" onclick='onDelete(this)'>Delete</button>`;

  // Show Add button
  document.getElementById("btnadd").style.display = "inline-block";

  // Reset selectedRow
  selectedRow = null;

  // alert("Are you okay with the changes?");
}
function cancelEdit() {
  resetForm();

  selectedRow.cells[6].innerHTML = `<button type="button" class="btn btn-info me-2" onclick='onEdit(this)'>Edit</button>
                                   <button type="button" class="btn btn-danger" onclick='onDelete(this)'>Delete</button>`;
  // Show Add button
  document.getElementById("btnadd").style.display = "inline-block";
  // Reset selectedRow
  selectedRow = null;
}
