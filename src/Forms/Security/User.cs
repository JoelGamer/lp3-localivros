using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLP3.Forms.Security
{
    public partial class FrmUser : Form
    {
        private readonly FrmMainMenu frmMainMenu;

        public FrmUser(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }

        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }
    }
}
