using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mabalot_try
{
    public partial class JABIBI_FOODS_DASHBOARD : Form
    {
        // True when the dashboard closed through Log out, so the log in form shows again.
        public bool LoggedOut { get; private set; }

        // The signed in account, handed on to the Items and Users pages for their sidebar footers.
        // The Users page reads the username so that account can never be deleted or turned off.
        private readonly string fullName = "";
        private readonly string role = "";
        private readonly string username = "";

        public JABIBI_FOODS_DASHBOARD()
        {
            InitializeComponent();

            // Log out is the only control that takes focus; without this it opens focused and Enter would log out.
            Shown += (s, e) => ActiveControl = null;
        }

        // Shows the signed in account in the sidebar footer. A name too long for the footer is cut
        // by character before the Log out button, and the whole name shows as a tooltip.
        public JABIBI_FOODS_DASHBOARD(string fullName, string role) : this(fullName, role, "")
        {
        }

        public JABIBI_FOODS_DASHBOARD(string fullName, string role, string username) : this()
        {
            this.fullName = fullName;
            this.role = role;
            this.username = username;

            label40.Text = FitToWidth(fullName, label40.Font, label40.Width);
            label41.Text = role;

            if (label40.Text != fullName)
            {
                if (components == null) components = new Container();
                new ToolTip(components).SetToolTip(label40, fullName);
            }
        }

        internal static string FitToWidth(string text, Font font, int width)
        {
            if (TextRenderer.MeasureText(text, font).Width <= width)
                return text;

            for (int length = text.Length - 1; length > 0; length--)
            {
                string cut = text.Substring(0, length).TrimEnd() + "…";
                if (TextRenderer.MeasureText(cut, font).Width <= width)
                    return cut;
            }

            return "…";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Log out of Jabibi Inventory?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoggedOut = true;
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Items in the sidebar
        private void label7_Click(object sender, EventArgs e)
        {
            OpenPage("Items", this.Location);
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            OpenPage("Users", this.Location);
        }

        // Opens a sidebar page where this window is and hides the dashboard. When the page closes,
        // it names the next page to open, or none, which brings the dashboard back instead of
        // leaving it hidden.
        private void OpenPage(string page, Point location)
        {
            Form form;

            if (page == "Users")
                form = new UsersForm(fullName, role, username);
            else
                form = new ItemsForm(fullName, role);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = location;
            form.FormClosed += (s, args) =>
            {
                Form closed = (Form)s;
                string next = ((ISidebarPage)closed).NextPage;

                if (next == "LogOut")
                {
                    // Log out pressed on the page: close the dashboard the same way its own Log out does.
                    LoggedOut = true;
                    this.Close();
                }
                else if (next != null)
                    OpenPage(next, closed.Location);
                else
                    this.Show();
            };
            form.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }
    }
}
