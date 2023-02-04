let dropdown_menu = document.querySelector('.nav-top .dropdown-menu');
let dropdown_toggle = document.querySelector('.nav-top .about-user .profile .chevron');
let update_profile = document.querySelector('.nav-top .update-profile');
let overlay_blur = document.querySelector('.nav-top .overlay-blur');

dropdown_toggle.addEventListener("click", (e) => {
    dropdown_menu.classList.toggle('active');
    overlay_blur.classList.toggle('active');

    if (dropdown_menu.classList.contains('active'))
        dropdown_toggle.style.transform = "rotate(180deg)";
    else {
        dropdown_toggle.style.transform = "rotate(0deg)";
        update_profile.classList.remove('active');
    }
});

dropdown_menu.querySelector('.edit-trigger').addEventListener("click", (e) => {
    update_profile.classList.add('active');
});

update_profile.addEventListener("mouseleave", (e) => {
    update_profile.classList.remove('active');
});