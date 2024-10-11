
let emailButton = document.querySelector("#emailButton");
let emailInput = document.querySelector("#email");
let minEmail = document.querySelector("#minEmail");


emailButton.addEventListener('click', async function () {

    emailButton.classList.toggle("hidden")
    emailInput.classList.toggle("hidden")

    await gsap.from(emailInput, {
        duration: 0.2,
        y: -10,
       opacity: 1,
       ease: Power2.easeIn(),
    })

})

minEmail.addEventListener('click', async () => {
    emailButton.classList.toggle("hidden")
    emailInput.classList.toggle("hidden")

    await gsap.from(emailButton, {
        duration: 0.2,
        y: 10,
        ease: "Power2.in",
    })
})


let birthDayButton = document.querySelector("#birthDayButton");
let birthDayInput = document.querySelector("#birthDay");
let minbirthDay = document.querySelector("#minbirthDay");


birthDayButton.addEventListener('click', async function () {

    birthDayButton.classList.toggle("hidden")
    birthDayInput.classList.toggle("hidden")

    await gsap.from(birthDayInput, {
        duration: 0.2,
        y: -10,
        opacity: 1,
        ease: "Power2.in",
    })

})

minbirthDay.addEventListener('click', async () => {
    birthDayButton.classList.toggle("hidden")
    birthDayInput.classList.toggle("hidden")

    await gsap.from(birthDayButton, {
        duration: 0.2,
        y: 10,
        ease: "Power2.in",
    })
})


let addressButton = document.querySelector("#addressButton");
let addressInput = document.querySelector("#address");
let minaddress = document.querySelector("#minaddress");


addressButton.addEventListener('click', async function () {

    addressButton.classList.toggle("hidden")
    addressInput.classList.toggle("hidden")

    await gsap.from(addressInput, {
        duration: 0.2,
        y: -10,
        opacity: 1,
        ease: "Power2.in",
    })

})

minaddress.addEventListener('click', async () => {
    addressButton.classList.toggle("hidden")
    addressInput.classList.toggle("hidden")

    await gsap.from(addressButton, {
        duration: 0.2,
        y: 10,
        ease: "Power2.in",
    })
})


let nicknameButton = document.querySelector("#nicknameButton");
let nicknameInput = document.querySelector("#nickname");
let minnickname = document.querySelector("#minnickname");


nicknameButton.addEventListener('click', async function () {

    nicknameButton.classList.toggle("hidden")
    nicknameInput.classList.toggle("hidden")

    await gsap.from(nicknameInput, {
        duration: 0.2,
        y: -10,
        opacity: 1,
        ease: "Power2.in",
    })

})

minnickname.addEventListener('click', async () => {
    nicknameButton.classList.toggle("hidden")
    nicknameInput.classList.toggle("hidden")

    await gsap.from(minnickname, {
        duration: 0.2,
        y: 10,
        ease: "Power2.in",
    })
})




let notesButton = document.querySelector("#notesButton");
let notesInput = document.querySelector("#notes");
let minnotes = document.querySelector("#minnotes");


notesButton.addEventListener('click', async function () {

    notesButton.classList.toggle("hidden")
    notesInput.classList.toggle("hidden")

    await gsap.from(notesInput, {
        duration: 0.2,
        y: -10,
        opacity: 1,
        ease: "Power2.in",
    })

})

minnotes.addEventListener('click', async () => {
    notesButton.classList.toggle("hidden")
    notesInput.classList.toggle("hidden")

    await gsap.from(notesButton, {
        duration: 0.2,
        y: 10,
        ease: "Power2.in",
    })
})


