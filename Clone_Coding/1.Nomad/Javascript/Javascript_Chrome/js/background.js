/*
    .createElement(TagName) : 태그 생성
    .append(Tag) : 최하단에 태그 추가
    .prepend(Tag) : 최상단에 태그 추가
*/

const images = [
    "고윤정1.jpg","고윤정2.jpg",
    "다현1.jpg","다현2.jpg","다현3.jpg",
    "수지1.jpg","수지2.jpg",
    "아이유1.jpg","아이유2.jpg","아이유3.jpg","아이유4.jpg",
    "프리지아1.jpg","프리지아2.jpg"];

const chosenImage = images[Math.floor(Math.random() * images.length)];

const bgImage = document.createElement("img");

bgImage.src =`img/${chosenImage}`;

//document.body.prepend(bgImage);
document.body.appendChild(bgImage);