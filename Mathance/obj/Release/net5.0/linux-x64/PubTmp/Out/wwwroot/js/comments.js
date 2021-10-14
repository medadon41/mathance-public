"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/commentHub").build();

//Disable send button until connection is established
document.getElementById("button-addon2").disabled = true;

connection.on("ReceiveComment", function (user, message, dateposted) {
    var div = document.createElement("div");
    div.classList.add('comment');
    document.getElementById("comments").appendChild(div);

    var innerdiv = document.createElement("div");
    div.appendChild(innerdiv);

    var name = document.createElement("b");
    name.textContent = user;
    innerdiv.appendChild(name);

    var date = document.createElement("i");
    date.textContent = dateposted;
    date.classList.add("font-weight-light");
    innerdiv.appendChild(date);

    var commentdiv = document.createElement("div");
    commentdiv.textContent = message;
    div.appendChild(commentdiv);

    var like = document.createElement("a");
    like.classList.add("bi", "bi-chevron-up");
    like.setAttribute("href", "#");
    div.appendChild(like);
    
    var dislike = document.createElement("a");
    dislike.classList.add("bi", "bi-chevron-down");
    dislike.setAttribute("href", '#');
    div.appendChild(dislike);
});

connection.start().then(function () {
    document.getElementById("button-addon2").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("button-addon2").addEventListener("click", function (event) {
    var user = document.getElementById("comment-input").name;
    var message = document.getElementById("comment-input").value;
    var postid =  document.getElementById("button-addon2").name;
    connection.invoke("SendComment", postid, user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});