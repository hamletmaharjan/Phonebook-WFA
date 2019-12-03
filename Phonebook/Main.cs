using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Phonebook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddContact addContact = new AddContact();
            addContact.TopLevel = false;
            addContact.Parent = panel1;
            addContact.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SearchContact searchContact = new SearchContact();
            searchContact.TopLevel=false;
            searchContact.Parent = panel1;
            searchContact.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EditContact editContact = new EditContact();
            editContact.TopLevel = false;
            editContact.Parent = panel1;
            editContact.Show();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ListContact listContact = new ListContact();
            listContact.TopLevel = false;
            listContact.Parent = panel1;
            listContact.Show();
        }
    }
}
