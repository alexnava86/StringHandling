using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            char delim = '@';
            if (txtEmail.Text.Contains('@'))
            {
                string emAddressRaw = txtEmail.Text.Trim();
                string[] emAddress = emAddressRaw.Split(delim);
                //int ix = txtEmail.Text.IndexOf(delim, 0);
                string userName = emAddress[0];
                string domainName = string.Empty;
                foreach(string s in emAddress)
                {
                    if (s != emAddress[0])
                    {
                        domainName += s;
                    }
                }
                MessageBox.Show("User Name: " + userName + "\nDomain Name: " + domainName, "Parsed String", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("Email address must contain an '@' character.");
            }
            /*
            Add code to parse the email address into two parts 
            when the user clicks the Parse button: the user name 
            before the @ sign and the domain name after the @ sign. 
            Be to check that the email contains an @ sign before 
            you parse it, and display an error message if it doesn’t. 
            Also, be sure to remove any leading or trailing spaces 
            that the user enters. Test the application with both 
            valid and invalid email addresses to be sure it works 
            correctly.
             */
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string info = string.Empty;

            info = txtCity.Text;
            info = info.Insert(info.Length, ", ");
            info += txtState.Text.ToUpper();
            info = info.Insert(info.Length, " ");
            info += txtZipCode.Text;

            MessageBox.Show(info, "Formatted String", MessageBoxButtons.OK);
            /*Add code to format the city, state, and zip code when 
            the user clicks the Format button. To do that, create 
            a string that contains the city, state, and zip code and
            then use the Insert method to insert the appropriate characters. 
            Be sure that the two-character state code is in uppercase. 
            (You can assume that the user enters appropriate data in each text box.) 
            Display the results in a message box like the second one shown above.
            Test the application to be sure it formats the city, state, 
            and zip code correctly.
             */
        }
    }
}
