using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol
{
    public partial class MultiForm : Form
    {
        List<DateTimePicker> timePickerList;

        public MultiForm()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void datePicker1_ValueChanged(object sender, EventArgs e) => DrawTimes();

        private void datePicker2_ValueChanged(object sender, EventArgs e) => DrawTimes();

        //time picker format:
        //timePicker.Format = DateTimePickerFormat.Custom;
        //timePicker.CustomFormat = "h tt";

        private async void DrawTimes()
        {


            //should async this?
           
            DateTime date1 = datePicker1.Value.Date;
            DateTime date2 = datePicker2.Value.Date;

             //need error checking on this date subtract
            int rows = date2.Subtract(date1).Days + 1;

            
            timePickerList = new List<DateTimePicker>();
            timePickerList.Clear();
            pnlTimes.Controls.Clear();


            pnlTimes.RowCount = rows;

        //    if (rows > 7)
         //       lblPleaseWait.Visible = true;
           
            for (int i = 0; i < rows; i++)
            {
                DateTime currentDay = date1.AddDays(i);
                pnlTimes.Controls.Add(new Label() { Text = $"{currentDay.DayOfWeek}" }, 0, i);
                pnlTimes.Controls.Add(new Label() { Text = $"{currentDay.Month}/{currentDay.Day}/{currentDay.Year}" }, 1, i);
                timePickerList.Add(new DateTimePicker() { Width = 90, Format = DateTimePickerFormat.Custom, ShowUpDown = true, CustomFormat = "h tt", Text = "9:00:00AM" });


            }

            for (int i = 0; i < rows; i++)
                pnlTimes.Controls.Add(timePickerList[i]);



        //    lblPleaseWait.Visible = false;
        }



        private void MultiForm_Load_1(object sender, EventArgs e)
        {
            DrawTimes();
            setAllTimePicker.Format = DateTimePickerFormat.Custom;
            setAllTimePicker.CustomFormat = "h tt";
            setAllTimePicker.Text = "9:00:00AM";

        }

        private void btnSetAll_Click(object sender, EventArgs e)
        {
            foreach(var v in timePickerList)
            {
                v.Text = setAllTimePicker.Text;

            }
        }
    }
}
