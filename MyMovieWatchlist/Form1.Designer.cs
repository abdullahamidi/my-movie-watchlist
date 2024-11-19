namespace MyMovieWatchlist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LstMovies = new ListBox();
            BtnAddMovie = new Button();
            BtnRemoveMovie = new Button();
            BtnMarkWatched = new Button();
            SuspendLayout();
            // 
            // LstMovies
            // 
            LstMovies.FormattingEnabled = true;
            LstMovies.ItemHeight = 15;
            LstMovies.Items.AddRange(new object[] { "Game Of Thrones" });
            LstMovies.Location = new Point(12, 12);
            LstMovies.Name = "LstMovies";
            LstMovies.Size = new Size(640, 424);
            LstMovies.TabIndex = 0;
            // 
            // BtnAddMovie
            // 
            BtnAddMovie.Location = new Point(658, 12);
            BtnAddMovie.Name = "BtnAddMovie";
            BtnAddMovie.Size = new Size(130, 39);
            BtnAddMovie.TabIndex = 1;
            BtnAddMovie.Text = "Add Movie";
            BtnAddMovie.UseVisualStyleBackColor = true;
            BtnAddMovie.Click += BtnAddMovie_Click;
            // 
            // BtnRemoveMovie
            // 
            BtnRemoveMovie.Location = new Point(658, 57);
            BtnRemoveMovie.Name = "BtnRemoveMovie";
            BtnRemoveMovie.Size = new Size(130, 39);
            BtnRemoveMovie.TabIndex = 2;
            BtnRemoveMovie.Text = "Remove Movie";
            BtnRemoveMovie.UseVisualStyleBackColor = true;
            // 
            // BtnMarkWatched
            // 
            BtnMarkWatched.Location = new Point(658, 102);
            BtnMarkWatched.Name = "BtnMarkWatched";
            BtnMarkWatched.Size = new Size(130, 39);
            BtnMarkWatched.TabIndex = 3;
            BtnMarkWatched.Text = "Mark as Watched";
            BtnMarkWatched.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMarkWatched);
            Controls.Add(BtnRemoveMovie);
            Controls.Add(BtnAddMovie);
            Controls.Add(LstMovies);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LstMovies;
        private Button BtnAddMovie;
        private Button BtnRemoveMovie;
        private Button BtnMarkWatched;
    }
}
