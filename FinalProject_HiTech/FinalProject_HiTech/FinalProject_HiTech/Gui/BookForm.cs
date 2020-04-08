using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_ClassLibrary.Business;
using FinalProject_ClassLibrary.DataAccess;
using FinalProject_ClassLibrary.Functions;


namespace FinalProject_HiTech.Gui
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void ButtonBookUpdate_Click(object sender, EventArgs e)
        {
            Book bk = new Book();
            bk.Isbn = (textBoxISBN.Text.Trim());
            bk.Title = SmallFunction.FirstCharToupper(textBoxTitle.Text.Trim());
            bk.Price = Convert.ToInt32(textBoxPrice.Text.Trim());
            bk.Qoh = Convert.ToInt32(textBoxQOH.Text.Trim());
            bk.CatId = Convert.ToInt32(textBoxCategoryID.Text.Trim());
            bk.PubId = Convert.ToInt32(textBoxPublishedID.Text.Trim());
            bk.YearsPublished = Convert.ToInt32(textBoxPublishedYear.Text.Trim());

            bk.UpdateBook(bk);
            MessageBox.Show("Employee Record updataed sucessfully", "Updata Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxPrice.Clear();
            textBoxQOH.Clear();
            textBoxCategoryID.Clear();
            textBoxPublishedID.Clear();
            textBoxPublishedYear.Clear();
        }


        private void ButtonBookAdd_Click(object sender, EventArgs e)
        {
            Book bk = new Book();
            bk.Isbn = textBoxISBN.Text.Trim();
            bk.Title = textBoxTitle.Text.Trim();
            bk.Price = float.Parse(textBoxPrice.Text.Trim());
            bk.Qoh = Convert.ToInt32(textBoxQOH.Text.Trim());
            bk.CatId = Convert.ToInt32(textBoxCategoryID.Text.Trim());
            bk.PubId = Convert.ToInt32(textBoxPublishedID.Text.Trim());
            bk.YearsPublished = Convert.ToInt32(textBoxPublishedYear.Text.Trim());
            bk.addBook(bk);
        }

        private void ButtonBookCancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to delete the Book record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Book bk = new Book();
                bk.DeleteDate(textBoxISBN.Text.Trim());
                MessageBox.Show("Employee Record delete sucessfully", "delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPrice.Clear();
                textBoxTitle.Clear();
                textBoxQOH.Clear();
                textBoxPublishedID.Clear();
                textBoxCategoryID.Clear();
                textBoxPublishedYear.Clear();
            }
            else
            {
                return;
            }
        }

        private void ButtonBookList_Click(object sender, EventArgs e)
        {

        }

    }
}
