using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            // Form styling
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            // MenuStrip styling
            MainMenuStrip.Renderer = new ModernMenuRenderer();
            MainMenuStrip.Padding = new Padding(10, 5, 10, 5);
            MainMenuStrip.BackColor = Color.FromArgb(45, 50, 80);

            // Style each menu item
            foreach (ToolStripMenuItem item in MainMenuStrip.Items)
            {
                StyleMenuItem(item);
            }
        }

        private void StyleMenuItem(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            item.Padding = new Padding(15, 5, 15, 5);
            item.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // Add hover effect via event handlers
            item.MouseEnter += (s, e) => {
                item.ForeColor = Color.FromArgb(255, 207, 84);
                item.BackColor = Color.FromArgb(65, 70, 100);
            };

            item.MouseLeave += (s, e) => {
                item.ForeColor = Color.White;
                item.BackColor = Color.FromArgb(45, 50, 80);
            };
        }

        private void peopleMenuStripItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStripPeopleItem_Click(object sender, EventArgs e)
        {
            ManagePeopleForm peopleFrm = new ManagePeopleForm();
            peopleFrm.ShowDialog();
        }
    }

    // Custom renderer for modern menu style
    public class ModernMenuRenderer : ToolStripProfessionalRenderer
    {
        public ModernMenuRenderer() : base(new ModernColors())
        {
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Add a slight shadow to the text
            if (e.Item.Selected)
            {
                e.TextColor = Color.FromArgb(255, 207, 84);
                base.OnRenderItemText(e);
            }
            else
            {
                base.OnRenderItemText(e);
            }
        }
    }

    // Custom color scheme for menu
    public class ModernColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(65, 70, 100);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(65, 70, 100);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(65, 70, 100);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(65, 70, 100);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(65, 70, 100);
        public override Color MenuBorder => Color.FromArgb(45, 50, 80);
        public override Color MenuItemBorder => Color.Transparent;
    }
}
