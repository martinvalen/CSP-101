document.addEventListener('DOMContentLoaded', function () {
    document.getElementById('clickmebutton')
        .addEventListener('click', doStuffOnClick);
});

function doStuffOnClick() {
    alert('Button clicked!');
}