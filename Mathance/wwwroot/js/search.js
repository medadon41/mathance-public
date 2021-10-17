"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/searchHub").build();

//Disable send button until connection is established
document.getElementById("search-button").disabled = true;

connection.on("SearchResult", function (names) {
    if(names.length == 0) {
        alert("Not found!")
    }
    var div = document.getElementById("search-results");
    while(div.firstChild) {
        div.removeChild(div.firstChild)
    }

    names.forEach(element => {
        div.appendChild(document.createElement("hr"));
        let h2 = document.createElement("h5");
        let title = document.createElement("a");
        title.setAttribute("href", "https://localhost:44326/Posts/Post/"+element.id);
        title.textContent = element.title;
        h2.appendChild(title);
        div.appendChild(h2);

        let topic = document.createElement("h6");
        topic.textContent = element.topic;
        div.appendChild(topic);
    });
});

connection.start().then(function () {
    document.getElementById("search-button").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("search-button").addEventListener("click", function (event) {
    var text = document.getElementById("search-input").value;
    connection.invoke("TrySearch", text).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});