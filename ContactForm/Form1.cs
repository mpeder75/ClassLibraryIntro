using BuisnessLogic;

namespace ContactForm
{
    public partial class Form1 : Form
    {

        ContactBL bl;


        public Form1()
        {
            InitializeComponent();
            bl = new ContactBL();
            dgvContact.DataSource = bl.GetAllContacts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}