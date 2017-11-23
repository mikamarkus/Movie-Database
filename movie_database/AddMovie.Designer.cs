namespace movie_database
{
    partial class AddMovie
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
            this.components = new System.ComponentModel.Container();
            this.btnAddMovie = new MetroFramework.Controls.MetroButton();
            this.cmbAddGenre = new MetroFramework.Controls.MetroComboBox();
            this.cmbAddProducers = new MetroFramework.Controls.MetroComboBox();
            this.cmbAddActors = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.trackAddRating = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAddMovieName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddActor = new MetroFramework.Controls.MetroButton();
            this.txtAddLength = new System.Windows.Forms.NumericUpDown();
            this.txtAddBudget = new System.Windows.Forms.NumericUpDown();
            this.addMoviePanel = new MetroFramework.Controls.MetroPanel();
            this.ratingValue = new MetroFramework.Controls.MetroLabel();
            this.addActorsPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.actorsList = new System.Windows.Forms.ListBox();
            this.btnDelActor = new MetroFramework.Controls.MetroButton();
            this.btnDone = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddBudget)).BeginInit();
            this.addMoviePanel.SuspendLayout();
            this.addActorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddMovie.Location = new System.Drawing.Point(3, 309);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(180, 30);
            this.btnAddMovie.TabIndex = 29;
            this.btnAddMovie.Text = "ADD";
            this.btnAddMovie.UseSelectable = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // cmbAddGenre
            // 
            this.cmbAddGenre.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAddGenre.FormattingEnabled = true;
            this.cmbAddGenre.ItemHeight = 19;
            this.cmbAddGenre.Location = new System.Drawing.Point(3, 278);
            this.cmbAddGenre.Name = "cmbAddGenre";
            this.cmbAddGenre.PromptText = "Genre";
            this.cmbAddGenre.Size = new System.Drawing.Size(180, 25);
            this.cmbAddGenre.TabIndex = 28;
            this.cmbAddGenre.UseSelectable = true;
            // 
            // cmbAddProducers
            // 
            this.cmbAddProducers.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAddProducers.FormattingEnabled = true;
            this.cmbAddProducers.ItemHeight = 19;
            this.cmbAddProducers.Location = new System.Drawing.Point(3, 247);
            this.cmbAddProducers.Name = "cmbAddProducers";
            this.cmbAddProducers.PromptText = "Producers";
            this.cmbAddProducers.Size = new System.Drawing.Size(180, 25);
            this.cmbAddProducers.TabIndex = 27;
            this.cmbAddProducers.UseSelectable = true;
            // 
            // cmbAddActors
            // 
            this.cmbAddActors.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAddActors.FormattingEnabled = true;
            this.cmbAddActors.ItemHeight = 19;
            this.cmbAddActors.Location = new System.Drawing.Point(3, 24);
            this.cmbAddActors.Name = "cmbAddActors";
            this.cmbAddActors.PromptText = "Actors";
            this.cmbAddActors.Size = new System.Drawing.Size(180, 25);
            this.cmbAddActors.TabIndex = 26;
            this.cmbAddActors.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 199);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Budget (million)";
            // 
            // trackAddRating
            // 
            this.trackAddRating.BackColor = System.Drawing.Color.Transparent;
            this.trackAddRating.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.trackAddRating.Location = new System.Drawing.Point(3, 133);
            this.trackAddRating.Maximum = 5;
            this.trackAddRating.Minimum = 1;
            this.trackAddRating.Name = "trackAddRating";
            this.trackAddRating.Size = new System.Drawing.Size(180, 30);
            this.trackAddRating.TabIndex = 24;
            this.trackAddRating.Text = "metroTrackBar1";
            this.trackAddRating.Value = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Rating (1-5)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Length (min)";
            // 
            // txtAddMovieName
            // 
            // 
            // 
            // 
            this.txtAddMovieName.CustomButton.Image = null;
            this.txtAddMovieName.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.txtAddMovieName.CustomButton.Name = "";
            this.txtAddMovieName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAddMovieName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddMovieName.CustomButton.TabIndex = 1;
            this.txtAddMovieName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddMovieName.CustomButton.UseSelectable = true;
            this.txtAddMovieName.CustomButton.Visible = false;
            this.txtAddMovieName.Lines = new string[0];
            this.txtAddMovieName.Location = new System.Drawing.Point(3, 23);
            this.txtAddMovieName.MaxLength = 32767;
            this.txtAddMovieName.Name = "txtAddMovieName";
            this.txtAddMovieName.PasswordChar = '\0';
            this.txtAddMovieName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddMovieName.SelectedText = "";
            this.txtAddMovieName.SelectionLength = 0;
            this.txtAddMovieName.SelectionStart = 0;
            this.txtAddMovieName.ShortcutsEnabled = true;
            this.txtAddMovieName.Size = new System.Drawing.Size(180, 30);
            this.txtAddMovieName.TabIndex = 19;
            this.txtAddMovieName.UseSelectable = true;
            this.txtAddMovieName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddMovieName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Movie name";
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(4, 55);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(78, 30);
            this.btnAddActor.TabIndex = 31;
            this.btnAddActor.Text = "ADD ACTOR";
            this.btnAddActor.UseSelectable = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // txtAddLength
            // 
            this.txtAddLength.Location = new System.Drawing.Point(3, 78);
            this.txtAddLength.Name = "txtAddLength";
            this.txtAddLength.Size = new System.Drawing.Size(180, 20);
            this.txtAddLength.TabIndex = 32;
            // 
            // txtAddBudget
            // 
            this.txtAddBudget.Location = new System.Drawing.Point(3, 221);
            this.txtAddBudget.Name = "txtAddBudget";
            this.txtAddBudget.Size = new System.Drawing.Size(180, 20);
            this.txtAddBudget.TabIndex = 33;
            // 
            // addMoviePanel
            // 
            this.addMoviePanel.Controls.Add(this.ratingValue);
            this.addMoviePanel.Controls.Add(this.txtAddLength);
            this.addMoviePanel.Controls.Add(this.txtAddBudget);
            this.addMoviePanel.Controls.Add(this.metroLabel1);
            this.addMoviePanel.Controls.Add(this.txtAddMovieName);
            this.addMoviePanel.Controls.Add(this.metroLabel2);
            this.addMoviePanel.Controls.Add(this.btnAddMovie);
            this.addMoviePanel.Controls.Add(this.metroLabel3);
            this.addMoviePanel.Controls.Add(this.cmbAddGenre);
            this.addMoviePanel.Controls.Add(this.trackAddRating);
            this.addMoviePanel.Controls.Add(this.cmbAddProducers);
            this.addMoviePanel.Controls.Add(this.metroLabel4);
            this.addMoviePanel.HorizontalScrollbarBarColor = true;
            this.addMoviePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addMoviePanel.HorizontalScrollbarSize = 10;
            this.addMoviePanel.Location = new System.Drawing.Point(20, 65);
            this.addMoviePanel.Name = "addMoviePanel";
            this.addMoviePanel.Size = new System.Drawing.Size(204, 342);
            this.addMoviePanel.TabIndex = 34;
            this.addMoviePanel.VerticalScrollbarBarColor = true;
            this.addMoviePanel.VerticalScrollbarHighlightOnWheel = false;
            this.addMoviePanel.VerticalScrollbarSize = 10;
            // 
            // ratingValue
            // 
            this.ratingValue.AutoSize = true;
            this.ratingValue.Location = new System.Drawing.Point(82, 166);
            this.ratingValue.Name = "ratingValue";
            this.ratingValue.Size = new System.Drawing.Size(14, 19);
            this.ratingValue.TabIndex = 34;
            this.ratingValue.Text = "1";
            // 
            // addActorsPanel
            // 
            this.addActorsPanel.Controls.Add(this.metroLabel5);
            this.addActorsPanel.Controls.Add(this.actorsList);
            this.addActorsPanel.Controls.Add(this.btnDelActor);
            this.addActorsPanel.Controls.Add(this.btnDone);
            this.addActorsPanel.Controls.Add(this.btnAddActor);
            this.addActorsPanel.Controls.Add(this.cmbAddActors);
            this.addActorsPanel.HorizontalScrollbarBarColor = true;
            this.addActorsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addActorsPanel.HorizontalScrollbarSize = 10;
            this.addActorsPanel.Location = new System.Drawing.Point(20, 63);
            this.addActorsPanel.Name = "addActorsPanel";
            this.addActorsPanel.Size = new System.Drawing.Size(187, 341);
            this.addActorsPanel.TabIndex = 35;
            this.addActorsPanel.VerticalScrollbarBarColor = true;
            this.addActorsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addActorsPanel.VerticalScrollbarSize = 10;
            this.addActorsPanel.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(3, 6);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(169, 15);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "* You can\'t add same actor twice";
            // 
            // actorsList
            // 
            this.actorsList.FormattingEnabled = true;
            this.actorsList.Location = new System.Drawing.Point(4, 91);
            this.actorsList.Name = "actorsList";
            this.actorsList.Size = new System.Drawing.Size(179, 212);
            this.actorsList.TabIndex = 35;
            // 
            // btnDelActor
            // 
            this.btnDelActor.Location = new System.Drawing.Point(87, 55);
            this.btnDelActor.Name = "btnDelActor";
            this.btnDelActor.Size = new System.Drawing.Size(96, 30);
            this.btnDelActor.TabIndex = 34;
            this.btnDelActor.Text = "REMOVE ACTOR";
            this.btnDelActor.UseSelectable = true;
            this.btnDelActor.Click += new System.EventHandler(this.btnDelActor_Click_1);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(4, 309);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(180, 29);
            this.btnDone.TabIndex = 32;
            this.btnDone.Text = "DONE";
            this.btnDone.UseSelectable = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 418);
            this.Controls.Add(this.addActorsPanel);
            this.Controls.Add(this.addMoviePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddMovie";
            this.Text = "Add movie";
            ((System.ComponentModel.ISupportInitialize)(this.txtAddLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddBudget)).EndInit();
            this.addMoviePanel.ResumeLayout(false);
            this.addMoviePanel.PerformLayout();
            this.addActorsPanel.ResumeLayout(false);
            this.addActorsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAddMovie;
        private MetroFramework.Controls.MetroComboBox cmbAddGenre;
        private MetroFramework.Controls.MetroComboBox cmbAddProducers;
        private MetroFramework.Controls.MetroComboBox cmbAddActors;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar trackAddRating;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAddMovieName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddActor;
        private System.Windows.Forms.NumericUpDown txtAddLength;
        private System.Windows.Forms.NumericUpDown txtAddBudget;
        private MetroFramework.Controls.MetroPanel addMoviePanel;
        private MetroFramework.Controls.MetroPanel addActorsPanel;
        private MetroFramework.Controls.MetroButton btnDone;
        private MetroFramework.Controls.MetroButton btnDelActor;
        private System.Windows.Forms.ListBox actorsList;
        private MetroFramework.Controls.MetroLabel ratingValue;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}