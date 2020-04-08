using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using FinalProject_ClassLibrary.DataAccess;
using FinalProject_ClassLibrary.Functions;
using FinalProject_ClassLibrary.Business;


namespace FinalProject_ClassLibrary.Business
{
    public class Employee
    {
        int id;
        string firstName;
        string lastName;
        string jobTtile;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTtile { get => jobTtile; set => jobTtile = value; }

        public bool IsuniqueID(int id, int check)
        {
            return (EmployeeDB.IsUniqueId(id, check));
        }
        public void SaveEmployees(Employee emp)
        {
            EmployeeDB.SaveData(emp);
        }

        public List<Employee> GetAllEmployee()
        {
            return (EmployeeDB.GetRecordList());
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateEmployee(emp);
        }

        public Employee SearchByID(int id, int number)
        {
            return (EmployeeDB.SearchByid(id, number));
        }

        public List<Employee> SearchBytext(string text)
        {
            return (EmployeeDB.SearchByString(text));
        }

        public void DeleteDate(int id, int number)
        {
            EmployeeDB.DeleteDate(id, number);
        }
    }

    public class User : Employee
    {
        string psw;

        public string Psw { get => psw; set => psw = value; }

        public List<User> GetAllUser()
        {
            return UserDB.GetRecordListUser();
        }

        public void SaveUser(User user)
        {
            UserDB.SaveData(user);
        }

        public void updataPsw(User user)
        {
            UserDB.UpateUserPsw(user);
        }

        public User GetPassword(int id)
        {
            return (UserDB.Getpassword(id));
        }
    }

    public class Customer
    {
        int customerId;
        string name;
        string email;
        string address;
        string city;
        string pc;
        string ph;
        string fn;
        int createLimit;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Pc { get => pc; set => pc = value; }
        public string Ph { get => ph; set => ph = value; }
        public string Fn { get => fn; set => fn = value; }
        public int CreateLimit { get => createLimit; set => createLimit = value; }

        //public DataTable CreateTableDC()
        //{
        //    return (CustomerDB.CreateDataset());
        //}

        public List<Customer> GetAllCustomer()
        {
            return (CustomerDB.getAllListCustomer());
        }
    }

    public class Book
    {
        string isbn;
        string title;
        float price;
        int qoh;
        int catId;
        int pubId;
        int yearsPublished;

        public string Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public float Price { get => price; set => price = value; }
        public int Qoh { get => qoh; set => qoh = value; }
        public int CatId { get => catId; set => catId = value; }
        public int PubId { get => pubId; set => pubId = value; }
        public int YearsPublished { get => yearsPublished; set => yearsPublished = value; }

        public void addBook(Book bk)
        {
            BookDB.Add(bk);
        }
        public List<Book> GetAllBooks()
        {
            return (BookDB.GetRecordList());
        }
        public void UpdateBook(Book bk)
        {
            BookDB.UpdateBook(bk);
        }
        public void DeleteDate(string Qoh)
        {
            BookDB.DeleteDate(Qoh);
        }
        public Book SearchByID(string id)
        {
            return (BookDB.SearchById(id));
        }
    }
} 

namespace FinalProject_ClassLibrary.DataAccess
{
    public class EmployeeDB
    {
        public static void SaveData(Employee emp)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Employees " +
                                "VALUES (" + emp.Id +
                                ", '" +
                                emp.FirstName +
                                "','" +
                                emp.LastName +
                                "','" +
                                emp.JobTtile +
                                "')";
            cmd.ExecuteNonQuery();
            connDB.Close();
            
     
        }

