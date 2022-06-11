let body = document.querySelector('body')
body.style.fontFamily = 'Arial, sans-serif'
body.style.backgroundColor="red"
console.log(Nickname.innerHTML);

let Nickname=document.getElementById('nickname')
Nickname.innerHTML+='Briancito'
let Favorites=document.getElementById('favorites')
Favorites.innerHTML+='games'
let Hometown=document.getElementById('hometown')
Hometown.innerHTML+='Turin'

let classes=document.querySelector('li')
classes.className('list-item');