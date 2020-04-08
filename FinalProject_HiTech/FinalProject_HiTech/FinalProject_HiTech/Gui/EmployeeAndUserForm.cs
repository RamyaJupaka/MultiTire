using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_ClassLibrary.DataAccess;
using FinalProject_ClassLibrary.Business;
using FinalProject_ClassLibrary.Functions;

namespace FinalProject_HiTech.Gui
{
    public partial class EmployeeAndUserForm : Form
    {
        public EmployeeAndUserForm()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(UtilityDB.ConnectDB().State.ToString());

        }

        private void ButtonEmployeeSave_Click(object sender, EventArgs e)
        {
            string input = "";
            input = textBoxEmpID.Text.Trim();
            if (!Validation.IsValidId(input, 4))
            {
                textBoxEmpID.Clear();
                textBoxEmpID.Focus();
                return;
            }

            int empid = Convert.ToInt32(textBoxEmpID.Text.Trim());
            Employee emp = new Employee();
            if (!(emp.IsuniqueID(empid, 1)))
            {
                MessageBox.Show("This Employee ID already exists!", "Duplicate Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input = textBoxFirstName.Text.Trim();
            if (!(Validation.IsValidString(input, "First name")))
            {
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
            }
            input = textBoxLastName.Text.Trim();
            if (!Validation.IsValidString(input, "Last name"))
            {
                textBoxLastName.Clear();
                textBoxLastName.Focus();
            }
            input = textBoxJobTitle.Text.Trim();
            if (!Validation.IsValidString(input, "Job title"))
            {
                textBoxJobTitle.Clear();
                textBoxJobTitle.Focus();
            }



            emp.Id = Convert.ToInt32(textBoxEmpID.Text.Trim());
            emp.FirstName = SmallFunction.FirstCharToupper(textBoxFirstName.Text.Trim());
            emp.LastName = SmallFunction.FirstCharToupper(textBoxLastName.Text.Trim());
            emp.JobTtile = SmallFunction.FirstCharToupper(textBoxJobTitle.Text.Trim());


            emp.SaveEmployees(emp);

            MessageBox.Show("Employee record has been saved", "Employee Saved", MessageBoxButtons.OK);
            textBoxEmpID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxJobTitle.Clear();


        }



        private void ButtonEmployeeListALL_Click(object sender, EventArgs e)
        {
            listViewEmployee.Items.Clear();
            Employee emp = new Employee();
            List<Employee> empList = new List<Employee>();
            empList = emp.GetAllEmployee();
            if (empList != null)
            {
                foreach (Employee empItem in empList)
                {
                    ListViewItem item = new ListViewItem(empItem.Id.ToString());
                    item.SubItems.Add(empItem.FirstName);
                    item.SubItems.Add(empItem.LastName);
                    item.SubItems.Add(empItem.JobTtile);


                    listViewEmployee.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No employee data in the databasse", "Not Employee data", MessageBoxButtons.OK);
            }
        }
        private void ButtonEmployeeUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eee");
            Employee emp = new Employee();
            emp.Id = Convert.ToInt32(textBoxEmpID.Text.Trim());
            emp.FirstName = SmallFunction.FirstCharToupper(textBoxFirstName.Text.Trim());
            emp.LastName = SmallFunction.FirstCharToupper(textBoxLastName.Text.Trim());
            emp.JobTtile = SmallFunction.FirstCharToupper(textBoxJobTitle.Text.Trim());

            emp.UpdateEmployee(emp);
            MessageBox.Show("Employee Record updataed sucessfully", "Updata Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxEmpID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxJobTitle.Clear();
        }

        private void ComboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexselect = comboBoxEmployee.SelectedIndex;
            switch (indexselect)
            {
                case 1:
                    label6.Text = "Please enter Employee id";
                    textBox1EmployeeSearch.Clear();
                    textBox1EmployeeSearch.Focus();
                    break;
                case 2:
                    label6.Text = "Please enter First name";
                    textBox1EmployeeSearch.Clear();
                    textBox1EmployeeSearch.Focus();
                    break;
                case 3:
                    label6.Text = "Please enter Last name";
                    textBox1EmployeeSearch.Clear();
                    textBox1EmployeeSearch.Focus();
                    break;
                case 4:
                    label6.Text = "Please enter Job title";
                    textBox1EmployeeSearch.Clear();
                    textBox1EmployeeSearch.Focus();
                    break;
         
                default:
                    MessageBox.Show("Invalid enter,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonEmployeeSearch_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> emplist = new List<Employee>();
            int indexselect = comboBoxEmployee.SelectedIndex;
            string text = textBox1EmployeeSearch.Text.Trim();
            switch (indexselect)
            {
                case 1:
                    if (!Validation.IsValidId(textBox1EmployeeSearch.Text.Trim(), 4))
                    {
                        textBox1EmployeeSearch.Clear();
                        textBox1EmployeeSearch.Focus();
                        return;
                    }
                    emp.Id = Convert.ToInt32(textBox1EmployeeSearch.Text.Trim());
                    emp = emp.SearchByID(emp.Id, 1);
                    if (emp != null)
                    {
                        textBox1EmployeeSearch.Clear();
                        textBoxEmpID.Text = emp.Id.ToString();
                        textBoxFirstName.Text = emp.FirstName;

                        textBoxLastName.Text = emp.LastName;
                        textBoxJobTitle.Text = emp.JobTtile;
                       
                    }
                    else
                    {

                        MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
                    }
                    break;
                case 2:
                    if (!Validation.IsValidString(textBox1EmployeeSearch.Text.Trim(), "First Name"))
                    {
                        textBox1EmployeeSearch.Clear();
                        textBox1EmployeeSearch.Focus();
                        return;
                    }
                    else
                    {
                        listViewEmployee.Items.Clear();

                        emplist = emp.SearchBytext(text);
                        if (emplist != null)
                        {
                            foreach (Employee oneemp in emplist)
                            {
                                ListViewItem item = new ListViewItem(oneemp.Id.ToString());
                                item.SubItems.Add(oneemp.FirstName);
                                item.SubItems.Add(oneemp.LastName);
                                item.SubItems.Add(oneemp.JobTtile);
                              
                                listViewEmployee.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
                        }
                    }
                    break;
                case 3:
                    if (!Validation.IsValidString(textBox1EmployeeSearch.Text.Trim(), "Last Name"))
                    {
                        textBox1EmployeeSearch.Clear();
                        textBox1EmployeeSearch.Focus();
                        return;
                    }
                    else
                    {
                        listViewEmployee.Items.Clear();

                        emplist = emp.SearchBytext(text);
                        if (emplist != null)
                        {
                            foreach (Employee oneemp in emplist)
                            {
                                ListViewItem item = new ListViewItem(oneemp.Id.ToString());
                                item.SubItems.Add(oneemp.FirstName);
                                item.SubItems.Add(oneemp.LastName);
                                item.SubItems.Add(oneemp.JobTtile);
                               
                                listViewEmployee.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
                        }
                    }
                    break;
                case 4:
                    if (!Validation.IsValidString(textBox1EmployeeSearch.Text.Trim(), "Job Title"))
                    {
                        textBox1EmployeeSearch.Clear();
                        textBox1EmployeeSearch.Focus();
                        return;
                    }
                    else
                    {
                        listViewEmployee.Items.Clear();


                        emplist = emp.SearchBytext(text);
                        if (emplist != null)
                        {
                            foreach (Employee oneemp in emplist)
                            {
                                ListViewItem item = new ListViewItem(oneemp.Id.ToString());
                                item.SubItems.Add(oneemp.FirstName);
                                item.SubItems.Add(oneemp.LastName);
                                item.SubItems.Add(oneemp.JobTtile);
                               
                                listViewEmployee.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
                        }
                    }
                    break;
                case 5:
                    listViewEmployee.Items.Clear();
                    emplist = emp.SearchBytext(text);
                    if (emplist != null)
                    {
                        foreach (Employee oneemp in emplist)
                        {
                            ListViewItem item = new ListViewItem(oneemp.Id.ToString());
                            item.SubItems.Add(oneemp.FirstName);
                            item.SubItems.Add(oneemp.LastName);
                            item.SubItems.Add(oneemp.JobTtile);
                            
                            listViewEmployee.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
                    }
                    break;
            }
        }

        private void ButtonEmployeeDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to delete the employee record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Employee emp = new Employee();
                emp.DeleteDate(Convert.ToInt32(textBoxEmpID.Text), 1);
                MessageBox.Show("Employee Record delete sucessfully", "delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxEmpID.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxJobTitle.Clear();
               
            }
            else
            {
                return;
            }

        }

        private void ButtonUserSave_Click(object sender, EventArgs e)
        {
            string input = "";
            input = textBoxUserID.Text.Trim();
            if (!Validation.IsValidId(input, 4))
            {
                textBoxUserID.Clear();
                textBoxUserID.Focus();
                return;
            }

            int id = Convert.ToInt32(textBoxUserID.Text.Trim());

            User user = new User();
            //MessageBox.Show(user.EmployeeID.ToString());
            if (!(user.IsuniqueID(id, 0)))
            {
                MessageBox.Show("This User ID already exists!", "Duplicate Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            user.Id = Convert.ToInt32(textBoxUserID.Text.Trim());
            user.Psw = textBoxpsw.Text.Trim();
            string repsw = textBoxrepsw.Text.Trim();
            if (user.Psw == repsw)
            {
                user.SaveUser(user);
                MessageBox.Show("User record has been saved", "User Saved", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Check password");
            }
        }

        private void ButtonUserUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            bool check = false;
            try
            {
                user.Id = Convert.ToInt32(textBoxUserID.Text.Trim());
                user.Psw = textBoxpsw.Text.Trim();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                check = true;
                return;
            }
            string repsw = textBoxrepsw.Text.Trim();

            if (!check)
            {
                if (user.Psw == repsw && user.Psw != null)
                {
                    user.updataPsw(user);
                    MessageBox.Show("Employee Record updataed sucessfully", "Updata Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxpsw.Clear();
                    textBoxrepsw.Clear();
                }
                else
                {
                    MessageBox.Show("Check Password again");
                    textBoxpsw.Clear();
                    textBoxrepsw.Clear();
                }

            }

        }

        private void ButtonUserList_Click(object sender, EventArgs e)
        {
            listViewUser.Items.Clear();
            User user = new User();
            List<User> userList = new List<User>();
            userList = user.GetAllUser();
            if (userList != null)
            {
                foreach (Employee useritem in userList)
                {
                    ListViewItem item = new ListViewItem(useritem.Id.ToString());
                    item.SubItems.Add(useritem.FirstName);
                    item.SubItems.Add(useritem.LastName);
                    item.SubItems.Add(useritem.JobTtile);
                 
                    listViewUser.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No employee data in the databasse", "Not Employee data", MessageBoxButtons.OK);
            }

        }

        private void ComboBoxTOsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexselect = comboBoxTOsearch.SelectedIndex;
            switch (indexselect)
            {
                case 1:
                    label9.Text = "Please enter Employee id";
                    textBoxToSearchInput.Clear();
                    textBoxToSearchInput.Focus();
                    break;
                case 2:
                    label9.Text = "Please enter First name";
                    textBoxToSearchInput.Clear();
                    textBoxToSearchInput.Focus();
                    break;
                case 3:
                    label9.Text = "Please enter Last name";
                    textBoxToSearchInput.Clear();
                    textBoxToSearchInput.Focus();
                    break;
                case 4:
                    label9.Text = "Please enter Job title";
                    textBoxToSearchInput.Clear();
                    textBoxToSearchInput.Focus();
                    break;
              
                default:
                    MessageBox.Show("Invalid enter,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonUserSearch_Click(object sender, EventArgs e)
        {
            //Employee emp = new Employee();
            //List<Employee> emplist = new List<Employee>();
            //int indexselect = comboBoxTOsearch.SelectedIndex;
            //string text = textBoxToSearchInput.Text.Trim();
            //User user = new User();
            //switch (indexselect)
            //{
            //    case 1:
            //        if (!Validation.IsValidId(textBoxToSearchInput.Text.Trim(), 4))
            //        {
            //            textBoxToSearchInput.Clear();
            //            textBoxToSearchInput.Focus();
            //            return;
            //        }
            //        emp.Id = Convert.ToInt32(textBoxToSearchInput.Text.Trim());
            //        emp = emp.SearchByID(user.Id, 0);
            //        if (emp != null)
            //        {
            //            textBoxToSearchInput.Clear();
            //            textBoxUserID.Text = user.Id.ToString();
            //            textBoxUserFname.Text = user.FirstName;

            //            textBoxUserLname.Text = user.LastName;
            //            textBoxUserJobTitle.Text = user.JobTtile;

            //        }
            //        else
            //        {

            //            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
            //        }
            //        break;
            //    case 2:
            //        if (!Validation.IsValidString(textBox1EmployeeSearch.Text.Trim(), "First Name"))
            //        {
            //            textBox1EmployeeSearch.Clear();
            //            textBox1EmployeeSearch.Focus();
            //            return;
            //        }
            //        else
            //        {
            //            listViewEmployee.Items.Clear();

            //            emplist = emp.SearchBytext(text);
            //            if (emplist != null)
            //            {
            //                foreach (Employee oneemp in emplist)
            //                {
            //                    ListViewItem item = new ListViewItem(oneemp.Id.ToString());
            //                    item.SubItems.Add(oneemp.FirstName);
            //                    item.SubItems.Add(oneemp.LastName);
            //                    item.SubItems.Add(oneemp.JobTtile);

            //                    listViewEmployee.Items.Add(item);
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
            //            }
            //        }
            //        break;
            //    case 3:
            //        if (!Validation.IsValidString(textBox1EmployeeSearch.Text.Trim(), "Last Name"))
            //        {
            //            textBox1EmployeeSearch.Clear();
            //            textBox1EmployeeSearch.Focus();
            //            return;
            //        }
            //        else
            //        {
            //            listViewEmployee.Items.Clear();

            //            emplist = emp.SearchBytext(text);
            //            if (emplist != null)
            //            {
            //                foreach (Employee oneemp in emplist)
            //                {
            //                    ListViewItem item = new ListViewItem(oneemp.Id.ToString());
            //                    item.SubItems.Add(oneemp.FirstName);
            //                    item.SubItems.Add(oneemp.LastName);
            //                    item.SubItems.Add(oneemp.JobTtile);

            //                    listViewEmployee.Items.Add(item);
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
            //            }
            //        }
            //        break;
            //    case 4:
            //        if (!Validation.IsValidString(textBox1EmployeeSearch.Text.Trim(), "Job Title"))
            //        {
            //            textBox1EmployeeSearch.Clear();
            //            textBox1EmployeeSearch.Focus();
            //            return;
            //        }
            //        else
            //        {
            //            listViewEmployee.Items.Clear();


            //            emplist = emp.SearchBytext(text);
            //            if (emplist != null)
            //            {
            //                foreach (Employee oneemp in emplist)
            //                {
            //                    ListViewItem item = new ListViewItem(oneemp.Id.ToString());
            //                    item.SubItems.Add(oneemp.FirstName);
            //                    item.SubItems.Add(oneemp.LastName);
            //                    item.SubItems.Add(oneemp.JobTtile);

            //                    listViewEmployee.Items.Add(item);
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
            //            }
            //        }
            //        break;
            //    case 5:
            //        listViewEmployee.Items.Clear();
            //        emplist = emp.SearchBytext(text);
            //        if (emplist != null)
            //        {
            //            foreach (Employee oneemp in emplist)
            //            {
            //                ListViewItem item = new ListViewItem(oneemp.Id.ToString());
            //                item.SubItems.Add(oneemp.FirstName);
            //                item.SubItems.Add(oneemp.LastName);
            //                item.SubItems.Add(oneemp.JobTtile);

            //                listViewEmployee.Items.Add(item);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
            //        }
            //        break;
            //}
        }

        private void ButtonUserDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to delete the user record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                User user = new User();
                user.DeleteDate(Convert.ToInt32(textBoxUserID.Text), 0);
                MessageBox.Show("User Record delete sucessfully", "delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUserID.Clear();
                textBoxUserFname.Clear();
                textBoxLastName.Clear();
                textBoxJobTitle.Clear();

            }
            else
            {
                return;
            }
        }
    }
}
