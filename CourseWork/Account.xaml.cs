﻿using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Security.Cryptography;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace wpfAibrahimW1680174
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        //Log in
        String Username;
        String Password;


        //SignUp
        String CreateName;
        String CreateUsername;
        String CreatePassword;
        String encryptedPassword;

        public Account()
        {
            InitializeComponent();
        }

        // When the user wants to create an account, this will run 
        private void CreateAccountPressed(object sender, RoutedEventArgs e)
        {
            // Check if fields are empty 
            Console.WriteLine("TEST TO SEE WHERE THIS GO ");
            if (CreateNameBox == null || CreateUserNameBox == null || CreatePasswordBox == null || ConfirmPasswordBox == null)
            {
                // Error code as field is empty
                // Have diffent error message for each 
                Console.WriteLine("Fields are empty");

                // Confirms if both passwords match 
            } if (CreatePasswordBox != ConfirmPasswordBox)
            {
                // Password don't match
            }
            else
            {
                Console.WriteLine("Fields are NOT empty and password match");

                //Store details entered
                CreateName = CreateNameBox.Text;
                CreateUsername = CreateUserNameBox.Text;
                CreatePassword = CreatePasswordBox.Text;


                // Encrept the user's password 

                //Create an account for the user 


                // Save User details 
            }
        }

        // When user wants to log into their account 
        private void loginPressed(object sender, RoutedEventArgs e)
        {
            // Verify the details entered

            Username = LogUserName.Text;
            Password = LogPassword.Text;

            // Check with database if details match
            
            // Take user to their home page 
            Uri TakeToHome = new Uri("HomePage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(TakeToHome);
            

        }

        //If User forgets their password
        private void ForgotPasswordPressed(object sender, RoutedEventArgs e)
        {
            // Show a different web page, whereby the user can reset their password
            //Once completed take user back to this page, to log in.
        }
    }
}
