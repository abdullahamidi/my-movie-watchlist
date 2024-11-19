namespace MyMovieWatchlist
{
    partial class MovieDatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtMovieName = new TextBox();
            BtnAddMovie = new Button();
            SuspendLayout();
            // 
            // TxtMovieName
            // 
            TxtMovieName.Location = new Point(120, 66);
            TxtMovieName.Name = "TxtMovieName";
            TxtMovieName.Size = new Size(223, 23);
            TxtMovieName.TabIndex = 0;
            // 
            // BtnAddMovie
            // 
            BtnAddMovie.Location = new Point(192, 95);
            BtnAddMovie.Name = "BtnAddMovie";
            BtnAddMovie.Size = new Size(75, 23);
            BtnAddMovie.TabIndex = 1;
            BtnAddMovie.Text = "Add Movie";
            BtnAddMovie.UseVisualStyleBackColor = true;
            BtnAddMovie.Click += BtnAddMovie_Click;
            // 
            // MovieDatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 164);
            Controls.Add(BtnAddMovie);
            Controls.Add(TxtMovieName);
            Name = "MovieDatabaseForm";
            Text = "MovieDatabaseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMovieName;
        private Button BtnAddMovie;
    }
}