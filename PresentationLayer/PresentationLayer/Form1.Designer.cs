
namespace PresentationLayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.labelObrisiContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            this.SuspendLayout();
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.BackColor = System.Drawing.Color.Transparent;
            this.Ime.Location = new System.Drawing.Point(14, 17);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(33, 15);
            this.Ime.TabIndex = 0;
            this.Ime.Text = "Ime:";
            this.Ime.Click += new System.EventHandler(this.Ime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(259, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj telefona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(259, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(259, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(11, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Opis:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 21);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(352, 14);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(132, 21);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(105, 44);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(132, 21);
            this.textBoxPhoneNumber.TabIndex = 10;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(352, 44);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(132, 21);
            this.textBoxFax.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(105, 74);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(132, 21);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(352, 74);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(132, 21);
            this.textBoxAdress.TabIndex = 13;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(105, 104);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(379, 77);
            this.textBoxDescription.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(105, 187);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 35);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Sacuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(739, 187);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 35);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Obrisi Kontakt";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.pnghut_reverse_telephone_directory_address_book_number_clip_art_mobile_phone_vector_and_this;
            this.pictureBox1.Location = new System.Drawing.Point(577, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Location = new System.Drawing.Point(17, 244);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.Size = new System.Drawing.Size(842, 263);
            this.dataGridViewContact.TabIndex = 21;
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(584, 188);
            this.textBoxDelete.Multiline = true;
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(145, 34);
            this.textBoxDelete.TabIndex = 22;
            // 
            // labelObrisiContact
            // 
            this.labelObrisiContact.AutoSize = true;
            this.labelObrisiContact.BackColor = System.Drawing.Color.Transparent;
            this.labelObrisiContact.Location = new System.Drawing.Point(331, 197);
            this.labelObrisiContact.Name = "labelObrisiContact";
            this.labelObrisiContact.Size = new System.Drawing.Size(247, 15);
            this.labelObrisiContact.TabIndex = 23;
            this.labelObrisiContact.Text = "Unesite ID kontakta koji zelite da obrisete:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "© munje 2021";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources._6666;
            this.ClientSize = new System.Drawing.Size(880, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObrisiContact);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.dataGridViewContact);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxDescription;
        public System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label labelObrisiContact;
        private System.Windows.Forms.Label label1;
    }
}

