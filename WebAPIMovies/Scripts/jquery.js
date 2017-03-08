$().ready(function () {

    $("#getMovies").click(function() {

        $.get("http://localhost:54694/api/Movie", function (resp) {
            console.log(resp);
            renderMovies(resp);
        });
    });

    function renderMovies(movies) {
        var control = $("#movies");
        control.empty();
        for(movie in movies)
        {
            var title = movies[movie].Title;
            var genre = movies[movie].Genre;
            var link = movies[movie].IMDBLink;
            var date = movies[movie].ReleaseDate;

            control.append("<tr><td>" + title + "</td><td>" + genre + "</td><td>" + link + "</td><td>" + date + "</td></tr>");
        }
    }

    $("#getReviews").click(function () {
        $.get("http://localhost:54694/api/Review", function (resp) {
            console.log(resp);
            renderReviews(resp);
        });
    });

    function renderReviews(reviews) {
        var ctrl = $("#reviews");
        ctrl.empty();
        for(review in reviews)
        {
            var rating = reviews[review].Rating;
            var movie = reviews[review].Movie.Title;

            ctrl.append("<tr><td>" + rating + "</td><td>" + movie + "</td></tr>");
        }
    }

    $("#getUsers").click(function () {
        $.get("http://localhost:54694/api/User", function (resp) {
            console.log(resp);
            renderUser(resp);
        });
    });

    function renderUser(users) {
        var controller = $("#users");
        controller.empty();
        for (person in users)
        {
            var name = users[person].Name;
            var age = users[person].Age;
            var gender = users[person].Gender;
            var occupation = users[person].Occupation;

            controller.append("<tr><td>" + name + "</td><td>" + age + "</td><td>" + gender + "</td><td>" + occupation + "</td></tr>");
        }
    }
});