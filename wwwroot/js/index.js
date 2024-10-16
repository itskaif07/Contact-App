
// Search feature

document.addEventListener('DOMContentLoaded', function () {

    document.querySelector("#searchInput").addEventListener("input", (e) => {

        var searchValue = e.target.value.toLowerCase();
        let contacts = document.querySelectorAll(`a[href*="/ContactItems/Details"]`);


        contacts.forEach((contact) => {
            let name = contact.querySelector('h1').innerText.toLowerCase()

            if (name.includes(searchValue)) {
                contact.style.display = "flex"
            }
            else {
                contact.style.display = "none"
            }
        })
    })
})


//Responsive


function updateButtonPosition() {
    const createButton = document.querySelector("#createButton");

    if (window.innerWidth >= 1024) {
        createButton.classList.add('fixed', 'bottom-10', 'right-10');
        createButton.classList.remove('absolute', 'top-4');
    }

    else if (window.innerWidth >= 300) {
        createButton.classList.add('absolute', 'top-4', 'right-4');
        createButton.classList.remove('fixed', 'bottom-10');
    }
    else {

        createButton.classList.add('absolute', '-bottom-16',);
        createButton.classList.remove('top-4', 'fixed', 'right-4');
    }

}

// Initial setup
updateButtonPosition();

// Update on resize
window.addEventListener('resize', updateButtonPosition);


//context menu

let sort = document.querySelector("#sort");

document.addEventListener("DOMContentLoaded", () => {

    document.addEventListener("contextmenu", (e) => {
        e.preventDefault();

        sort.style.left = `${e.pageX}px`;
        sort.style.top = `${e.pageY}px`;


        sort.classList.remove("hidden");
    });

    document.addEventListener("click", (e) => {

        if (!sort.classList.contains('hidden') && e.target !== sort) {
            sort.classList.add("hidden");
        }
    });
});


// sort

function sortContacts(order) {
    window.location.href = "/ContactItems/Index?sortOrder=" + order;
}
