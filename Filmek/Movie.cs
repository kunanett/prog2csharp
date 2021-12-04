namespace Filmek {
    public class Movie {
        private string title;
        private int year;
        private double rating;

        public Movie(string title, int year, double rating) {
            this.title = title;
            this.year = year;
            this.rating = rating;
        }
        
        public override string ToString() {
            return "Movie: " + this.title;
        }

        public string getTitle() {
            return this.title;
        }

        //C# getter setter: https://stackoverflow.com/questions/17881091/getter-and-setter-declaration-in-net
    }
}