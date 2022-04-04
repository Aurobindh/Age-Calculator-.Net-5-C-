using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime dob = new DateTime(dateTimePicker1.Value.Year,
                                    dateTimePicker1.Value.Month,
                                    dateTimePicker1.Value.Day);
            DateTime today = new DateTime(DateTime.Today.Year,
                                        DateTime.Today.Month,
                                        DateTime.Today.Day);
            string diff = (today - dob).TotalDays.ToString();
            int totaldays = Convert.ToInt32(diff);
            int year = totaldays / 365;
            int remainingdays = totaldays % 365;
            int months = Convert.ToInt32(remainingdays / 30.41);
            remainingdays = remainingdays % 30;
            label1.Text = year.ToString()+" year's "+months.ToString()+
                          " month's and "+remainingdays+" day's old";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
    }
}
