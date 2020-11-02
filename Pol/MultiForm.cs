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

        private void DrawTimes()
        {



            pnlTimes.Controls.Clear();
            DateTime date1 = datePicker1.Value.Date;
            DateTime date2 = datePicker2.Value.Date;

            //need error checking on this date subtract
            int rows = date2.Subtract(date1).Days + 1;

            pnlTimes.RowCount = rows;



            for (int i = 0; i < rows; i++)
            {
                DateTime currentDay = date1.AddDays(i);

                pnlTimes.Controls.Add(new Label() { Text = $"{currentDay.DayOfWeek}" });
                pnlTimes.Controls.Add(new Label() { Text = $"{currentDay.Month}/{currentDay.Day}/{currentDay.Year}" });

                pnlTimes.Controls.Add(new DateTimePicker() { Format = DateTimePickerFormat.Custom, ShowUpDown = true, CustomFormat = "h tt", Text = "9:00:00AM" });


            }
        }

        private void MultiForm_Load(object sender, EventArgs e)
        {

            setAllTimePicker.Format = DateTimePickerFormat.Custom;
            setAllTimePicker.CustomFormat = "h tt";

            DrawTimes();
        }

    }
}
