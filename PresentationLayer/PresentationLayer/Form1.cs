using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly ContactBusiness contactBusiness;
        public Form1()
        {
            InitializeComponent();
             this.contactBusiness = new ContactBusiness();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void Ime_Click(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            /*List<Contact> contacts = this.contactBusiness.GetAllContacts();
            listBoxContacts.Items.Clear();

            foreach(Contact s in contacts)
            {
                listBoxContacts.Items.Add(s.Id + "     " +  s.Name + "     " + s.Surname + "     " + s.PhoneNumber + "     " + s.Fax + "  " + s.Email + "     " + s.Address + "     " + s.Description);
            }*/


            using(SqlConnection sqlCon = new SqlConnection(Constant.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM Contacts", sqlCon);
                DataTable dtb = new DataTable();
                sqa.Fill(dtb);
                dataGridViewContact.DataSource = dtb;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Contact s = new Contact();
            s.Name = textBoxName.Text;
            s.Surname = textBoxSurname.Text;
            s.PhoneNumber = textBoxPhoneNumber.Text;
            s.Fax = textBoxFax.Text;
            s.Email = textBoxEmail.Text;
            s.Address = textBoxAdress.Text;
            s.Description = textBoxDescription.Text;

            if (this.contactBusiness.InsertContact(s))
            {
                RefreshData();
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPhoneNumber.Text = "";
                textBoxFax.Text = "";
                textBoxEmail.Text = "";
                textBoxDescription.Text = "";
                textBoxAdress.Text = "";
               
            }
            else
            {
                MessageBox.Show("Greska!");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.contactBusiness.DeleteContact(textBoxDelete.Text);
            RefreshData();
            textBoxDelete.Text = "";
        }

        
    }
}
