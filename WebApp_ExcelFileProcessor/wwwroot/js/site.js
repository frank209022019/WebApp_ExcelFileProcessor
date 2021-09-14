//  SweetAlert2 notifications

function sweetAlertSuccess(_title, _message)
{
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
        allowOutsideClick: false
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
        allowOutsideClick: false
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
        allowOutsideClick: false
    }).then((result) => {
        if (result.isConfirmed) {
            // redirect to result page
            window.location.href = '/BaseClass/UploadBaseClassResult/';
        } 
    })
}

function loadingSpinner_Show() {
    $(".loading-overlay").fadeIn(500);
}

function loadingSpinner_Hide() {
    $(".loading-overlay").fadeOut(500);
}