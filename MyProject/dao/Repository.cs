using MyProject.enumaration;
using MyProject.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace MyProject.dao
{
    public class Repository
    {
        List<LoginTable> loginTableList;
        List<LoginTable> securityQuestionList;
        SqlConnection SqlConnection;
        SqlCommand cmd;
        SqlDataReader dr;
        int returningValue;

        public Repository()
        {
            SqlConnection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=Market;Integrated Security=True;");
        }

      






        public List<LoginTable> BringOnlySecurityQuestions()
        {
            securityQuestionList = new List<LoginTable>();
            SqlConnection.Open();
            cmd = new SqlCommand("select distinct securityQuestion from LoginTable", SqlConnection);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LoginTable securityQuestion = new LoginTable();
                securityQuestion.securityQuestion = dr["securityQuestion"].ToString();
                securityQuestionList.Add(securityQuestion);
            }

            SqlConnection.Close();

            return securityQuestionList;

        }


        public List<Product> BringAllProdcuts()
        {
            SqlConnection.Open();
            cmd = new SqlCommand("select * from Product", SqlConnection);
            dr = cmd.ExecuteReader();
            List<Product> products = new List<Product>();


            while (dr.Read())
            {
                Product product = new Product();
                product.id = int.Parse(dr["id"].ToString());
                product.barcodeNumber = dr["barcodeNumber"].ToString();
                product.productName = dr["productName"].ToString();
                product.kilo = int.Parse(dr["kilo"].ToString());
                product.price = int.Parse(dr["price"].ToString());


                products.Add(product);



            }

            SqlConnection.Close();

            return products;
        }




        public LoginStatus DeleteUser(int id)
        {
            SqlConnection.Open();
            cmd = new SqlCommand("delete from LoginTable where id = @id", SqlConnection);
            cmd.Parameters.AddWithValue("@id", id);
            int returnedValue = cmd.ExecuteNonQuery();

            SqlConnection.Close();

            if (returnedValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }

        }

        public LoginStatus UpdateProduct(Product product)
        {
            SqlConnection.Open();


            cmd = new SqlCommand("update Product set barcodeNumber=@barcodeNumber, productName = @productName, kilo = @kilo, price = @price where id = @id",SqlConnection);
            cmd.Parameters.AddWithValue("@id",product.id);
            cmd.Parameters.AddWithValue("@barcodeNumber",product.barcodeNumber);
            cmd.Parameters.AddWithValue("@productName",product.productName);
            cmd.Parameters.AddWithValue("@kilo",product.kilo);
            cmd.Parameters.AddWithValue("@price",product.price);
            returningValue = cmd.ExecuteNonQuery();

            SqlConnection.Close();

            if (returningValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }




            

        }


        public LoginStatus UpdateUser(User user)
        {
            SqlConnection.Open();


            cmd = new SqlCommand("UPDATE LoginTable SET userName=@userName, password=@password, authority=@authority, emailAdress=@emailAdress, securityQuestion=@securityQuestion, securityAnswer=@securityAnswer WHERE id=@id", SqlConnection);




            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@userName", user.userName);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@authority", user.authority);
            cmd.Parameters.AddWithValue("@emailAdress", user.emailAdress);
            cmd.Parameters.AddWithValue("@securityQuestion", user.securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", user.securityAnswer);
            int returnedValue = cmd.ExecuteNonQuery();
            SqlConnection.Close();

            if (returnedValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }



        }


        public LoginStatus AddUser(User user)
        {
            SqlConnection.Open();

            cmd = new SqlCommand("sp_AddNewUser", SqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user.userName);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@authority", user.authority);
            cmd.Parameters.AddWithValue("@emailAdress", user.emailAdress);
            cmd.Parameters.AddWithValue("@securityQuestion", user.securityQuestion);
            cmd.Parameters.AddWithValue("@securityQuestionAnswer", user.securityAnswer);
            int returnedValue = cmd.ExecuteNonQuery();
            SqlConnection.Close();


            if (returnedValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }


        }


        public List<LoginTable> GetLoginTable()
        {
            loginTableList = new List<LoginTable>();
            SqlConnection.Open();
            cmd = new SqlCommand("BringSecurityQuestion_sp", SqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LoginTable loginTable = new LoginTable();
                loginTable.id = int.Parse(dr["id"].ToString());
                loginTable.userName = dr["userName"].ToString();
                loginTable.password = dr["password"].ToString();
                loginTable.authority = dr["authority"].ToString();
                loginTable.emailAdress = dr["emailAdress"].ToString();
                loginTable.securityQuestion = dr["securityQuestion"].ToString();
                loginTable.securityAnswer = dr["securityAnswer"].ToString();
                loginTableList.Add(loginTable);


            }
            SqlConnection.Close();

            return loginTableList;




        }


        public LoginStatus ChangePassword(string username, string password)
        {
            SqlConnection.Open();
            cmd = new SqlCommand("update LoginTable set password = @password where userName = @username", SqlConnection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            returningValue = cmd.ExecuteNonQuery();
            SqlConnection.Close();

            return LoginStatus.Successful;
        }


        public LoginStatus DeleteProduct(int id)
        {
            SqlConnection.Open();
            cmd = new SqlCommand("delete from Product where id = @id", SqlConnection);
            cmd.Parameters.AddWithValue("@id", id);
            returningValue = cmd.ExecuteNonQuery();
            SqlConnection.Close();

            if (returningValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }





        }



        public LoginStatus AddProduct(Product product)
        {
            SqlConnection.Open();

            cmd = new SqlCommand("insert into Product (barcodeNumber,productName, kilo, price) VALUES (@barcodeNumber, @productName, @kilo, @price)", SqlConnection);

            cmd.Parameters.AddWithValue("@barcodeNumber", product.barcodeNumber);
            cmd.Parameters.AddWithValue("@kilo", product.kilo);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@productName", product.productName);
            returningValue = cmd.ExecuteNonQuery();

            SqlConnection.Close();

            if (returningValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }







        }


        public User Login(string username, string password)
        {
            SqlConnection.Open();
            cmd = new SqlCommand("select * from LoginTable where userName = @username and password = @password", SqlConnection);
            cmd.Parameters.AddWithValue("@userName", username);
            cmd.Parameters.AddWithValue("@password", password);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.userName = dr["username"].ToString();
                user.emailAdress = dr["emailAdress"].ToString();
                user.authority = dr["authority"].ToString();
                user.securityQuestion = dr["securityQuestion"].ToString();
                user.securityAnswer = dr["securityAnswer"].ToString();
                user.password = dr["password"].ToString();
                user.status = LoginStatus.Successful;
                SqlConnection.Close();
                return user;
            }

            else
            {
                SqlConnection.Close();
                User user = new User();
                user.status = LoginStatus.UnSuccessful;
                return user;
            }






        }

        public LoginStatus Authorize(string username, string securityAnswer, string securityQuestion)
        {
            SqlConnection.Open();
            cmd = new SqlCommand("Select count(*) from LoginTable where username = @username and securityAnswer = @securityAnswer and securityQuestion = @securityQuestion", SqlConnection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer);
            cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion);
            returningValue = (int)cmd.ExecuteScalar();

            SqlConnection.Close();

            if (returningValue == 1)
            {
                return LoginStatus.Successful;
            }
            else
            {
                return LoginStatus.UnSuccessful;
            }

        }


        public Product GetProduct(string barcodeNumber)
        {
            SqlConnection.Open();
            cmd = new SqlCommand("select * from Product where barcodeNumber = @barcodeNumber", SqlConnection);
            cmd.Parameters.AddWithValue("@barcodeNumber", barcodeNumber);
            dr = cmd.ExecuteReader();
            Product product = new Product();

            if (dr.Read())
            {
                product.id = int.Parse(dr["id"].ToString());
                product.barcodeNumber = dr["barcodeNumber"].ToString();
                product.productName = dr["productName"].ToString();
                product.kilo = int.Parse(dr["kilo"].ToString());
                product.price = int.Parse(dr["price"].ToString());

            }

            SqlConnection.Close();

            return product;

        }
    }
}
