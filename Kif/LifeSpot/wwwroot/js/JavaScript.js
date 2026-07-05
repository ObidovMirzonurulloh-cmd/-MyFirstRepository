let filterContent = function (userInput) {
  

    let elements = document.getElementsByClassName("video-container");

    for (let i = 0; i < elements.length; i++) {

    let videoText = elements[i].querySelector('h3').innerText;

        if (!videoText.toLowerCase().includes(userInput.toLowerCase())) {
            elements[i].style.display = "none";
        } else {
            elements[i].style.display = "inline-block";
        }
    }
};




let session = new Map();

/*
* Сохранение данных сессии при заходе пользователя
*/
function handleSession() {
    let startDate = new Date().toLocaleString();

    session.set("startDate", startDate);
    session.set("userAgent", window.navigator.userAgent);
}

/*
* Проверка возраста пользователя
*/
function checkAge() {
    let age = Number(prompt("Пожалуйста, введите ваш возраст?"));

    session.set("age", age);

    if (age >= 18) {
        alert(
            "Приветствуем на LifeSpot!\nТекущее время: " +
            new Date().toLocaleString()
        );
    } else {
        alert("Наши трансляции не предназначены для лиц моложе 18 лет. Вы будете перенаправлены");
        window.location.href = "http://www.google.com";
    }
}

/*
* Вывод сессии в консоль
*/
function sessionLog() {
    for (let [key, value] of session) {
        console.log(key + ": " + value);
    }
}

/*
* Получение текста из input
*/
const inputParseFunction = function () {
    return document.getElementsByTagName("input")[0].value.toLowerCase();
};


setTimeout(() => alert("Нравится LifeSpot? " + '\n' + "Подпишитесь на наш Instagram @lifespot999!"), 3000);

function getReviews() {


    let reviews = {}


    reviews["userName"] = prompt("Введите ваше имя: ");
    if (reviews["userName"] == null) {
        return
    }


    reviews["comment"] = prompt("Введите ваш отзыв:");
    if (reviews["comment"] == null) {
        return
    }


    reviews["date"] = new Date().toLocaleDateString();


    writeReview(reviews);
}


const writeReview = review => {
    document.getElementsByClassName('reviews')[0].innerHTML += '    <div class="review-text">\n' +
        `<p> <i> <b>${review['userName']}</b>  ${review['date']}</i></p>` +
        `<p>${review['comment']}</p>` +
        '</div>';
}