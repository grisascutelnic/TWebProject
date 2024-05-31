document.addEventListener('DOMContentLoaded', () => {
    const loginButton = document.getElementById('loginButton');
    const registerButton = document.getElementById('registerButton');
    const logoutButton = document.getElementById('logoutButton');

    // Function to simulate login action
    function login()
    {
        // Hide login and register buttons
        loginButton.style.display = 'none';
        registerButton.style.display = 'none';
        // Show logout button
        logoutButton.style.display = 'block';
    }

    // Function to simulate logout action
    function logout()
    {
        // Show login and register buttons
        loginButton.style.display = 'block';
        registerButton.style.display = 'block';
        // Hide logout button
        logoutButton.style.display = 'none';
    }

    // Add event listeners
    loginButton.addEventListener('click', login);
    registerButton.addEventListener('click', login);
    logoutButton.addEventListener('click', logout);
});
