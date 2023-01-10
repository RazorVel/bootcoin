let email_acc = false;
let confirm_acc = false;
var errorLabelEmail = document.getElementById("errorLabelEmail");
var errorLabelConfirm = document.getElementById("errorLabelConfirm");


function ValidateEmail() {
    var email = document.getElementById("emailTxt").value;
    var emailreg = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
    if (!emailreg.test(email)) {
        errorLabelEmail.innerHTML = "! Please enter a valid email address.";
        email_acc = false;
    }
    else {
        errorLabelEmail.innerText = ''
        email_acc = true;
    }
}


function ValidateConfirmation() {
    var password = document.getElementById("password").value;
    var confirmPass = document.getElementById('confirm').value;
    if (confirmPass != password) {
        errorLabelConfirm.innerHTML = '! Your passwords do not match.';
        confirm_acc = false;
    }
    else{
        errorLabelConfirm.innerHTML= '';
        confirm_acc = true;
    }
}

