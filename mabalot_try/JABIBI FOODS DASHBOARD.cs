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

        public JABIBI_FOODS_DASHBOARD()
        {
            InitializeComponent();

            // Log out is the only control that takes focus; without this it opens focused and Enter would log out.
            Shown += (s, e) => ActiveControl = null;
        }

        // Shows the signed in account in the sidebar footer. A name too long for the footer is cut
        // by character before the Log out button, and the whole name shows as a tooltip.
        public JABIBI_FOODS_DASHBOARD(string fullName, string role) : this()
        {
            label40.Text = FitToWidth(fullName, label40.Font, label40.Width);
            label41.Text = role;

            if (label40.Text != fullName)
            {
                if (components == null) components = new Container();
                new ToolTip(components).SetToolTip(label40, fullName);
            }
        }

        private static string FitToWidth(string text, Font font, int width)
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

        private void label7_Click(object sender, EventArgs e)
        {
            Jabibi_New_Item item = new Jabibi_New_Item();
            // Bring the dashboard back when the new item form closes, instead of leaving it hidden.
            item.FormClosed += (s, args) => this.Show();
            item.Show();
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
