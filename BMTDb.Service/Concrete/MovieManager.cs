﻿using BMTDb.Data.Abstract;
using BMTDb.Entity;
using BMTDb.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMTDb.Service.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieManager(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Create(Movie entity)
        {
            _movieRepository.Create(entity);
        }

        public void Delete(Movie entity)
        {
            _movieRepository.Delete(entity);
        }

        public void Update(Movie entity)
        {
            _movieRepository.Update(entity);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public Movie GetMovieDetails(string Title)
        {
            return _movieRepository.GetMovieDetails(Title);
        }

        public List<Movie> GetMoviebyFilter(string name, string Studio_Name)
        {
            return _movieRepository.GetMoviebyFilter(name, Studio_Name);
        }
    }
}
