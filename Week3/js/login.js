function validateUser() {
    document.getElementById('username-error').style.visibility = 'hidden'
    document.getElementById('password-error').style.visibility = 'hidden'

    let username = document.getElementById('username').value
    let password = document.getElementById('password').value

    if (username == '') {
        document.getElementById('username-error').style.visibility = 'visible'
    }

    if (password == '') {
        document.getElementById('password-error').style.visibility = 'visible'
    }
}