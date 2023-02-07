let cards = document.querySelectorAll(".profile-collage .container .card");
let block = false;

let input_form = document.querySelector(".pop-up-window.input-coin");
let input_form_email = document.querySelector(".pop-up-window.input-coin .body form input[name='email']")
let cover_overlay = document.querySelector(".cover-overlay");

let pop_up_windows = document.querySelectorAll(".pop-up-window");

cards.forEach(card => {
    card.addEventListener("click", (e) => {
        if (block) {
            block = false;

            let email = card.querySelector(".profile-collage .container .card .front .detail .identity .email");
            input_form_email.value = email.textContent;

            return;
        }
        card.classList.toggle("flip");
    });

    let add = card.querySelector(".front .detail .add");
    add.addEventListener("click", (e) => {
        block = true;

        input_form.classList.add("active");
        cover_overlay.classList.add("active");
    })
});

pop_up_windows.forEach(window => {
    let close = window.querySelector(".header .close-button");

    close.addEventListener("click", (e) => {
        window.classList.remove("active");
        cover_overlay.classList.remove("active");
    })
});