        public static bool IsUniqueId(int tempid, int check)
        {
            if (check == 1)
            {
                SqlConnection connDB = UtilityDB.ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "SELECT * FROM Employees " +
                                "WHERE EmployeeID = " + tempid;
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id != 0)
                {
                    connDB.Close();
                    return false;
                }
                connDB.Close();
                return true;


            }
            else
            {
                SqlConnection connDB = UtilityDB.ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "SELECT * FROM Users " +
                                "WHERE UserID = " + tempid;
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id != 0)
                {
                    connDB.Close();
                    return false;
                }
                connDB.Close();
                return true;
            }

        }//check empid

        public static List<Employee> GetRecordList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp;
            List<Employee> empList = new List<Employee>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emp = new Employee();
                    emp.Id = Convert.ToInt32(reader["EmployeeID"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTtile = reader["JobTitle"].ToString();
                    empList.Add(emp);
                }
            }
            else
            {
                empList = null;
            }
            reader.Close();
            connDB.Close();
            return empList;

        }//get all employee info

        public static void UpdateEmployee(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update Employees " +
                              "SET FirstName= @FirstName, " +
                              "LastName= @LastName, " +
                              "JobTitle= @JobTitle " +
                              "WHERE EmployeeID=@EmployeeID";
            cmd.Parameters.AddWithValue("@EmployeeID", emp.Id);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTtile);
            

            cmd.ExecuteNonQuery();
            connDB.Close();
        }//update

        public static Employee SearchByid(int id, int number)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            if (number == 1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "SELECT * FROM Employees " +
                                "WHERE EmployeeID = @EmployeeID ";
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                Employee emp = new Employee();
                if (reader.Read())
                {

                    emp.Id = Convert.ToInt32(reader["EmployeeID"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTtile = reader["JobTitle"].ToString();
                   

                }
                else
                {
                    emp = null;
                }
                reader.Close();
                connDB.Close();
                return emp;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "SELECT * FROM Employees " +
                                "WHERE EmployeeID IN (SELECT UserID FROM Users WHERE UserID = @UserID) ";
                cmd.Parameters.AddWithValue("@UserID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                Employee emp = new Employee();
                if (reader.Read())
                {

                    emp.Id = Convert.ToInt32(reader["EmployeeID"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTtile = reader["JobTitle"].ToString();
                    

                }
                else
                {
                    emp = null;
                }
                reader.Close();
                connDB.Close();
                return emp;

            }

        }//search by id

        public static List<Employee> SearchByString(string text)
        {



            List<Employee> empList = new List<Employee>();
            List<Employee> emptemplist = new List<Employee>();
            Employee emptemp = new Employee();
            emptemplist = emptemp.GetAllEmployee();
            if (emptemplist != null)
            {
                foreach (Employee oneemp in emptemplist)
                {
                    if (text.ToLower() == oneemp.FirstName.ToLower() || text.ToLower() == oneemp.LastName.ToLower() || text.ToLower() == oneemp.JobTtile.ToLower())
                    {
                        empList.Add(oneemp);

                    }

                }
            }
            return empList;



        }

        public static void DeleteDate(int id, int number)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            if (number == 1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID";
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "DELETE FROM Users WHERE UserID=@UserID";
                cmd.Parameters.AddWithValue("@UserID", id);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
        }
    }

    public class UserDB
    {
        public static void SaveData(User user)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Users " +
                                "VALUES (" + user.Id +
                                ", '" +
                                user.Psw +
                                "')";
            //MessageBox.Show(user.EmployeeID.ToString());
            cmd.ExecuteNonQuery();
            connDB.Close();
        }//save data
        public static List<User> GetRecordListUser()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Employees WHERE EmployeeID IN (SELECT UserID FROM USERS)";
            SqlDataReader reader = cmd.ExecuteReader();
            User user;
            List<User> userlist = new List<User>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = new User();
                    user.Id = Convert.ToInt32(reader["EmployeeID"]);
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.JobTtile = reader["JobTitle"].ToString();


                    userlist.Add(user);
                }
            }
            else
            {
                userlist = null;
            }
            reader.Close();
            connDB.Close();
            return userlist;
        }

        public static void UpateUserPsw(User user)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update Users " +
                              "SET Password= @Password " +
                              "WHERE UserID=@UserID";
            cmd.Parameters.AddWithValue("@Password", user.Psw);
            cmd.Parameters.AddWithValue("@UserID", user.Id);
            try
            {
                cmd.ExecuteNonQuery();
                connDB.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        } // upate password

        public static User Getpassword(int id)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT UserID, Password FROM Users WhERE UserID= @UserID";
            cmd.Parameters.AddWithValue("@UserID", id);
            SqlDataReader reader = cmd.ExecuteReader();

            User user = new User();
            if (reader.Read())
            {

                user.Id = Convert.ToInt32(reader["UserID"]);
                user.Psw = reader["Password"].ToString();
            }
            else
            {
                user = null;
            }
            reader.Close();
            connDB.Close();
            return user;

        }
    }

    public class CustomerDB
    {
        //public static DataTable CreateDataset()
        //{
        //    SqlDataAdapter dataAdapter;
        //    SqlCommandBuilder builder;
        //    DataSet dsHiTech;
        //    DataTable dtCustomer;
        //    Customer customer = new Customer();
        //    dsHiTech = new DataSet("Hi-Tech");
        //    dtCustomer = new DataTable("Customers");
        //    dtCustomer.Columns.Add("CustomerID", typeof(int));
        //    dtCustomer.Columns.Add("Name", typeof(string));
        //    dtCustomer.Columns.Add("Email", typeof(string));
        //    dtCustomer.Columns.Add("Address", typeof(string));
        //    dtCustomer.Columns.Add("City", typeof(string));
        //    dtCustomer.Columns.Add("PostalCode", typeof(string));
        //    dtCustomer.Columns.Add("PhoneNumber", typeof(string));
        //    dtCustomer.Columns.Add("FaxNumber", typeof(string));
        //    dtCustomer.Columns.Add("CreditLimit", typeof(int));

        //    dtCustomer.PrimaryKey = new DataColumn[] { dtCustomer.Columns["CustomerID"] };
        //    dsHiTech.Tables.Add(dtCustomer);
        //    dataAdapter = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
        //    dataAdapter.Fill(dsHiTech.Tables["Customers"]);
        //    return dtCustomer;

        //}

        public static List<Customer> getAllListCustomer()
        {
            List<Customer> customers = new List<Customer>();
            Customer cus;
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", connDB);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cus = new Customer();
                    cus.CustomerId = Convert.ToInt32(reader["CustomerID"]);
                    cus.Name = reader["Name"].ToString();
                    cus.Email = reader["Email"].ToString();
                    cus.Address = reader["Address"].ToString();
                    cus.City = reader["City"].ToString();
                    cus.Pc = reader["PostalCode"].ToString();
                    cus.Ph = reader["PhoneNumber"].ToString();
                    cus.Fn = reader["FaxNumber"].ToString();
                    cus.CreateLimit = Convert.ToInt32(reader["CreditLimit"]);
                    customers.Add(cus);
                }
            }
            else
            {
                customers = null;
            }
            reader.Close();
            connDB.Close();
            return customers;
        }

        public static bool IsUniqueId(int tempid)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Customers " +
                            "WHERE CustomerID = " + tempid;
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id != 0)
            {
                connDB.Close();
                return false;
            }
            connDB.Close();
            return true;


        }


    }

    public class BookDB
    {
        public static void Add(Book bk)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Books " +
                                "VALUES (" + bk.Isbn +
                                ", '" +
                                bk.Title +
                                "','" +
                                bk.Price +
                                "','" +
                                bk.Qoh +
                                "','" +
                                bk.CatId +
                                "','" +
                                bk.PubId +
                                "','" +
                                bk.YearsPublished +
                                "')";
            cmd.ExecuteNonQuery();
            connDB.Close();
        }   
        public static List<Book> GetRecordList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Books";
            SqlDataReader reader = cmd.ExecuteReader();
            Book bk;
            List<Book> bkList = new List<Book>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    bk = new Book();
                    bk.Isbn = reader["ISBN"].ToString();
                    bk.Title = reader["Title"].ToString();
                    bk.Price = Convert.ToInt32(reader["Price"]);
                    bk.Qoh = Convert.ToInt32(reader["QOH"]);
                    bk.CatId = Convert.ToInt32(reader["CatID"]);
                    bk.PubId = Convert.ToInt32(reader["PubID"]);
                    bk.YearsPublished = Convert.ToInt32(reader["YearsPublished"]);


                    bkList.Add(bk);
                }
            }
            else
            {
                bkList = null;
            }
            reader.Close();
            connDB.Close();
            return bkList;

        }//get all book info

        public static void UpdateBook(Book bk)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update Books " +
                              "SET ISBN= @ISBN, " +
                              "Title= @Title, " +
                              "Price= @Price, " +
                              "QOH = @QOH " +
                              "CatID= @CatID " +
                              "PubID= @PubID " +
                              "YearsPublished= @YearsPublished " +
                              "WHERE ISBN= @ISBN";
            cmd.Parameters.AddWithValue("@ISBN", bk.Isbn);
            cmd.Parameters.AddWithValue("@Title", bk.Title);
            cmd.Parameters.AddWithValue("@Price", bk.Price);
            cmd.Parameters.AddWithValue("@QOH", bk.Qoh);
            cmd.Parameters.AddWithValue("@CatId", bk.CatId);
            cmd.Parameters.AddWithValue("@PubID", bk.PubId);
            cmd.Parameters.AddWithValue("@YearsPublished", bk.YearsPublished);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }//update

        public static void DeleteDate(string isbn)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
  
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "DELETE FROM Books WHERE ISBN=@ISBN";
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.ExecuteNonQuery();
                connDB.Close();
            
        

        }

 
        public static Book SearchById(string CatId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB(); SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Books " +
                            "WHERE EmployeeID = @EmployeeID ";
            cmd.Parameters.AddWithValue("@EmployeeID", CatId);
            SqlDataReader reader = cmd.ExecuteReader();
            Book book = new Book();
            if (reader.Read())
            {

                book.Isbn = reader["ISBN"].ToString();
                book.Title = reader["Title"].ToString();
                book.Price = Convert.ToInt32(reader["Price"]);
                book.Qoh = Convert.ToInt32(reader["QOH"]);
                book.CatId = Convert.ToInt32(reader["CatID"]);
                book.PubId = Convert.ToInt32(reader["PubID"]);
                book.YearsPublished = Convert.ToInt32(reader["YearsPublished"]);

            }
            else
            {
                book = null;
            }
            reader.Close();
            connDB.Close();
            return book;
        }


    }

    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HI-TechConnection"].ConnectionString;
            conn.Open();
            return conn;

        }
    }
}

