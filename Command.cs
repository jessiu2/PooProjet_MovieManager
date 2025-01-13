using System;
using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager
{
    public abstract class Command
    {
        protected string Lang { get; set; } = "en"; 
        protected List<Movie> Movies { get; set; } = new List<Movie>();

        public Command() {}

        public abstract void Execute();   
        public abstract void AddMovie(); 
        public abstract void ListMovies();     
        public abstract void ChangeLanguage(string language);    
        public abstract void LoadMovies(string fileName);     
        public abstract void SaveMovies(string fileName);     
        public abstract void SearchMovies(string criteria); 
    }
}
