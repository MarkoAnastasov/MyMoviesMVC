async function getDataAsync(path) {
    const instance = axios.create({ baseURL: 'https://localhost:44390' });
    return instance.get(path, {
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        }
    })
        .then(response => {
            var data = response.data;
            return data;
        })
        .catch(error => {
            console.log(error);
        })
}

async function postDataAsync(path,object) {
    const instance = axios.create({ baseURL: 'https://localhost:44390' });
    return instance.post(path, object, {
        headers: {
            'Content-Type': 'application/json',
        }
    })
        .then(response => {
            var data = response.data;
            return data;
        })
        .catch(error => {
            console.log(error.response);
        })
}

function ManageUserMovieDTO(movieId,actionName) {
    this.movieId = movieId;
    this.actionName = actionName;
}

async function checkIfUserMovie() {
    var movieIdField = $("#movie-id-input").val();
    var movieIdInt = parseInt(movieIdField);
    var result = await getDataAsync(`/checkmovie/${movieIdInt}`);
    $("#loading-data").hide();
    if (typeof result !== 'undefined') {
        if (result.isUserMovie === false) {
            addUserMovie(movieIdInt);
        }
        else {
            userActionsOrder(result, movieIdInt);
            removeUserMovie(movieIdInt);
        }
    }
    else {
        $("#data-errors").show().text("An error has occured while processing data.Try again later!");
    }
}

function userActionsOrder(result,movieIdInt) {
    if (result.isFavourite === false) {
        favUserMovie(movieIdInt);
    }
    else {
        unfavUserMovie(movieIdInt);
    }
    if (result.isWatched === false) {
        watchedUserMovie(movieIdInt);
    }
    else {
        unwatchUserMovie(movieIdInt);
    }
}

function addUserMovie(movieIdInt) {
    var addToMyMovies = $(document.createElement("p")).text("Add movie").addClass("user-action-button").attr("id", "add-my-movies");
    $("#user-actions-movie").append(addToMyMovies).css("display", "flex");
    actionUserMovie($("#add-my-movies"), `/addusermovie`, "add", movieIdInt);
}

function removeUserMovie(movieIdInt) {
    var removeMyMovie = $(document.createElement("p")).text("Remove").addClass("user-action-button").attr("id", "remove-my-movies");
    $("#user-actions-movie").append(removeMyMovie).css("display", "flex");
    actionUserMovie($("#remove-my-movies"), `/removeusermovie`, "remove", movieIdInt);
}

function favUserMovie(movieIdInt) {
    var favMovie = $(document.createElement("p")).text("Favourite").addClass("user-action-button").attr("id", "fav-my-movies");
    $("#user-actions-movie").append(favMovie).css("display", "flex");
    actionUserMovie($("#fav-my-movies"), `/manageusermovie`, "favourite", movieIdInt);
}

function unfavUserMovie(movieIdInt) {
    var unfavMovie = $(document.createElement("p")).text("Unfave").addClass("user-action-button").attr("id", "unfav-my-movies");
    $("#user-actions-movie").append(unfavMovie).css("display", "flex");
    actionUserMovie($("#unfav-my-movies"), `/manageusermovie`, "unfavourite", movieIdInt);
}

function watchedUserMovie(movieIdInt) {
    var watchedMovie = $(document.createElement("p")).text("Watched").addClass("user-action-button").attr("id", "watched-my-movies");
    $("#user-actions-movie").append(watchedMovie).css("display", "flex");
    actionUserMovie($("#watched-my-movies"), `/manageusermovie`, "watched", movieIdInt);
}

function unwatchUserMovie(movieIdInt) {
    var unWatch = $(document.createElement("p")).text("Unwatch").addClass("user-action-button").attr("id", "unwatch-my-movies");
    $("#user-actions-movie").append(unWatch).css("display", "flex");
    actionUserMovie($("#unwatch-my-movies"), `/manageusermovie`, "unwatch", movieIdInt);
}


function actionUserMovie(button,path,actionName,movieIdInt) {
    button.click(async function () {
        $("#data-errors").hide();
        $("#user-actions-movie").css("display", "none");
        $("#loading-data").show();
        var manageUserMovieDTO = new ManageUserMovieDTO();
        manageUserMovieDTO.movieId = movieIdInt;
        manageUserMovieDTO.actionName = actionName;
        var response = await postDataAsync(path, manageUserMovieDTO);
        if (typeof response !== "undefined") {
            location.reload();
        }
        else {
            $("#user-actions-movie").css("display", "flex")
            $("#data-errors").show().text("An error has occured while processing data.Try again later!");
        }
    })
}

function checkMovieIdOnSubmit() {
    var movieId = parseInt($("#movie-id-form").val());
    $("#add-comment-form").submit(function () {
        if (parseInt($("#movie-id-form").val()) != movieId) {
            return false;
        }

        return true;
    })
}

$(document).ready(function () {
    checkMovieIdOnSubmit();
    checkIfUserMovie();
})