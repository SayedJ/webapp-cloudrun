﻿

using System.Security.Claims;
using webapp_cloudrun.Models;
using webapp_cloudrun.Models.MtoGetJsons;

namespace webapp_cloudrun.Repositories
{
    public interface IMoviesRepo
    {
        //Movie GetMovieByTitle(string title);
        Task<Movie> GetMovieById(long id);
        Task<IEnumerable<MovieDetailsVM>> GetAllMoviesWithDetails();
        Task<Rating> GetRatingById(int? id);
        Task<Director> GetDirectorById(int? id);
        Task<Person?> GetPersonById(int? id);
        Task<IEnumerable<Star>> GetStarById(int? id);
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<string> SaveImageUrl(string url, Movie movie);
        Task<ImageUrl> GetImageUrl(Movie id);
        Task<User> Login(UserLogin userLogin);
        Task AddFavMovie(int userId, int id);
        public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }
        Task SaveUser(User user);
        Task<ClaimsPrincipal> GetAuthAsync();


    }
}
