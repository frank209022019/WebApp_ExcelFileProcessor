//  SweetAlert2 notifications

function sweetAlertSuccess(_title, _message)
{
    Swal.fire({
        icon: 'success',
        title: _title,
        text: _message,
    })
}

function sweetAlertError(_title, _message) {
    Swal.fire({
        icon: 'error',
        title: _title,
        text: _message,
    })
}

function sweetAlertWarning(_title, _message) {
    Swal.fire({
        icon: 'warning',
        title: _title,
        text: _message,
    })
}