namespace FinalProject_ClassLibrary.Functions
{
    public class Validation
    {
        public static bool IsValidId(string input, int number)
        {
            if (!Regex.IsMatch(input, @"^\d{" + number + "}$"))
            {
                MessageBox.Show("Invalid Employee ID", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }// validate Employee ID

        public static bool IsValidString(string input, string text)
        {
            if (input.Length == 0)
            {
                MessageBox.Show(text + " must contain only letters or space ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!(char.IsLetter(input[i])) && !(char.IsWhiteSpace(input[i])))
                    {
                        MessageBox.Show(text + " must contain only letters or space ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }

        }//validate string

        public static bool IsValidNumber(string number)
        {
            if (number.Length == 0)
            {
                MessageBox.Show(" must contain only number or space ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if ((char.IsLetter(number[i])) && !(char.IsWhiteSpace(number[i])))
                    {
                        MessageBox.Show(" must contain only letters or space ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }
            return true;
        }

        public static bool IsValidPhoneNumber(string input, string text)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    MessageBox.Show("Please entre right " + text, "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;

            //Regex regex = new Regex(@"^[\\(]{0,1}([0-9]){3}[\\)]{0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$");
            //if (!regex.IsMatch(input))
            //{
            //    MessageBox.Show("Please entre Phone Number", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }//validate phone

        public static bool IsValidAddress(string input)
        {
            Regex regex = new Regex(@"^\d{1,10}.?\d{0,3}\s[a-zA-Z]{2,30}\s[a-zA-Z]{2,15}");
            if (!regex.IsMatch(input))
            {
                MessageBox.Show("Please entre Address ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidEmail(string input)
        {
            try
            {
                MailAddress mail = new MailAddress(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsValidCity(string input)
        {
            Regex regex = new Regex(@"^[A-Z]([a-z]{2,})?(\s)?(([A-Z][a-z]{2,})?)$");
            if (!regex.IsMatch(input))
            {
                MessageBox.Show("Please entre City ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidPostalCode(string input)
        {
            Regex regex = new Regex(@"^([A-Z][0-9][A-Z])(\s|-)?([0-9][A-Z][0-9])$");
            if (!regex.IsMatch(input))
            {
                MessageBox.Show("Please enter PostalCode", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }


    }
    public class SmallFunction
    {
        public static string FirstCharToupper(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            string str = input.First().ToString().ToUpper() + input.Substring(1).ToLower();

            return str;
        }// First letter toupper


    }
}
