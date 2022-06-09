namespace movie_app.Models
{
    public class Movie
    {

        bool adult { get; set; }

        string backdrop_path { get; set; }

        object belongs_to_collection { get; set; }

        int budget { get; set; }

        string homepage { get; set; }

        int id { get; set; }

        string imdb_id { get; set; }

        string original_language { get; set; }

        string original_title { get; set; }

        string overview { get; set; }

        float popularity { get; set; }

        object poster_path { get; set; }

        string release_date { get; set; }

        int revenue { get; set; }

        int runtime { get; set; }

        string status { get; set; }

        string tagline { get; set; }

        string title { get; set; }

        bool video { get; set; }

        float vote_average { get; set; }

        int vote_count { get; set; }

        int genre_id { get; set; }

        string genre_name { get; set; }

        int production_company_id { get; set; }

        string production_company_name { get; set; }
    }

}
