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
    public partial class AddProducer : MetroForm
    {
        Movies _mainForm;

        public AddProducer(Movies mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void AddProducer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProducer_Click_1(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.Firstname = txtAddProducerFname.Text;
            producer.Lastname = txtAddProducerLname.Text;
            producer.Address = txtAddProducerAddress.Text;
            producer.Postalcode = txtAddProducerPcode.Text;
            producer.City = txtAddProducerCity.Text;
            producer.Nationality = txtAddProducerNation.Text;

            if (String.IsNullOrEmpty(producer.Firstname) || String.IsNullOrWhiteSpace(producer.Firstname))
            {
                errorProvider1.SetError(txtAddProducerFname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else if (String.IsNullOrEmpty(producer.Lastname) || String.IsNullOrWhiteSpace(producer.Lastname))
            {
                errorProvider1.SetError(txtAddProducerLname, "Invalid input! You can't leave this input blank or enter only whitespace.");
            }
            else
            {
                errorProvider1.SetError(txtAddProducerFname, "");
                errorProvider1.SetError(txtAddProducerLname, "");
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.AddProducer(producer);
                DB.CloseConnection();

                _mainForm.UpdateGrid();
                _mainForm.LoadData();

                this.Close();
            }

        }
    }
}
