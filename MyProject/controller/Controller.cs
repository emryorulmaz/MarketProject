using MyProject.dao;
using MyProject.enumaration;
using MyProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.controller
{


    public class Controller
    {
        Repository repository;

        public Controller()
        {
            repository = new Repository();
        }

        public User Login(string username, string password)
        {

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                User result = repository.Login(username, password);
                
                return result;
            }
            else
            {
                User user  = new User();
                user.status = LoginStatus.UnSuccessful;
                return user;
            }

        }

        public LoginStatus ChangePassword(string username,string password)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(username))
            {
                return repository.ChangePassword(username,password);
            }
            else { return LoginStatus.MissingParameter; }
        }

        public List<LoginTable> GetLoginTable()
        {
            List<LoginTable> loginTables = repository.GetLoginTable();
            return loginTables;

        }

        public LoginStatus AddProduct(Product product)
        {
            if(!string.IsNullOrEmpty(product.productName) && !string.IsNullOrEmpty(product.barcodeNumber) && !string.IsNullOrEmpty(product.kilo.ToString()) && !string.IsNullOrEmpty(product.price.ToString()))
            {
                return repository.AddProduct(product);
            }
            else
            {
                return LoginStatus.MissingParameter;
            }
        }

        public LoginStatus UpdateProduct(Product product)
        {
            if (!string.IsNullOrEmpty(product.productName) && !string.IsNullOrEmpty(product.barcodeNumber) && !string.IsNullOrEmpty(product.kilo.ToString()) && !string.IsNullOrEmpty(product.price.ToString()))
            {
                return repository.UpdateProduct(product);
            }
            else
            {
                return LoginStatus.MissingParameter;
            }
        }


        public LoginStatus DeleteProduct(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.DeleteProduct(id);
            }
            else
            {
                return LoginStatus.MissingParameter;
            }
        }

        public List<LoginTable> BringOnlySecurityQuestions()
        {
            List<LoginTable> loginTables = repository.BringOnlySecurityQuestions();
            return loginTables;

        }

        public List<Product> BringAllProducts()
        {
            List<Product> products = repository.BringAllProdcuts();
            return products;
        }


        public Product GetProduct(string barcodeNumber)
        {
            if (!string.IsNullOrEmpty(barcodeNumber))
            {
                return repository.GetProduct(barcodeNumber);
            }
            else
            {
                return null;
            }
        }

        public LoginStatus UpdateUser(User user)
        {
            LoginStatus result = repository.UpdateUser(user);
            return result;

        }

        public LoginStatus DeleteUser(int id)
        {
            LoginStatus result = repository.DeleteUser(id);
            return result;

        }


        public LoginStatus AddUser(User user)
        {
            if(!string.IsNullOrEmpty(user.userName)&& !string.IsNullOrEmpty(user.password) && !string.IsNullOrEmpty(user.emailAdress) && !string.IsNullOrEmpty(user.authority) && !string.IsNullOrEmpty(user.securityQuestion) && !string.IsNullOrEmpty(user.securityAnswer))
            {
                LoginStatus result = repository.AddUser(user);
                return result;
                
            }
            else
            {
                return LoginStatus.MissingParameter;
            }
        }

        public LoginStatus Authorize(string username, string securityAnswer, string securityQuestion)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(securityAnswer) && !string.IsNullOrEmpty(securityQuestion))
            {
               LoginStatus result = repository.Authorize(username, securityAnswer, securityQuestion);

                if(result == LoginStatus.Successful)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.UnSuccessful;
                }

            }

            else
            {
                return LoginStatus.MissingParameter;
            }
        }

    }
}