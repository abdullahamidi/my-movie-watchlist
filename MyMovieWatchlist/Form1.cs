using System.Diagnostics;

namespace MyMovieWatchlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            //Open movie form
            var movieForm = new MovieDatabaseForm();
            movieForm.OnMovieAdded += MovieForm_OnMovieAdded;
            var dialogResult = movieForm.ShowDialog();
            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                movieForm.OnMovieAdded -= MovieForm_OnMovieAdded;
            }
        }

        private void MovieForm_OnMovieAdded(string movieName)
        {
            Debug.Print("Entered : "+movieName);
            LstMovies.Items.Add(movieName);
        }
    }
}
