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
                    sweetAlertSuccess("Base Class Upload", "All records saved successfully.");
                    setTimeout(function () {
                        window.location.href = '/BaseClass/ManageBaseClass/';
                    }, 5000);
                },
                error: function () {
                    loadingSpinner_Hide();
                    sweetAlertError("Base Class Upload", "Failed to upload the records.");
                }
            });
        }
    })}

//  Loading spinner

function loadingSpinner_Show() {
    $(".loading-overlay").fadeIn(500);
}

function loadingSpinner_Hide() {
    $(".loading-overlay").fadeOut(500);
}