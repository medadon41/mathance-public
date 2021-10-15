"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/commentHub").build();

//Disable send button until connection is established
document.getElementById("button-addon2").disabled = true;

connection.on("ReceiveComment", function (user, message, dateposted, commid) {
    var div = document.createElement("div");
    div.classList.add('comment');
    div.id = commid;
    document.querySelector(".comments").appendChild(div);

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
    like.classList.add("comment-like", "bi", "bi-chevron-up");
    like.setAttribute("href", "#");
    like.setAttribute("name", user)
    like.setAttribute("id", "comment-like-"+commid)
    div.appendChild(like);

    var likecount = document.createElement("label");
    likecount.setAttribute("id", "likes-count-"+commid)
    likecount.textContent = " 0 ";
    div.appendChild(likecount);
    
    var dislike = document.createElement("a");
    dislike.classList.add("comment-dislike", "bi", "bi-chevron-down");
    dislike.setAttribute("href", '#');
    dislike.setAttribute("name", user);
    dislike.setAttribute("id", 'comment-dislike-'+commid);
    div.appendChild(dislike);

    var dislikecount = document.createElement("label");
    dislikecount.setAttribute("id", "dislikes-count-"+commid)
    dislikecount.textContent = " 0 ";
    div.appendChild(dislikecount);

    div.appendChild(document.createElement("hr"));

    setLikeListenres();
    setDislikeListenres();
});

connection.on("ReceiveLike", function (comm, likesAmount, dislikesAmount, hasLiked) {
  //  var commentdiv = document.getElementById(comm);
    var likescount = document.getElementById("likes-count-"+comm)
    likescount.textContent = likesAmount;

    var dislikescount = document.getElementById("dislikes-count-"+comm)
    dislikescount.textContent = dislikesAmount;

    var likesymbol = document.getElementById("comment-like-"+comm);
    var dislikesymbol = document.getElementById("comment-dislike-"+comm);
    if(hasLiked) {
        likesymbol.classList.replace('bi-chevron-up', 'bi-chevron-double-up');
        if(dislikesymbol.classList.contains("bi-chevron-double-down"));
            dislikesymbol.classList.replace("bi-chevron-double-down", "bi-chevron-down");
    }
     else {
        likesymbol.classList.replace('bi-chevron-double-up', 'bi-chevron-up')     
    }
});

connection.on("ReceiveDislike", function (comm, likesAmount, dislikesAmount, hasDisliked) {
    var likescount = document.getElementById("likes-count-"+comm)
    likescount.textContent = likesAmount;

    var dislikescount = document.getElementById("dislikes-count-"+comm)
    dislikescount.textContent = dislikesAmount;

    var likesymbol = document.getElementById("comment-like-"+comm);
    var dislikesymbol = document.getElementById("comment-dislike-"+comm);
    if(hasDisliked) {
        dislikesymbol.classList.replace('bi-chevron-down', 'bi-chevron-double-down');
        if(likesymbol.classList.contains("bi-chevron-double-up"));
            likesymbol.classList.replace("bi-chevron-double-up", "bi-chevron-up");
    }
     else {
        dislikesymbol.classList.replace('bi-chevron-double-down', 'bi-chevron-down')     
    }
});

connection.start().then(function () {
    document.getElementById("button-addon2").disabled = false;
    setLikeListenres();
    setDislikeListenres();
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

function setLikeListenres() {
    var likeslist = document.querySelectorAll(".comment-like").forEach(item =>
    {    item.addEventListener("click", function (event) {
            var user = item.name;
            var commid = item.parentElement.id;
            var postid =  document.querySelector(".comments").id;
            connection.invoke("LikeComment", postid, commid, user).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        })
    });
}

function setDislikeListenres() {
    var dislikeslist = document.querySelectorAll(".comment-dislike").forEach(item =>
    {    item.addEventListener("click", function (event) {
            var user = item.name;
            var commid = item.parentElement.id;
            var postid =  document.querySelector(".comments").id;
            connection.invoke("DislikeComment", postid, commid, user).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        })
    });
}