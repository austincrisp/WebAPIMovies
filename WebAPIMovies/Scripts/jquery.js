$().ready(function () {

    $("#getMovies").click(function() {

        $.get("http://localhost:54694/api/Movie/", function (resp) {
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
        $.get("http://localhost:54694/api/Review/", function (resp) {
            console.log(resp);
            renderReviews(resp);
        });
    });

    function renderReviews(reviews) {
        var control = $("#reviews");
        control.empty();
        for(review in reviews)
        {
            var rating = reviews[review].Rating;
            var movie = reviews[review].Movie.Title;

            control.append("<tr><td>" + rating + "</td><td>" + movie + "</td></tr>");
        }
    }
});