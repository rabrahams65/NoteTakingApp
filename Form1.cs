using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {

        DataTable table;



        public Form1()
        {
            InitializeComponent();

            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            msgDataGridView.DataSource = table;



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTheTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtName.Text, txtMessage.Text);



            ClearTheTextBoxes();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (GetIndex() > -1)
            {
                txtName.Text = table.Rows[GetIndex()].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[GetIndex()].ItemArray[1].ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
             
            dialogResult = MessageBox.Show("Are you sure you want to delete this message?","Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if ( dialogResult == DialogResult.Yes)
            {
                table.Rows[GetIndex()].Delete();
                ClearTheTextBoxes();
            }
            else
            {
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearTheTextBoxes()
        {
            this.txtMessage.Clear();
            this.txtName.Clear();
        }

        private int GetIndex()
        {
            int index = msgDataGridView.CurrentCell.RowIndex;
            
            return index;
        }
    }
}
