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
using System.Data.SqlClient;

namespace FinalProject_HiTech.Gui
{
    public partial class CustomerFormName : Form
    {

        SqlDataAdapter dataAdapter;
        SqlCommandBuilder builder;
        DataSet dsHiTech;
        DataTable dtCustomer;
        Customer customer = new Customer();
        public CustomerFormName()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dsHiTech = new DataSet("Hi-Tech");
            dtCustomer = new DataTable("Customers");
            dtCustomer.Columns.Add("CustomerID", typeof(int));
            dtCustomer.Columns.Add("Name", typeof(string));
            dtCustomer.Columns.Add("Email", typeof(string));
            dtCustomer.Columns.Add("Address", typeof(string));
            dtCustomer.Columns.Add("City", typeof(string));
            dtCustomer.Columns.Add("PostalCode", typeof(string));
            dtCustomer.Columns.Add("PhoneNumber", typeof(string));
            dtCustomer.Columns.Add("FaxNumber", typeof(string));
            dtCustomer.Columns.Add("CreditLimit", typeof(int));

            dtCustomer.PrimaryKey = new DataColumn[] { dtCustomer.Columns["CustomerID"] };
            dsHiTech.Tables.Add(dtCustomer);
            dataAdapter = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            dataAdapter.Fill(dsHiTech.Tables["Customers"]);
          

            //customer.CreateTableDC();
        }

        private void ButtonUpdateDB_Click(object sender, EventArgs e)
        {
            builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dsHiTech.Tables["Customers"]);
            MessageBox.Show("Database has been updted successfully.", "Confirmation");
        }
        private void ButtonListCustomer_Click(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = customer.GetAllCustomer();
        }

        private void ButtonListCustomerDS_Click(object sender, EventArgs e)
        {
            dataAdapter.Fill(dsHiTech.Tables["Customers"]);
            dataGridViewCustomerDS.DataSource = dsHiTech.Tables["Customers"];

        }

        private void ButtonCusSave_Click(object sender, EventArgs e)
        {
            if (!(Validation.IsValidId(textBoxCusID.Text.Trim(),4))){

                textBoxCusID.Clear();
                textBoxCusID.Focus();
                return;
            }
            customer.CustomerId = Convert.ToInt32(textBoxCusID.Text.Trim());
            if (!(Validation.IsValidString(textName.Text.Trim(), "University")))
            {
                textName.Clear();
                textName.Focus();
                return;
            }
            customer.Name = textName.Text.Trim();
            if (!(Validation.IsValidEmail(textBoxCusEmail.Text.Trim())))
            {
                textBoxCusEmail.Clear();
                textBoxCusEmail.Focus();
                return;
            }
            customer.Email = textBoxCusEmail.Text.Trim();
            if (!(Validation.IsValidAddress(textBoxCusAddress.Text.Trim())))
            {
                textBoxCusAddress.Clear();
                textBoxCusAddress.Focus();
                return;
            }
            customer.Address = textBoxCusAddress.Text.Trim();
            if (!(Validation.IsValidCity(textBoxCusCity.Text.Trim())))
            {
                textBoxCusCity.Clear();
                textBoxCusCity.Focus();
                return;
            }
            customer.City = textBoxCusCity.Text.Trim();

            if (!(Validation.IsValidPostalCode(textBoxCusPC.Text.Trim())))
            {
                textBoxCusPC.Clear();
                textBoxCusPC.Focus();
                return;
            }
            customer.Pc = textBoxCusPC.Text.Trim();

            if(!Validation.IsValidPhoneNumber(maskedTextBoxCusPhone.Text.Trim(), "Phone Number")){
                maskedTextBoxCusPhone.Clear();
                maskedTextBoxCusPhone.Focus();
                return;
            }
            customer.Ph = maskedTextBoxCusPhone.Text.Trim();
            if(!Validation.IsValidPhoneNumber(maskedTextBoxCusFaxName.Text.Trim(),"Fax Number"))
            {
                maskedTextBoxCusFaxName.Clear();
                maskedTextBoxCusFaxName.Focus();
                return;
            }
            customer.Fn = maskedTextBoxCusFaxName.Text.Trim();
            if (!(Validation.IsValidNumber(textBoxCreateLimit.Text.Trim())))
            {
                textBoxCreateLimit.Clear();
                textBoxCreateLimit.Focus();
                return;
            }
            customer.CreateLimit = Convert.ToInt32(textBoxCreateLimit.Text.Trim());

            dataAdapter = new SqlDataAdapter("INSERT INTO Customers " +
                                "VALUES (" + customer.CustomerId +
                                ", '" +
                                customer.Name +
                                "','" +
                                customer.Email +
                                "','" +
                                customer.Address +
                                "','" +
                                customer.City +
                                "','" +
                                customer.Pc +
                                "','" +
                                customer.Ph +
                                "','" +
                                customer.Fn +
                                "','"+
                                customer.CreateLimit +
                                "')", UtilityDB.ConnectDB());
            
            dataAdapter.Fill(dsHiTech.Tables["Customers"]);
            MessageBox.Show("Database has been insert successfully.", "Confirmation");



        }

        private void ButtonCuUpdate_Click(object sender, EventArgs e)
        {
            int searchid = Convert.ToInt32(textBoxCusID.Text.Trim());
            DataRow drcustomer = dtCustomer.Rows.Find(searchid);
           
                drcustomer["CustomerID"] = Convert.ToInt32(textBoxCusID.Text.Trim());
                drcustomer["Name"] = textName.Text.Trim();
                drcustomer["Email"] = textBoxCusEmail.Text.Trim();
                drcustomer["Address"] = textBoxCusAddress.Text.Trim();
                drcustomer["City"] = textBoxCusCity.Text.Trim();
                drcustomer["PostalCode"] = textBoxCusPC.Text.Trim();
                drcustomer["PhoneNumber"] = maskedTextBoxCusPhone.Text.Trim();
                drcustomer["FaxNumber"] = maskedTextBoxCusFaxName.Text.Trim();
                drcustomer["CreditLimit"] = Convert.ToInt32(textBoxCreateLimit.Text.Trim());
            
         


        }

        private void ButtonCusSearch_Click(object sender, EventArgs e)
        {
            int searchid = Convert.ToInt32(textBoxCusSearchCID.Text.Trim());
            foreach (DataRow dr in dtCustomer.Rows)
            {
                if (searchid == Convert.ToInt32(dr["CustomerID"]))
                {
                    textBoxCusID.Text = dr["CustomerID"].ToString();
                    textName.Text = dr["Name"].ToString();
                    textBoxCusEmail.Text = dr["Email"].ToString();
                    textBoxCusAddress.Text = dr["Address"].ToString();
                    textBoxCusCity.Text = dr["City"].ToString();
                    textBoxCusPC.Text = dr["PostalCode"].ToString();
                    maskedTextBoxCusPhone.Text = dr["PhoneNumber"].ToString();
                    maskedTextBoxCusFaxName.Text = dr["FaxNumber"].ToString();
                    textBoxCreateLimit.Text = dr["CreditLimit"].ToString();
                    break;
                }
            }
        }

        private void ButtonCusDelete_Click(object sender, EventArgs e)
        {
            int searchid = Convert.ToInt32(textBoxCusID.Text.Trim());
            DataRow drcustomer = dtCustomer.Rows.Find(searchid);
            drcustomer.Delete();
            MessageBox.Show("Already delete");
        }
    }
}
