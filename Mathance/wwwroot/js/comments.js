"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/commentHub").build();

//Disable send button until connection is established
document.getElementById("button-addon2").disabled = true;
document.getElementById("search-button").disabled = true;

connection.on("UpdateRating", function (rating) {
    alert(rating);
});

connection.on("ReceiveComment", function (user, message, dateposted, commid) {
    let div = document.createElement("div");
    div.classList.add('comment');
    div.id = commid;
    document.querySelector(".comments").appendChild(div);

    let innerdiv = document.createElement("div");
    div.appendChild(innerdiv);

    let name = document.createElement("b");
    name.textContent = user;
    innerdiv.appendChild(name);

    let date = document.createElement("i");
    date.textContent = dateposted;
    date.classList.add("font-weight-light");
    innerdiv.appendChild(date);

    let commentdiv = document.createElement("div");
    commentdiv.textContent = message;
    div.appendChild(commentdiv);

    let like = document.createElement("a");
    like.classList.add("comment-like", "bi", "bi-chevron-up");
    like.setAttribute("href", "#");
    like.setAttribute("name", user)
    like.setAttribute("id", "comment-like-"+commid)
    div.appendChild(like);
    like = document.getElementById("comment-like-"+commid)
    like.addEventListener("click", function (event) {
        let user = like.name;
        let commid = like.parentElement.id;
        let postid =  document.querySelector(".comments").id;
        connection.invoke("LikeComment", postid, commid, user).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    })

    let likecount = document.createElement("label");
    likecount.setAttribute("id", "likes-count-"+commid)
    likecount.textContent = " 0 ";
    div.appendChild(likecount);
    
    let dislike = document.createElement("a");
    dislike.classList.add("comment-dislike", "bi", "bi-chevron-down");
    dislike.setAttribute("href", '#');
    dislike.setAttribute("name", user);
    dislike.setAttribute("id", 'comment-dislike-'+commid);
    div.appendChild(dislike);
    dislike = document.getElementById("comment-dislike-"+commid)
    dislike.addEventListener("click", function (event) {
        let user = dislike.name;
        let commid = dislike.parentElement.id;
        let postid =  document.querySelector(".comments").id;
        connection.invoke("DislikeComment", postid, commid, user).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    })

    let dislikecount = document.createElement("label");
    dislikecount.setAttribute("id", "dislikes-count-"+commid)
    dislikecount.textContent = " 0 ";
    div.appendChild(dislikecount);

    div.appendChild(document.createElement("hr"));

});

connection.on("SearchResult", function (names) {
    let div = document.getElementById("search-results");
    while(div.firstChild) {
        div.removeChild(div.firstChild)
    }

    if(names.length == 0) {
        div.appendChild(document.createElement("hr"));
        let h2 = document.createElement("h5");
        h2.textContent = "Not found!";
        div.appendChild(h2);
        return;
    }

    names.forEach(element => {
        div.appendChild(document.createElement("hr"));
        let h2 = document.createElement("h5");
        let title = document.createElement("a");
        title.setAttribute("href", "https://mathance.azurewebsites.net/Posts/Post/"+element.id);
        title.textContent = element.title;
        h2.appendChild(title);
        div.appendChild(h2);

        let topic = document.createElement("h6");
        topic.textContent = element.topic;
        div.appendChild(topic);
    });
});


connection.on("ReceiveLike", function (comm, likesAmount, dislikesAmount, hasLiked) {
    let likescount = document.getElementById("likes-count-"+comm)
    likescount.textContent = likesAmount;

    let dislikescount = document.getElementById("dislikes-count-"+comm)
    dislikescount.textContent = dislikesAmount;

    let likesymbol = document.getElementById("comment-like-"+comm);
    let dislikesymbol = document.getElementById("comment-dislike-"+comm);
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
    let likescount = document.getElementById("likes-count-"+comm)
    likescount.textContent = likesAmount;

    let dislikescount = document.getElementById("dislikes-count-"+comm)
    dislikescount.textContent = dislikesAmount;

    let likesymbol = document.getElementById("comment-like-"+comm);
    let dislikesymbol = document.getElementById("comment-dislike-"+comm);
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
    document.getElementById("search-button").disabled = false;
    setLikeListenres();
    setDislikeListenres();
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("button-addon2").addEventListener("click", function (event) {
    let user = document.getElementById("comment-input").name;
    let message = document.getElementById("comment-input").value;
    let postid =  document.getElementById("button-addon2").name;
    connection.invoke("SendComment", postid, user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("search-button").addEventListener("click", function (event) {
    let text = document.getElementById("search-input").value;
    connection.invoke("TrySearch", text).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

function setLikeListenres() {
    let likeslist = document.querySelectorAll(".comment-like").forEach(item =>
    {    
        item.addEventListener("click", function (event) {
            let user = item.name;
            let commid = item.parentElement.id;
            let postid =  document.querySelector(".comments").id;
            connection.invoke("LikeComment", postid, commid, user).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        })
    });
}

function setDislikeListenres() {
    let dislikeslist = document.querySelectorAll(".comment-dislike").forEach(item =>
    {    item.addEventListener("click", function (event) {
            let user = item.name;
            let commid = item.parentElement.id;
            let postid =  document.querySelector(".comments").id;
            connection.invoke("DislikeComment", postid, commid, user).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        })
    });
}

document.querySelectorAll(".star").forEach(item =>{
    item.addEventListener("mouseover", function (event) {
        item.style.color = "#ef3038";
        let stars = document.querySelector(".rating");
        let star = stars.querySelector(".star");
        for(let i = 1; i < item.id; i++) {
            star.style.color = "#ef3038";
            star = star.nextElementSibling;
        }
    })

    item.addEventListener("mouseout", function (event) {
        if(item.classList.contains("star-filled")) {
            item.style.color = "#ff9eb5";
        }
        else {
            item.style.color = "grey";
        }
        let stars = document.querySelector(".rating");
        let star = stars.querySelector(".star");
        for(let i = 1; i < item.id; i++) {
            if(star.classList.contains("star-filled")) {
                star.style.color = "#ff9eb5";
            }
            else {
                star.style.color = "grey";
            }
            star = star.nextElementSibling;
        }
    })

    item.addEventListener("click", function (event) {
        let rate = item.id;
        let postid =  document.querySelector(".rating").id;
        connection.invoke("Rate", rate, postid).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    })
})