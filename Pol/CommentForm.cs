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
    public partial class CommentForm : Form
    {
        public CommentForm()
        {
            InitializeComponent();
        }

        public string Comment { get; set; }

        ListViewItem item;
        Reservation res;

        private void CommentForm_Load(object sender, EventArgs e)
        {
            item = Program.selectedListItem;
            foreach(Reservation r in Program.reservationList)
            {
                if(r.GetTag().Equals(item.Tag))
                {
                    res = r;
                    break;
                }
            }

            Comment = res.Comments;

            txtComment.Text = Comment;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string comment = txtComment.Text;

            this.Close();
            this.Dispose();

            res.Comments = comment;
            item.SubItems[7].Text = comment;

        }
    }
}
