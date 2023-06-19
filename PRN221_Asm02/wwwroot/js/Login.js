const container = document.querySelector(".container"),
    pwShowHide = document.querySelectorAll(".showHidePw"),
    pwFields = document.querySelectorAll(".password");


//   js code to show/hide password and change icon
pwShowHide.forEach(eyeIcon => {
    eyeIcon.addEventListener("click", () => {
        pwFields.forEach(pwField => {
            if (pwField.type === "password") {
                pwField.type = "text";

                pwShowHide.forEach(icon => {
                    icon.classList.replace("uil-eye-slash", "uil-eye");
                })
            } else {
                pwField.type = "password";

                pwShowHide.forEach(icon => {
                    icon.classList.replace("uil-eye", "uil-eye-slash");
                })
            }
        })
    })
})



// Phong cách bắt lỗi từng cái
var patt_email = /^\w+([\.-]\w+)*@\w+([\.-]\w+)*(\.\w{2,3})+$/;
var patt_phone = /^[+]?[(]?[0-9]{3}[)]?[-\s.]?[0-9]{3}[-\s.]?[0-9]{4,6}$/im;
function checkUsername() {
    tk = document.getElementById("txtUsername").value;
    document.getElementById("txtUsernameMessage").innerHTML =
        tk.trim() == "" ? "Username can't be empty" : "";
    return tk != "" ? true : false;
}

function checkPassword1() {
    mk1 = document.getElementById("txtPassword1").value;
    document.getElementById("txtPassword1Message").innerHTML =
        (mk1.length < 6 || mk1.length > 20) ?
            "Password length must be from 6 to 20 characters" : "";
    return mk1.length >= 6 && mk1.length <= 20;
}

function checkPassword2() {
    mk1 = document.getElementById("txtPassword1").value;
    mk2 = document.getElementById("txtPassword2").value;
    document.getElementById("txtPassword2Message").innerHTML =
        (mk1 != mk2) ?
            "Password doesn't match" : "";
    return mk1 == mk2;
}


function checkEmail() {
    email = document.getElementById("txtEmail").value;
    document.getElementById("txtEmailMessage").innerHTML =
        patt_email.test(email) == false ?
            "Email is invalid" : "";
    return patt_email.test(email);
}

function checkAddress() {
    ad = document.getElementById("address").value;
    document.getElementById("txtAddressMessage").innerHTML =
        ad.trim() == "" ? "Address can't be empty" : "";
    return ad != "" ? true : false;
}
function checkPhone() {
    phone = document.getElementById("txtPhone").value;
    document.getElementById("txtPhoneMessage").innerHTML =
        patt_phone.test(phone) == false ?
            "Phone is invalid(only 10 digits)" : "";
    return patt_phone.test(phone);
}

function checkAllData() {
    isValidUsername = checkUsername();
    isValidPassword = checkPassword1();
    isValidPassword2 = checkPassword2();
    isValidEmail = checkEmail();
    isValidAddress = checkAddress();
    isValidPhone = checkPhone();

    isValid = isValidUsername &&
        isValidPassword &&
        isValidPassword2 &&
        isValidAddress &&
        isValidEmail &&
        isValidPhone;

    if (isValid == true) {
        return isValid;
    } else {
        return false;
    }
}

// js code to appear signup and login form

