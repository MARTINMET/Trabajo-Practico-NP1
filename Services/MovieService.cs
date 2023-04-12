using TP1.Models;

namespace TP1.Services;

public static class MovieService{
    static List<Movie> Movies { get; set;}

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "Star Wars New Hope", Code="STW", Category="Sci fi", Minutes=110, Review="⭐⭐⭐⭐"},
            new Movie { Name = "Avatar", Code="AVT", Category="Sci fi", Minutes=500, Review="⭐⭐"},
            new Movie { Name = "Hannibal", Code="HNL", Category="Terror", Minutes=110, Review="⭐⭐"}
        };
    }

      public static List<Movie> GetAll() => Movies;

       public static void Add(Movie obj){
       if(obj == null){
          return;
        }

      Movies.Add(obj);
    }

//     public static void Delete(string code){
//         var movieToDelete = Get(code);

//         if (movieToDelete != null){
//             Movies.Remove(movieToDelete);
//         }
//     }
//     public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
// }
}