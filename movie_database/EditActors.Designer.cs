namespace movie_database
{
    partial class EditActors
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
            this.cmbActors = new MetroFramework.Controls.MetroComboBox();
            this.listBoxActors = new System.Windows.Forms.ListBox();
            this.btnDoneEditActors = new MetroFramework.Controls.MetroButton();
            this.btnEditAddActor = new MetroFramework.Controls.MetroButton();
            this.btnEditRemoveActor = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbActors
            // 
            this.cmbActors.FormattingEnabled = true;
            this.cmbActors.ItemHeight = 23;
            this.cmbActors.Location = new System.Drawing.Point(23, 63);
            this.cmbActors.Name = "cmbActors";
            this.cmbActors.Size = new System.Drawing.Size(186, 29);
            this.cmbActors.TabIndex = 0;
            this.cmbActors.UseSelectable = true;
            // 
            // listBoxActors
            // 
            this.listBoxActors.FormattingEnabled = true;
            this.listBoxActors.Location = new System.Drawing.Point(23, 137);
            this.listBoxActors.Name = "listBoxActors";
            this.listBoxActors.Size = new System.Drawing.Size(186, 212);
            this.listBoxActors.TabIndex = 1;
            // 
            // btnDoneEditActors
            // 
            this.btnDoneEditActors.Location = new System.Drawing.Point(23, 355);
            this.btnDoneEditActors.Name = "btnDoneEditActors";
            this.btnDoneEditActors.Size = new System.Drawing.Size(186, 30);
            this.btnDoneEditActors.TabIndex = 2;
            this.btnDoneEditActors.Text = "DONE";
            this.btnDoneEditActors.UseSelectable = true;
            this.btnDoneEditActors.Click += new System.EventHandler(this.btnDoneEditActors_Click);
            // 
            // btnEditAddActor
            // 
            this.btnEditAddActor.Location = new System.Drawing.Point(23, 98);
            this.btnEditAddActor.Name = "btnEditAddActor";
            this.btnEditAddActor.Size = new System.Drawing.Size(90, 30);
            this.btnEditAddActor.TabIndex = 3;
            this.btnEditAddActor.Text = "ADD";
            this.btnEditAddActor.UseSelectable = true;
            this.btnEditAddActor.Click += new System.EventHandler(this.btnEditAddActor_Click);
            // 
            // btnEditRemoveActor
            // 
            this.btnEditRemoveActor.Location = new System.Drawing.Point(119, 98);
            this.btnEditRemoveActor.Name = "btnEditRemoveActor";
            this.btnEditRemoveActor.Size = new System.Drawing.Size(90, 30);
            this.btnEditRemoveActor.TabIndex = 4;
            this.btnEditRemoveActor.Text = "REMOVE";
            this.btnEditRemoveActor.UseSelectable = true;
            this.btnEditRemoveActor.Click += new System.EventHandler(this.btnEditRemoveActor_Click);
            // 
            // EditActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 418);
            this.Controls.Add(this.btnEditRemoveActor);
            this.Controls.Add(this.btnEditAddActor);
            this.Controls.Add(this.btnDoneEditActors);
            this.Controls.Add(this.listBoxActors);
            this.Controls.Add(this.cmbActors);
            this.Name = "EditActors";
            this.Text = "Edit actors";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbActors;
        private System.Windows.Forms.ListBox listBoxActors;
        private MetroFramework.Controls.MetroButton btnDoneEditActors;
        private MetroFramework.Controls.MetroButton btnEditAddActor;
        private MetroFramework.Controls.MetroButton btnEditRemoveActor;
    }
}