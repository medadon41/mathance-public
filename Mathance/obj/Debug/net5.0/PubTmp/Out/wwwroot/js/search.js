"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/searchHub").build();

//Disable send button until connection is established
document.getElementById("search-button").disabled = true;

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

connection.start().then(function () {
    document.getElementById("search-button").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("search-button").addEventListener("click", function (event) {
    let text = document.getElementById("search-input").value;
    connection.invoke("TrySearch", text).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});