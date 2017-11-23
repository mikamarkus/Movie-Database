using MetroFramework.Forms;
using System;
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
    public partial class EditActors : MetroForm
    {
        private BindingList<Actor> actors = new BindingList<Actor>();
        private int tmp_movie_id;

        public EditActors(int movie_id)
        {
            InitializeComponent();
            this.tmp_movie_id = movie_id;
           
            DataTable dt = new DataTable();
            DataBaseConnection DB = new DataBaseConnection();

            DataSet actors = DB.GetActorsList();

            foreach (DataRow row in actors.Tables[0].Rows)
            {
                cmbActors.ValueMember = "id";
                cmbActors.DisplayMember = "fullname";
                cmbActors.DataSource = actors.Tables["actorsList"];
                cmbActors.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbActors.Enabled = true;
            }

            DataSet movies_actors = DB.GetMoviesActors(this.tmp_movie_id);

            foreach (DataRow row in movies_actors.Tables[0].Rows)
            {
                this.actors.Add(new Actor(row["fullname"].ToString(), Convert.ToInt32(row["id"])));
            }

            ShowData();
        }

        private void btnDoneEditActors_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAddActor_Click(object sender, EventArgs e)
        {
            string actor = cmbActors.Text;
            int actorId = Convert.ToInt32(cmbActors.SelectedValue.ToString());

            if (listBoxActors.FindString(actor) != -1)
            {
                MessageBox.Show("You can't add same actor twice!");
            }
            else
            {
                actors.Add(new Actor(actor, actorId));
                ShowData();

                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                int successStatus = DB.EditActorForMovie(actorId, this.tmp_movie_id);
                DB.CloseConnection();

                if (successStatus == 1)
                {
                    MessageBox.Show("Actor added successfully!");
                }

            }
        }

        private void ShowData()
        {
            listBoxActors.DataSource = actors;
            listBoxActors.DisplayMember = "ActorName";
            listBoxActors.ValueMember = "ActorId";
        }

        private void btnEditRemoveActor_Click(object sender, EventArgs e)
        {
            if (listBoxActors.SelectedIndex != -1)
            {
                int actorId = Convert.ToInt32(listBoxActors.SelectedValue);
                int remove_index = listBoxActors.SelectedIndex;

                actors.RemoveAt(remove_index);
                listBoxActors.DataSource = actors;

                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                int successStatus = DB.EditRemoveActorFromMovie(actorId, this.tmp_movie_id);
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
    }
}
