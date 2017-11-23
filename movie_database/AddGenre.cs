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
    public partial class AddGenre : MetroForm
    {
        Movies _mainForm;

        public AddGenre(Movies mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void AddGenre_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string genre = txtAddGenre.Text;

            int num;
            var isNumeric = int.TryParse(txtAddGenre.Text, out var n);
            if (String.IsNullOrEmpty(genre) || String.IsNullOrWhiteSpace(genre) || isNumeric == true)
            {
                errorProvider1.SetError(txtAddGenre, "Invalid input! You can't enter numbers only, leave this input blank or enter only whitespace.");
            }
            else
            {
                errorProvider1.SetError(txtAddGenre, "");
                DataBaseConnection DB = new DataBaseConnection();
                DB.OpenConnection();
                DB.AddGenre(genre);

                DB.CloseConnection();
                _mainForm.UpdateGrid();
                _mainForm.LoadData();
                this.Close();
            }

        }
    }
}
