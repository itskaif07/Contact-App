
//Upload Image


let uploadImageButton = document.querySelector("#uploadImageButton");
let uploadImage = document.querySelector("#uploadImage");



uploadImageButton.addEventListener('change', function () {
    if (this.files && this.files[0]) {
        uploadImage.src = URL.createObjectURL(this.files[0]);
    }
});



// default image on error

window.onload = function () {
    const defaultImage = "~/images/uploadImage.png";

    document.querySelectorAll('img').forEach(img => {
        img.onerror = function () {
            this.onerror = null;
            this.src = defaultImage;
        };
    });
};
