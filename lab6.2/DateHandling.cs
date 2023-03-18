using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Coded by Kathleen Forgiarini da Silva
// 2023-03-18
// Lab 6.2 - Working with dates and times (struct)


namespace lab6._2
{
    public partial class DateHandling : Form
    {
        public DateHandling()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today; 
            DateTime dueDate;
            DateTime.TryParse(textBox1.Text, out dueDate);
            TimeSpan timeTillDue = dueDate.Subtract(currentDate); 
            int daysTillDue = timeTillDue.Days;
            if (daysTillDue > 0)
            {
                MessageBox.Show("Current date: \t" + currentDate.ToShortDateString() +
                                "\nFuture date: \t" + dueDate.ToShortDateString() +
                                "\nDays until due: \t" + daysTillDue, "Due Days Calculation");
            }
            else if (daysTillDue == 0)
            {
                MessageBox.Show("It is today!", "Due Days Calculation");
            }
            else
            {
                MessageBox.Show("Day already passed", "Due Days Calculation");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime birthDate;
            DateTime.TryParse(textBox2.Text, out birthDate);
            var age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month)
            {
                age--;
            }
            else if (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day)
            {
                age--;
            }

            if (currentDate == birthDate)
            {
                MessageBox.Show("Happy Birthday!");
            } 
            else if (age < 0)
            {
                MessageBox.Show("Not born yet", "Age Calculation");
            }
            else
            {
                MessageBox.Show("Current Date: \t" + currentDate.ToLongDateString() +
                                "\nBirth Date: \t" + birthDate.ToLongDateString() +
                                "\nAge: \t\t" + age.ToString(), "Age Calculation");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye bye!");
            this.Close();
        }
    }
}
