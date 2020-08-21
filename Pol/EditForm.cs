using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        Reservation res;
        ListViewItem item;
        private void EditForm_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "h tt";

            item = Program.selectedListItem;
            foreach (Reservation r in Program.reservationList)
            {
                if (r.GetTag().Equals(item.Tag))
                {
                    res = r;
                    break;
                }
            }

            txtRoomNum.Text = res.Room.ToString();
            txtGuest.Text = res.Guest;
            datePicker.Text = res.ResTime.Date.ToString();
            timePicker.Text = res.ResTime.TimeOfDay.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int room = int.Parse(txtRoomNum.Text);

            string guest = txtGuest.Text;

            DateTime dateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);

            res.Room = room;
            res.Guest = guest;
            res.ResTime = dateTime;

            Program.SaveLists();

            this.Close();
            this.Dispose();

        }
    }
}
