using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

//OofGit main branch 1.4

namespace Pol
{
    public partial class Form1 : Form
    {


        BinaryFormatter formatter;


        public Form1()
        {
            InitializeComponent();
        }

        public bool IsProcessAlreadyRunning()
        {
            return Process.GetProcesses().Count(p => p.ProcessName.Contains(Assembly.GetExecutingAssembly().FullName.Split(',')[0]) && !p.Modules[0].FileName.Contains("vshost")) > 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (IsProcessAlreadyRunning())
                    {
                        MessageBox.Show("App is already running!" +
                            "\nPlease close the other window before opening a new one.", "App already running");

                        System.Windows.Forms.Application.Exit();
                    }
                }

                timePicker.Format = DateTimePickerFormat.Custom;
                timePicker.CustomFormat = "h tt";

                formatter = new BinaryFormatter();

                ckbShowOnlyFuture.Checked = false;

                datePicker.Value = DateTime.Today;

                Program.LoadLists();

                cmbEmployees.Items.AddRange(Program.employeeList.ToArray());



                PopulateList();

                timePicker.Text = "9:00:00AM";

                UpdateAvailabilityLabel();

            }
            catch (Exception exc) {}
        }

        //populate the whole list
        public void PopulateList()  //todo: streamline all of this list-building spaghetti - in here, AddResToList, and AddReservation especially
        {

            listView.Items.Clear();




            if (rdbSortByTime.Checked)
            {
                SortListByTime();

            }
            else if (rdbSortByRoom.Checked)
            {
                SortListByRoom();
            }





            if (ckbShowOnlyToday.Checked)
            {
                foreach (Reservation r in Program.reservationList)
                {
                    foreach (ListViewItem lvi in listView.Items)
                    {
                        if (lvi.Tag.Equals(r.GetTag()))
                        {
                            if (!(r.ResTime.Date == DateTime.Today.Date))
                            {
                                lvi.Remove();
                            }
                        }
                    }
                }

            }

            if (ckbShowOnlyFuture.Checked)
            {
                foreach (Reservation r in Program.reservationList)
                {
                    foreach (ListViewItem lvi in listView.Items)
                    {
                        if (lvi.Tag.Equals(r.GetTag()))
                        {
                            if (r.ResTime < DateTime.Now)
                            {
                                lvi.Remove();
                            }
                        }
                    }
                }

            }


            int numItems = listView.Items.Count;
            lblCount.Text = $"Showing {numItems, -2}";

            

        }

        //add each individual reservation 
        public void AddResToList(Reservation res)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = res.GetTag();
            item.SubItems.Add($"{res.ResTime.DayOfWeek}");
            item.SubItems.Add($"{res.ResTime.Month}/{res.ResTime.Day}/{res.ResTime.Year}");
            item.SubItems.Add($"{res.Room}");
            item.SubItems.Add($"{res.Guest}");
            item.SubItems.Add(string.Format("{0:h:mm tt}", res.ResTime));
            item.SubItems.Add($"{res.Employee}");
            item.SubItems.Add($"{res.Comments}");

            listView.Items.Add(item);

        }

        //helper method for add button here & at multiform
        public void AddReservation(int room, DateTime dateTime, string guest = "", string employee = "")
        {
            bool makeResBool = true;



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
            {
                Program.reservationList.Add(new Reservation(dateTime, room, guest, employee));

                PopulateList();

                Program.SaveLists();
            }
        }

        //add button==========================================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try //todo: better way to do the room # check than try/catch
            {
                 
                if (txtRoomNum.Text.Equals(""))
                {
                    //alert here?
                    throw new Exception("Error - Must include room #");
                }


                int room = int.Parse(txtRoomNum.Text);
                string guest = txtGuest.Text;
                DateTime dateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
                string employee = cmbEmployees.Text;

                AddReservation(room, dateTime, guest, employee);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            txtGuest.Clear();
            txtRoomNum.Clear();
            datePicker.Value = DateTime.Today;
            timePicker.Text = "9:00:00AM";
        }

        //sorting checkboxes
        public void SortListByRoom()
        {
            listView.Items.Clear();

            var reservationsByTime =
                from r in Program.reservationList
                orderby r.Room
                select r;

            foreach (var v in reservationsByTime)
            {
                Reservation res = v as Reservation;

                AddResToList(res);
            }
        }
        //sorting checkboxes
        public void SortListByTime()
        {
            listView.Items.Clear();

            var reservationsByTime =
                from r in Program.reservationList
                orderby r.ResTime
                select r;

            foreach (var v in reservationsByTime)
            {
                Reservation res = v as Reservation;

                AddResToList(res);
            }



        }


        //delete button==========================================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem i in listView.Items)
            {
                try
                {
                    if (i.Selected)
                    {
                        foreach (Reservation r in Program.reservationList)
                        {
                            if (i.Tag.Equals(r.GetTag()))
                            {

                                listView.Items.Remove(i);
                                Program.reservationList.Remove(r);
                                break;
                            }
                        }
                    }
                }
                catch (Exception exc)
                {
                    Console.Write($"error - {exc.Message}");
                }
            }

            Program.SaveLists();
        }

        private void rdbSortByTime_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void rdbSortByRoom_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.SaveLists();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Program.LoadLists();
            PopulateList();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();

            employeesForm.ShowDialog();

            //will hang until closed,

            cmbEmployees.Items.Clear();
            cmbEmployees.Items.AddRange(Program.employeeList.ToArray());

        }

        private void ckbToday_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count == 1)
            {
                CommentForm commentForm = new CommentForm();

                commentForm.ShowDialog();
            }
            //will hang until closed,


        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem v in listView.Items)
            {
                if (v.Selected)
                {
                    Program.selectedListItem = v;
                }

            }
        }

        private void ckbShowOnlyFuture_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                EditForm editForm = new EditForm();

                editForm.ShowDialog();
            }

            PopulateList();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            MultiForm multiForm = new MultiForm();
            multiForm.ShowDialog();

            PopulateList();
        }

        //todo: both these sloppy control/method names :
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            datePicker.Value = DateTime.Today;
        }
        //:
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            datePicker.Value = DateTime.Today.AddDays(1);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvailabilityLabel();

            if(datePicker.Value.Date.CompareTo(DateTime.Now.Date) == 0)
                linkLabel1.LinkVisited = true;
            else
                linkLabel1.LinkVisited = false;

            if (datePicker.Value.Date.CompareTo(DateTime.Now.Date.AddDays(1)) == 0)
                linkLabel2.LinkVisited = true;
            else
                linkLabel2.LinkVisited = false;

        }
        public void UpdateAvailabilityLabel()
        {
            try
            {
                if (Program.IsExistingDuplicateReservation(new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second)))
                {
                    lblAvailable.Visible = false;
                    lblUnavailable.Visible = true;
                }
                else
                {
                    lblAvailable.Visible = true;
                    lblUnavailable.Visible = false;
                }
            }catch(Exception e)
            {

            }
        }
        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvailabilityLabel();
        }

        
    }
}
