using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_database
{
    public partial class AddMovie : MetroForm
    {
        private BindingList<Actor> actors = new BindingList<Actor>();
        Movies _mainForm;

        public AddMovie(Movies mainForm)
        {
            InitializeComponent();
            ShowData();
            _mainForm = mainForm;

            trackAddRating.ValueChanged += new System.EventHandler(trackAddRating_ValueChanged);

            DataBaseConnection DB = new DataBaseConnection();

            DataSet actors = DB.GetActorsList();

            foreach (DataRow row in actors.Tables[0].Rows)
            {
                cmbAddActors.ValueMember = "id";
                cmbAddActors.DisplayMember = "fullname";
                cmbAddActors.DataSource = actors.Tables["actorsList"];
                cmbAddActors.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbAddActors.Enabled = true;
            }

            DataSet producers = DB.GetProducersList();

            foreach (DataRow row in producers.Tables[0].Rows)
            {
                cmbAddProducers.ValueMember = "id";
                cmbAddProducers.DisplayMember = "fullname";
                cmbAddProducers.DataSource = producers.Tables["producersList"];
                cmbAddProducers.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbAddProducers.Enabled = true;
                
            }

            DataSet genres = DB.GetGenresList();

            foreach (DataRow row in genres.Tables[0].Rows)
            {
                
                cmbAddGenre.ValueMember = "id";
                cmbAddGenre.DisplayMember = "genre";
                cmbAddGenre.DataSource = genres.Tables["genresList"];
                cmbAddGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbAddGenre.Enabled = true;
                
            }

        }

        private void trackAddRating_ValueChanged(object sender, System.EventArgs e)
        {
            ratingValue.Text = trackAddRating.Value.ToString();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            string moviename = txtAddMovieName.Text;

            if (String.IsNullOrEmpty(moviename) || String.IsNullOrWhiteSpace(moviename))
            {
                errorProvider1.SetError(txtAddMovieName, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else
            {
                errorProvider1.SetError(txtAddMovieName, "");
                movie.MovieName = txtAddMovieName.Text;
                movie.Length = Convert.ToInt32(Math.Round(txtAddLength.Value, 0));
                movie.Rating = Convert.ToInt32(trackAddRating.Value);
                movie.Budget = Convert.ToInt32(Math.Round(txtAddBudget.Value, 0));
                movie.Genre = Convert.ToInt32(cmbAddGenre.SelectedValue);
                movie.Producer = Convert.ToInt32(cmbAddProducers.SelectedValue);

                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                int succesStatus = DB.AddMovie(movie);
                DB.CloseConnection();

                if (succesStatus == 1)
                {
                    addMoviePanel.Hide();
                    addActorsPanel.Show();
                }
            }



        }
       
        private void btnDone_Click(object sender, EventArgs e)
        {
            _mainForm.UpdateGrid();
            this.Close();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            string actor = cmbAddActors.Text;
            int actorId = Convert.ToInt32(cmbAddActors.SelectedValue.ToString());

            if (actorsList.FindString(actor) != -1)
            {
                MessageBox.Show("You can't add same actor twice!");
            }
            else
            {
                actors.Add(new Actor(actor, actorId));
                ShowData();

                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                int successStatus = DB.AddActorForMovie(actorId);
                DB.CloseConnection();

                if (successStatus == 1)
                {
                    MessageBox.Show("Actor added successfully!");
                }
                
            }
        }

        private void btnDelActor_Click_1(object sender, EventArgs e)
        {
            if (actorsList.SelectedIndex != -1)
            {
                int actorId = Convert.ToInt32(actorsList.SelectedValue);
                int remove_index = actorsList.SelectedIndex;

                actors.RemoveAt(remove_index);
                actorsList.DataSource = actors;

                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                int successStatus = DB.RemoveActorFromMovie(actorId);
                DB.CloseConnection();

                if (successStatus == 1)
                {
                    MessageBox.Show("Actor removed successfully!");
                }
            }
            else
            {
                MessageBox.Show("You didn't choose any actors!");
            }
        }

        private void ShowData()
        {
            actorsList.DataSource = actors;
            actorsList.DisplayMember = "ActorName";
            actorsList.ValueMember = "ActorId";
        }
    }


}

