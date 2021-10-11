//  SweetAlert2 notifications

function sweetAlertSuccess(_title, _message) {
    Swal.fire({
        icon: 'success',
        title: _title,
        text: _message,
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        allowOutsideClick: false,
        reverseButtons: true
    })
}

function sweetAlertError(_title, _message) {
    Swal.fire({
        icon: 'error',
        title: _title,
        text: _message,
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        allowOutsideClick: false,
        reverseButtons: true
    })
}

function sweetAlertWarning(_title, _message) {
    Swal.fire({
        icon: 'warning',
        title: _title,
        text: _message,
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        allowOutsideClick: false,
        reverseButtons: true
    })
}

function sweetAlertSuccess_BaseClassUpload() {
    Swal.fire({
        icon: 'success',
        title: "Base Class File Upload",
        text: "Your file was processed",
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        confirmButtonText: 'View Result',
        allowOutsideClick: false,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            // redirect to result page
            window.location.href = '/BaseClass/UploadBaseClassResult/';
        }
    })
}

function sweetAlert2_CompleteBaseClassUpload() {
    Swal.fire({
        icon: 'question',
        title: "Complete Process",
        text: 'Are you sure you want to save these records?',
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        confirmButtonText: 'Complete Process',
        showCancelButton: true,
        cancelButtonText: "Cancel",
        allowOutsideClick: false,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            loadingSpinner_Show();
            $.ajax({
                url: '/BaseClass/CompleteProcessBaseStudentUpload/',
                type: 'GET',
                success: function () {
                    loadingSpinner_Hide();
                    sweetAlert_RedirectToManageBaseClass("Base Class Upload", "All records saved successfully.");
                },
                error: function () {
                    loadingSpinner_Hide();
                    sweetAlertError("Base Class Upload", "Failed to upload the records.");
                }
            });
        }
    })
}

function sweetAlert_RedirectToManageBaseClass(_title, _message) {
    Swal.fire({
        icon: 'success',
        title: _title,
        text: _message,
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        confirmButtonText: 'Manage Base Class',
        allowOutsideClick: false,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = '/BaseClass/ManageBaseClass/';
        }
    });
}

function sweetAlertSuccess_StudentScreeningUpload() {
    Swal.fire({
        icon: 'success',
        title: "Student Screening File Upload",
        text: "Your file was processed",
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        confirmButtonText: 'View Result',
        allowOutsideClick: false,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            // redirect to result page
            window.location.href = '/StudentScreening/UploadStudentScreeningResult/';
        }
    })
}

function sweetAlert_CompleteStudentScreeningUpload() {
    Swal.fire({
        icon: 'question',
        title: "Complete Process",
        text: 'Are you sure you want to save these records?',
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        confirmButtonText: 'Complete Process',
        showCancelButton: true,
        cancelButtonText: "Cancel",
        allowOutsideClick: false,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            loadingSpinner_Show();
            $.ajax({
                url: '/StudentScreening/CompleteStudentScreeningUpload/',
                type: 'GET',
                success: function () {
                    loadingSpinner_Hide();
                    sweetAlert_RedirectToManageStudentScreening("Student Screening Upload", "All records saved successfully.");
                },
                error: function () {
                    loadingSpinner_Hide();
                    sweetAlertError("Student Screening Upload", "Failed to upload the records.");
                }
            });
        }
    })
}

function sweetAlert_RedirectToManageStudentScreening(_title, _message) {
    Swal.fire({
        icon: 'success',
        title: _title,
        text: _message,
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        },
        showConfirmButton: true,
        confirmButtonColor: '#217093 ',
        confirmButtonText: 'Manage Student Screening',
        allowOutsideClick: false,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = '/StudentScreening/ManageStudentScreening/';
        }
    });
}

//  Loading spinner

function loadingSpinner_Show() {
    $(".loading-overlay").fadeIn(500);
}

function loadingSpinner_Hide() {
    $(".loading-overlay").fadeOut(500);
}