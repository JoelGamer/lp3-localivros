using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLP3
{
    public partial class FrmAbout : Form
    {
        readonly FrmMainMenu frmMainMenu;

        public FrmAbout(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;
        }

        private void FrmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.setIsAboutOpen(false);
        }
    }
}
