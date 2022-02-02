using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public List<string> Passwords = new List<string>();
        BindingSource PasswordBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txtbx_password.Text == "")
            {
                MessageBox.Show("Why? Why are you trying to add nothing as a password?");
                MessageBox.Show("Are you an....");
                MessageBox.Show("Idiot?");
                return;
            }


            Passwords.Add(txtbx_password.Text);
         
            
            PasswordBindingSource.ResetBindings(false);
        }

        private void btn_password_gen_Click(object sender, EventArgs e)
        {

            var rand = new Random();
            bool numbers, specials, lowers, uppers;
            
            try
            {
                Convert.ToInt32(txtbx_length.Text);
                Convert.ToInt32(txtbx_numbers.Text);
                Convert.ToInt32(txt_box_special_characters.Text);
                Convert.ToInt32(txtbx_capital_letters.Text);
                Convert.ToInt32(txtbx_lowercase_letters.Text);
            }
            catch
            {
                MessageBox.Show("Enter a whole number... idiot...");
                return;
            }
            
            
            numbers = chkbx_numbers.Checked;
            specials = chkbx_special_characters.Checked;
            lowers = chkbx_lowercase_letters.Checked;
            uppers = chkbx_capital_letters.Checked;
            if(!numbers && !specials && !lowers && !uppers)
            {
                //MessageBox.Show(Convert.ToString(Convert.ToChar(33)));
                MessageBox.Show("You must check at least one of the boxes.... Idiot...");
                return;
            }
            int min; 
            int max = 0;
            if (lowers) { min = 97; max = 122; }
            if (uppers) { min = 65; max = Math.Max(max ,90); }
            int numsInt = Convert.ToInt32(txtbx_numbers.Text);
            int capsInt= Convert.ToInt32(txtbx_capital_letters.Text);
            int lowersInt = Convert.ToInt32(txtbx_lowercase_letters.Text);
            int specsInt = Convert.ToInt32(txt_box_special_characters.Text);
            int length = 0;
            int count = 0;
            
            if (numbers)
            {
                length += numsInt;
            }
            if (specials)
            {
                length += specsInt;
            }
            if (lowers) 
            {
                length += lowersInt;
            }
            if (uppers)
            {
                length += capsInt;
            }
            txtbx_length.Text = Convert.ToString(length);
            char[] passArra = new char[length];

            
            int lowersCount = 0;
            int uppersCount = 0;
            int specsCount = 0;
            int numbersCount = 0;

            while (length > count)
            {
                bool left = false;
                if (lowers && lowersCount < lowersInt)
                {
                    passArra[count] = Convert.ToChar(rand.Next(97, 122));
                    count++;
                    lowersCount++;
                }

                if (uppers && uppersCount < capsInt)
                {
                    passArra[count] = Convert.ToChar(rand.Next(65, 90));
                    count++;
                    uppersCount++;
                }
                if(specials && specsCount < specsInt)
                {
                    
                    if (left)
                    {
                        passArra[count] = Convert.ToChar(rand.Next(33, 38));
                        while (passArra[count] == '"')
                            passArra[count] = Convert.ToChar(rand.Next(33, 38));
                        specsCount++;
                    }

                    if (!left)
                    {
                        passArra[count] = Convert.ToChar(rand.Next(60, 64));
                        specsCount++;
                    }
                        
                    left = !left;
                    count++;
                    
                }
                if(numbers && numbersCount < numsInt)
                {
                    passArra[count] = Convert.ToChar(rand.Next(48, 57));
                    numbersCount++;
                    count++;
                }

            }

            for (int index = 0; index < length; index++)
            {
                int randomIndex = rand.Next(0, length);
                char temp = passArra[index];
                passArra[index] = passArra[randomIndex];
                passArra[randomIndex] = temp;
            }

           
            

            txtbx_password.Text = String.Join("", passArra);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordBindingSource.DataSource = Passwords;


            lst_passwords.DataSource = PasswordBindingSource;
            lst_passwords.DisplayMember = ToString();

            
        }
    }
}
