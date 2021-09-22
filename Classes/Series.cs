using System;

namespace DIO.Series
{
    public class Series : EntityBase
    {
        private Genre Genre { get; set; }

        private string Title { get; set; }

        private string Description { get; set; }

        private int Year { get; set; }

        private bool Deleted { get; set; }

        // Methods

        public Series(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString()
        {
            string regress = "";
            regress += "Genre: " + this.Genre + Environment.NewLine; 
            regress += "Title: " + this.Title + Environment.NewLine;
            regress += "Description: " + this.Description + Environment.NewLine;
            regress += "Year: " + this.Year;
            return regress;
        }

        public string TitleReturn()
        {
            return this.Title;
        }
        internal int IdReturn()
        {
            return this.Id;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }
}