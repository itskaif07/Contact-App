
//E-mail feature
document.addEventListener("DOMContentLoaded", function () {
    const emailImage = document.querySelector("#emailImage");

    if (emailImage) {
        const email = emailImage.getAttribute('data-email');

        emailImage.addEventListener('click', function (e) {
            e.preventDefault();
            window.location.href = `mailto:${email}`;  
        });
    }
});
