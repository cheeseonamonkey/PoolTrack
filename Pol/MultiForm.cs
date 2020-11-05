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
        List<DateTime> datesList;
        public MultiForm()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                List<Reservation> reservationsToAdd = new List<Reservation>();
                //      reservationsToAdd.Clear();


                for (int i = 0; i < timePickerList.Count; i++)
                {
                    bool makeResBool = false;

                    int room = int.Parse(txtRoomNum.Text);
                    string guest = txtGuest.Text;
                    int h = timePickerList[i].Value.Hour, m = timePickerList[i].Value.Minute, s = timePickerList[i].Value.Second;

                    DateTime dateTime = new DateTime(datesList[i].Year, datesList[i].Month, datesList[i].Day, h, m, s);
                    string employee = cmbEmployees.Text;

                    if (Program.IsExistingDuplicateReservation(dateTime))
                    {
                        DialogResult dialogResult = MessageBox.Show($"One or more reservations already exist at this time:\n" +
                            $"\tRoom #{room}\n" +
                            $"\tReserved at {dateTime.TimeOfDay}\n" +
                            "\nDo you want to make the reservation anyway?", "Duplicate Reservation!", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                            makeResBool = true;

                        else if (dialogResult == DialogResult.No)
                            makeResBool = false;

                    }



                    if (makeResBool)
                        reservationsToAdd.Add(new Reservation(dateTime, room, guest, employee));
                }




                if (txtRoomNum.Text.Equals(""))
                {
                    //alert here?
                    throw new Exception("Error - Must include room #");
                }





                foreach (var v in reservationsToAdd)
                {
                    Program.reservationList.Add(v);
                }

                Program.SaveLists();

                this.Close();
                this.Dispose();

            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        private void datePicker1_ValueChanged(object sender, EventArgs e) => DrawTimes();

        private void datePicker2_ValueChanged(object sender, EventArgs e) => DrawTimes();

        //time picker format:
        //timePicker.Format = DateTimePickerFormat.Custom;
        //timePicker.CustomFormat = "h tt";

        private void DrawTimes()
        {


            //should async this?

            DateTime date1 = datePicker1.Value.Date;
            DateTime date2 = datePicker2.Value.Date;

          
            int rows = date2.Subtract(date1).Days + 1;


            timePickerList = new List<DateTimePicker>();
            timePickerList.Clear();
            datesList = new List<DateTime>();
            datesList.Clear();

            pnlTimes.Controls.Clear();


            if (date2.CompareTo(date1) < 0)
            {

            }
            else
            {

                pnlTimes.RowCount = rows;

                //    if (rows > 7)
                //       lblPleaseWait.Visible = true;

                for (int i = 0; i < rows; i++)
                {
                    DateTime currentDay = date1.AddDays(i);
                    datesList.Add(new DateTime(currentDay.Year, currentDay.Month, currentDay.Day));
                    pnlTimes.Controls.Add(new Label() { Text = $"{currentDay.DayOfWeek}" }, 0, i);
                    pnlTimes.Controls.Add(new Label() { Text = $"{currentDay.Month}/{currentDay.Day}/{currentDay.Year}" }, 1, i);
                    timePickerList.Add(new DateTimePicker() { Width = 90, Format = DateTimePickerFormat.Custom, ShowUpDown = true, CustomFormat = "h tt", Text = "9:00:00AM" });
                    pnlTimes.Controls.Add(timePickerList[i]);
                    pnlTimes.Controls.Add(new Label() { Text = "" });


                }






                //    lblPleaseWait.Visible = false;
            }
        }



        private void MultiForm_Load_1(object sender, EventArgs e)
        {
            DrawTimes();
            setAllTimePicker.Format = DateTimePickerFormat.Custom;
            setAllTimePicker.CustomFormat = "h tt";
            setAllTimePicker.Text = "9:00:00AM";

            cmbEmployees.Items.AddRange(Program.employeeList.ToArray());

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
