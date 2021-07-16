using System;
using DioSeries.Enum;

namespace DioSeries.Class
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set; }

        //Metodos
        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public Serie()
        {
        }

        public override string ToString()
        {
            string result = "";
            result+= "Genre: " + this.Genre + Environment.NewLine;
            result+= "Title: " + this.Title + Environment.NewLine;
            result+= "Description: " + this.Description + Environment.NewLine;
            result+= "Year: " + this.Year + Environment.NewLine;
            result += "Deleted: " + this.Deleted;
            return result;
        }

        public string returnTitle()
        {
            return this.Title;
        }
        public int returnId()
        {
            return this.Id;
        }
        public bool GetDeleted()
        {
            return this.Deleted;
        }
        public void Excluir()
        {
            this.Deleted = true;
        }
    }
}