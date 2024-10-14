document.addEventListener("DOMContentLoaded", function () {
    const emailImage = document.querySelector("#emailImage");

    if (emailImage) {
        const email = emailImage.getAttribute('data-email'); // Get the email from the data attribute

        emailImage.addEventListener('click', function (e) {
            e.preventDefault();
            window.location.href = `mailto:${email}`;  // Trigger mailto link
            console.log("clicked");
        });
    }
});
