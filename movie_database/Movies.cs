using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace movie_database
{
    public partial class Movies : MetroForm
    {
        private DataTable dt_temp = new DataTable();
        private int tmp_movie_id;
        private int tmp_genre_id;
        private int tmp_producer_id;
        private int tmp_actor_id;

        public Movies()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridMovies.SelectionChanged += new EventHandler(gridMovies_SelectionChanged);
            gridGenres.SelectionChanged += new EventHandler(gridGenres_SelectionChanged);
            gridActors.SelectionChanged += new EventHandler(gridActors_SelectionChanged);
            gridProducers.SelectionChanged += new EventHandler(gridProducers_SelectionChanged);
            txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
            txtSearchActor.KeyPress += new KeyPressEventHandler(txtSearchActor_KeyPress);
            txtSearchProducer.KeyPress += new KeyPressEventHandler(txtSearchProducer_KeyPress);
            txtSearchGenre.KeyPress += new KeyPressEventHandler(txtSearchGenre_KeyPress);
            trackRating.ValueChanged += new System.EventHandler(trackRating_ValueChanged);

            DefineGrid();
            UpdateGrid();
            LoadData();
        }

        public void DefineGrid()
        {
            gridMovies.ColumnCount = 7;
            gridMovies.AutoGenerateColumns = false;
            gridMovies.Columns[0].HeaderText = "ID";
            gridMovies.Columns[0].DataPropertyName = "id";
            gridMovies.Columns[1].HeaderText = "Name";
            gridMovies.Columns[1].DataPropertyName = "name";
            gridMovies.Columns[2].HeaderText = "Length";
            gridMovies.Columns[2].DataPropertyName = "length";
            gridMovies.Columns[3].HeaderText = "Rating";
            gridMovies.Columns[3].DataPropertyName = "rating";
            gridMovies.Columns[4].HeaderText = "Budget";
            gridMovies.Columns[4].DataPropertyName = "budget";
            gridMovies.Columns[5].HeaderText = "Producer";
            gridMovies.Columns[5].DataPropertyName = "fullname";
            gridMovies.Columns[6].HeaderText = "Genre";
            gridMovies.Columns[6].DataPropertyName = "genre";
            
        }

        public void LoadData()
        {
            DataBaseConnection DB = new DataBaseConnection();

            DataSet producers = DB.GetProducersList();

            foreach (DataRow row in producers.Tables[0].Rows)
            {
                cmbProducers.ValueMember = "id";
                cmbProducers.DisplayMember = "fullname";
                cmbProducers.DataSource = producers.Tables["producersList"];
                cmbProducers.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbProducers.Enabled = true;

            }

            DataSet genres = DB.GetGenresList();

            foreach (DataRow row in genres.Tables[0].Rows)
            {

                cmbGenre.ValueMember = "id";
                cmbGenre.DisplayMember = "genre";
                cmbGenre.DataSource = genres.Tables["genresList"];
                cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbGenre.Enabled = true;

            }

            DB.CloseConnection();
        }

        public void UpdateGrid()
        {

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            DataBaseConnection DB = new DataBaseConnection();
            DB.OpenConnection();

            dt = DB.ReadValue();
            gridMovies.DataSource = dt;
            dt_temp = dt;

            ds = DB.GetGenresList();
            dt = ds.Tables["genresList"];
            gridGenres.DataSource = dt;

            ds = DB.GetProducersList();
            dt = ds.Tables["producersList"];
            gridProducers.DataSource = dt;

            ds = DB.GetActorsList();
            dt = ds.Tables["actorsList"];
            gridActors.DataSource = dt;

            gridMovies.Sort(gridMovies.Columns[1], ListSortDirection.Descending);

            DB.CloseConnection();
        }

        private void trackRating_ValueChanged(object sender, System.EventArgs e)
        {
            ratingValue.Text = trackRating.Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            string moviename = txtMovieName.Text;
            movie.MovieName = txtMovieName.Text;
            movie.Rating = Convert.ToInt32(trackRating.Value);
            movie.Length = Convert.ToInt32(txtLength.Text);
            movie.Budget = Convert.ToInt32(txtBudget.Text);
            movie.Producer = Convert.ToInt32(cmbProducers.SelectedValue);
            movie.Genre = Convert.ToInt32(cmbGenre.SelectedValue);
            movie.Movieid = this.tmp_movie_id;

            if (String.IsNullOrEmpty(moviename) || String.IsNullOrWhiteSpace(moviename))
            {
                errorProvider1.SetError(txtMovieName, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else
            {
                errorProvider1.SetError(txtMovieName, "");
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                int succesStatus = DB.EditMovie(movie);
                DB.CloseConnection();

                if (succesStatus == 1)
                {
                    MessageBox.Show("Movie updated successfully!");
                    UpdateGrid();
                    LoadData();
                }
            }

        }

        private void gridMovies_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in gridMovies.SelectedRows)
            {
                this.tmp_movie_id = Convert.ToInt32(row.Cells[0].Value);
                txtMovieName.Text = row.Cells[1].Value.ToString();
                txtLength.Text = row.Cells[2].Value.ToString();
                trackRating.Value = Convert.ToInt16(row.Cells[3].Value);
                ratingValue.Text = row.Cells[3].Value.ToString();
                txtBudget.Text = row.Cells[4].Value.ToString();
                string tmp_producer = row.Cells[5].Value.ToString();
                string tmp_genre = row.Cells[6].Value.ToString();
                cmbProducers.SelectedIndex = cmbProducers.FindStringExact(tmp_producer);
                cmbGenre.SelectedIndex = cmbGenre.FindStringExact(tmp_genre);
            }
        }

        private void gridGenres_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gridGenres.SelectedRows)
            {
                this.tmp_genre_id = Convert.ToInt32(row.Cells[0].Value);
                txtGenre.Text = row.Cells[1].Value.ToString();
            }
        }

        private void gridActors_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gridActors.SelectedRows)
            {
                this.tmp_actor_id = Convert.ToInt32(row.Cells[0].Value);
                txtActorFname.Text = row.Cells[1].Value.ToString();
                txtActorLname.Text = row.Cells[2].Value.ToString();
                txtActorAddress.Text = row.Cells[4].Value.ToString();
                txtActorPcode.Text = row.Cells[5].Value.ToString();
                txtActorCity.Text = row.Cells[6].Value.ToString();
                txtActorNation.Text = row.Cells[7].Value.ToString();
            }
        }

        private void gridProducers_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gridProducers.SelectedRows)
            {
                this.tmp_producer_id = Convert.ToInt32(row.Cells[0].Value);
                txtProducerFname.Text = row.Cells[1].Value.ToString();
                txtProducerLname.Text = row.Cells[2].Value.ToString();
                txtProducerAddress.Text = row.Cells[4].Value.ToString();
                txtProducerPcode.Text = row.Cells[5].Value.ToString();
                txtProducerCity.Text = row.Cells[6].Value.ToString();
                txtProducerNation.Text = row.Cells[7].Value.ToString();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                (gridMovies.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", txtSearch.Text);
            }
        }

        private void txtSearchActor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                (gridActors.DataSource as DataTable).DefaultView.RowFilter = string.Format("fullname LIKE '{0}%'", txtSearchActor.Text);
            }
        }

        private void txtSearchProducer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                (gridProducers.DataSource as DataTable).DefaultView.RowFilter = string.Format("fullname LIKE '{0}%'", txtSearchProducer.Text);
            }
        }

        private void txtSearchGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                (gridGenres.DataSource as DataTable).DefaultView.RowFilter = string.Format("genre LIKE '{0}%'", txtSearchGenre.Text);
            }
        }

        private void btnOpenAddDialog_Click(object sender, EventArgs e)
        {
            AddMovie addForm = new AddMovie(this);
            addForm.Show();
        }

        private void btnShowActors_Click(object sender, EventArgs e)
        {
            EditActors editActors = new EditActors(tmp_movie_id);
            editActors.Show();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            AddGenre addGenre = new AddGenre(this);
            addGenre.Show();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to delete genre?";
            const string caption = "Deleting genre";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.DeleteGenre(this.tmp_genre_id);
                DB.CloseConnection();
                UpdateGrid();
                LoadData();
            }
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            string genre = txtGenre.Text;
            DataBaseConnection DB = new DataBaseConnection();
            DB.OpenConnection();
            DB.EditGenre(this.tmp_genre_id, genre);
            DB.CloseConnection();
            UpdateGrid();
            LoadData();
        }

        private void btnEditProducer_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.Firstname = txtProducerFname.Text;
            producer.Lastname = txtProducerLname.Text;
            producer.Address = txtProducerAddress.Text;
            producer.Postalcode = txtProducerPcode.Text;
            producer.City = txtProducerCity.Text;
            producer.Nationality = txtProducerNation.Text;
            producer.ProducerId = this.tmp_producer_id;

            if (String.IsNullOrEmpty(producer.Firstname) || String.IsNullOrWhiteSpace(producer.Firstname))
            {
                errorProvider1.SetError(txtProducerFname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else if(String.IsNullOrEmpty(producer.Lastname) || String.IsNullOrWhiteSpace(producer.Lastname))
            {
                errorProvider1.SetError(txtProducerLname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else
            {
                errorProvider1.SetError(txtProducerFname, "");
                errorProvider1.SetError(txtProducerLname, "");
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.EditProducer(producer);
                DB.CloseConnection();
                UpdateGrid();
                LoadData();
            }

        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            AddProducer addGenre = new AddProducer(this);
            addGenre.Show();
        }

        private void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to delete producer?";
            const string caption = "Deleting producer";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.DeleteProducer(this.tmp_producer_id);
                DB.CloseConnection();
                UpdateGrid();
                LoadData();
            }
        }

        private void btnEditActor_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor();
            actor.Firstname = txtActorFname.Text;
            actor.Lastname = txtActorLname.Text;
            actor.Address = txtActorAddress.Text;
            actor.Postalcode = txtActorPcode.Text;
            actor.City = txtActorCity.Text;
            actor.Nationality = txtActorNation.Text;
            actor.ActorId = this.tmp_actor_id;

            if (String.IsNullOrEmpty(actor.Firstname) || String.IsNullOrWhiteSpace(actor.Firstname))
            {
                errorProvider1.SetError(txtActorFname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else if (String.IsNullOrEmpty(actor.Lastname) || String.IsNullOrWhiteSpace(actor.Lastname))
            {
                errorProvider1.SetError(txtActorLname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else
            {
                errorProvider1.SetError(txtActorFname, "");
                errorProvider1.SetError(txtActorLname, "");
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.EditActor(actor);
                DB.CloseConnection();
                UpdateGrid();
                LoadData();
            }

        }

        private void btnDeleteActor_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to delete actor?";
            const string caption = "Deleting actor";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.DeleteActor(this.tmp_actor_id);
                DB.CloseConnection();
                UpdateGrid();
                LoadData();
            }
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            AddActor addActor = new AddActor(this);
            addActor.Show();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (this.tmp_movie_id == null)
            {
                MessageBox.Show("You didn't choose any movie!");
            }

            const string message = "Are you sure that you would like to delete movie?";
            const string caption = "Deleting movie";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.RemoveMovie(this.tmp_movie_id);
                DB.CloseConnection();
                UpdateGrid();
                LoadData();
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
