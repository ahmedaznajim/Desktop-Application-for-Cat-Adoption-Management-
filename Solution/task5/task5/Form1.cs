using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application For Adopt Cats :)","About Us",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categ.SelectedIndex != -1 && color.SelectedIndex != -1 &&
               Agetype.SelectedIndex != -1 && type.SelectedIndex != -1 &&
               (male.Checked != false || female.Checked != false))
            {
                next1.Enabled = true;
            }
            else
                next1.Enabled = false;

            if (categ.SelectedIndex == 0)
            {
                color.Items.Clear();
                color.Items.Add("White");
                color.Items.Add("Black");
                color.Items.Add("Cream");
                color.Items.Add("Cinnamon");

            }
            else if (categ.SelectedIndex == 1)
            {
                color.Items.Clear();
                color.Items.Add("Blue Point");
                color.Items.Add("Chocolate Point");
                color.Items.Add("Lilac Point");
            }
            else
            {
                color.Items.Clear();
                color.Items.Add("Colors and Patterns Vary");
            }
        }

        private void Agetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categ.SelectedIndex != -1 && color.SelectedIndex != -1 &&
                Agetype.SelectedIndex != -1 && type.SelectedIndex != -1 &&
                (male.Checked != false || female.Checked != false))
            {
                next1.Enabled = true;
            }
            else
                next1.Enabled = false;

            if (Agetype.SelectedIndex == 0)
            {
                type.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    type.Items.Add(i.ToString() + "  Day");
                }
            }
            else
            {
                type.Items.Clear();
                for (int i = 1; i < 6; i++)
                {
                    type.Items.Add(i.ToString() + "  Month");
                }
            }
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categ.SelectedIndex != -1 && color.SelectedIndex != -1 &&
                Agetype.SelectedIndex != -1 && type.SelectedIndex != -1 &&
                (male.Checked != false || female.Checked != false))
            {
                next1.Enabled = true;
            }
            else
                next1.Enabled = false;
            label11.Visible = true;
            label13.Visible = false;
            if (categ.SelectedIndex == 0)
            {
                if (color.SelectedIndex == 0)
                    pictureBox1.Image = task5.Properties.Resources.cat_1;
                else if (color.SelectedIndex == 1)
                    pictureBox1.Image = task5.Properties.Resources.cat_2;
                else if (color.SelectedIndex == 2)
                    pictureBox1.Image = task5.Properties.Resources.cat_3;
                else if (color.SelectedIndex == 3)
                    pictureBox1.Image = task5.Properties.Resources.cat_4;
            }
            else if (categ.SelectedIndex == 1)
            {
                if (color.SelectedIndex == 0)
                    pictureBox1.Image = task5.Properties.Resources.cat_5;
                else if (color.SelectedIndex == 1)
                    pictureBox1.Image = task5.Properties.Resources.cat_6;
                else if (color.SelectedIndex == 2)
                    pictureBox1.Image = task5.Properties.Resources.cat_7;
            }
            else if (categ.SelectedIndex == 2)
                if (color.SelectedIndex == 0)
                    pictureBox1.Image = task5.Properties.Resources.cat_8;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categ.SelectedIndex != -1 && color.SelectedIndex != -1 &&
                Agetype.SelectedIndex != -1 && type.SelectedIndex != -1 &&
                (male.Checked != false || female.Checked != false))
            {
                next1.Enabled = true;
            }
            else
                next1.Enabled = false;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (categ.SelectedIndex != -1 && color.SelectedIndex != -1 &&
                Agetype.SelectedIndex != -1 && type.SelectedIndex != -1 &&
                (male.Checked != false || female.Checked != false))
            {
                next1.Enabled = true;
            }
            else
                next1.Enabled = false;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (categ.SelectedIndex != -1 && color.SelectedIndex != -1 &&
                Agetype.SelectedIndex != -1 && type.SelectedIndex != -1 &&
                (male.Checked != false || female.Checked != false))
            {
                next1.Enabled = true;
            }
            else
                next1.Enabled = false;
        }

        private void next1_Click(object sender, EventArgs e)
        {
            personal.Enabled = true;
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            string name=fname.Text;
            try
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
                    { }
                    else
                        throw new Exception ("pleaze enter just letters");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            if (fname.Text != "" && lname.Text != "0" &&
                phone.Text != "" && address.Text != "")
            {
                next2.Enabled = true;
            }
            else
                next2.Enabled = false;
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            string name = lname.Text;
            try
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
                    { }
                    else
                        throw new Exception("pleaze enter just letters");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            if (fname.Text != "" && lname.Text != "0" &&
                phone.Text != "" && address.Text != "")
            {
                next2.Enabled = true;
            }
            else
                next2.Enabled = false;
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            string num = phone.Text;
            try
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] >= '0' && num[i] <= '9')
                    { }
                    else
                        throw new Exception("pleaze enter just a number");

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            if (fname.Text != "" && lname.Text != "0" &&
                phone.Text != "" && address.Text != "")
            {
                next2.Enabled = true;
            }
            else
                next2.Enabled = false;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            string name = lname.Text;
            try
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
                    { }
                    else
                        throw new Exception("pleaze enter just letters");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            if (fname.Text != "" && lname.Text != "0" &&
                phone.Text != "" && address.Text != "")
            {
                next2.Enabled = true;
            }
            else
                next2.Enabled = false;
        }

        private void next2_Click(object sender, EventArgs e)
        {
            string x = "",
               y = "";
            if (male.Checked == true)
            {
                x = male.Text;
            }
            else
                x = female.Text;

            if (richTextBox1.Text == "")
            {
                y = "There are no additional notes ...";
            }
            else
                y = $"{richTextBox1.Text}";
            view.Text = $"\t\t   Cat Details\n__________________________________________\n" +
                $"Cat Category : {categ.Text}\nCat Color : {color.Text}\nCat Age : " +
                $"{type.Text}\nCat Gender : {x}\nAdditional Notes : {y}\n\n\n\t\t" +
                $"Personal Details\n__________________________________________\n" +
                $"Full Name : {fname.Text} {lname.Text}\nAddress : {address.Text}" +
                $"\nPhone Number : {phone.Text}\nOrder Date : " +
                $"{dateTimePicker1.Value.ToShortDateString()}";
            confirm.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader reader= new StreamReader(openFileDialog1.FileName);
                string line = reader.ReadToEnd();
                view.Text=line;
                reader.Close();
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string text = view.Text;
                StreamWriter writer= new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(text);
                writer.Close();
            }
        }
        int counter =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string text1 = "A group of cats is called a clowder," +
                " a male cat is called a tom, a female cat is called a" +
                " molly or queen while young cats are called kittens.";
            string text2 = "Cats have powerful night vision, allowing" +
                " them to see at light levels six times lower than" +
                " what a human need in order to see.";
            string text3 = "Cats also have excellent hearing" +
                " and a powerful sense of smell.";
            string text4 = "Older cats can at times act aggressively towards kittens.";
            switch ((counter % 4) + 1)
            {
                case 1:
                    richTextBox2.Text = $"{text1}";
                    counter++;
                    break;
                case 2:
                    richTextBox2.Text = $"{text2}";
                    counter++;
                    break;
                case 3:
                    richTextBox2.Text = $"{text3}";
                    counter++;
                    break;
                case 4:
                    richTextBox2.Text = $"{text4}";
                    counter++;
                    break;
            }
        }

        private void view_TextChanged(object sender, EventArgs e)
        {
            confirm.Enabled = true;
        }

    }
}
