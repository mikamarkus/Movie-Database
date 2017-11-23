namespace movie_database
{
    partial class AddGenre
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAddGenre = new MetroFramework.Controls.MetroTextBox();
            this.btnAddGenre = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Genre";
            // 
            // txtAddGenre
            // 
            // 
            // 
            // 
            this.txtAddGenre.CustomButton.Image = null;
            this.txtAddGenre.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.txtAddGenre.CustomButton.Name = "";
            this.txtAddGenre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAddGenre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddGenre.CustomButton.TabIndex = 1;
            this.txtAddGenre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddGenre.CustomButton.UseSelectable = true;
            this.txtAddGenre.CustomButton.Visible = false;
            this.txtAddGenre.Lines = new string[0];
            this.txtAddGenre.Location = new System.Drawing.Point(23, 82);
            this.txtAddGenre.MaxLength = 32767;
            this.txtAddGenre.Name = "txtAddGenre";
            this.txtAddGenre.PasswordChar = '\0';
            this.txtAddGenre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddGenre.SelectedText = "";
            this.txtAddGenre.SelectionLength = 0;
            this.txtAddGenre.SelectionStart = 0;
            this.txtAddGenre.ShortcutsEnabled = true;
            this.txtAddGenre.Size = new System.Drawing.Size(180, 30);
            this.txtAddGenre.TabIndex = 1;
            this.txtAddGenre.UseSelectable = true;
            this.txtAddGenre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddGenre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(23, 119);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(180, 30);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "SAVE";
            this.btnAddGenre.UseSelectable = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(227, 165);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.txtAddGenre);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddGenre";
            this.Text = "Add Genre";
            this.Load += new System.EventHandler(this.AddGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAddGenre;
        private MetroFramework.Controls.MetroButton btnAddGenre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}