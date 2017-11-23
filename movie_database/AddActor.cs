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
    public partial class AddActor : MetroForm
    {
        Movies _mainForm;

        public AddActor(Movies mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void AddActor_Load(object sender, EventArgs e)
        {

        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor();
            actor.Firstname = txtAddActorFname.Text;
            actor.Lastname = txtAddActorLname.Text;
            actor.Address = txtAddActorAddress.Text;
            actor.Postalcode = txtAddActorPcode.Text;
            actor.City = txtAddActorCity.Text;
            actor.Nationality = txtAddActorNation.Text;

            if (String.IsNullOrEmpty(actor.Firstname) || String.IsNullOrWhiteSpace(actor.Firstname))
            {
                errorProvider1.SetError(txtAddActorFname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else if (String.IsNullOrEmpty(actor.Lastname) || String.IsNullOrWhiteSpace(actor.Lastname))
            {
                errorProvider1.SetError(txtAddActorLname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else
            {
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.AddActor(actor);
                DB.CloseConnection();

                _mainForm.UpdateGrid();

                this.Close();
            }

        }
    }
}
