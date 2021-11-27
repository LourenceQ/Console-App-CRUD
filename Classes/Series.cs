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
            regress += "Year: " + this.Year + Environment.NewLine;
            regress += "Deleted: " + this.Deleted;
            return regress;
        }
        public string TitleReturn()
        {
            return this.Title;
        }
        public int IdReturn()
        {
            return this.Id;
        }
        public bool ReturnDeleted()
        {
            return this.Deleted;
        }
        public void ToDelete()
        {
            this.Deleted = true;
        }
    }
}