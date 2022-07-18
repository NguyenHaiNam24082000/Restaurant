using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Classes;

namespace Restaurant.Forms
{
    public partial class FormPanelDoiTac : Form
    {
        ConnectDataBase cnDB = new ConnectDataBase();
        public FormPanelDoiTac()
        {
            InitializeComponent();
        }

        private void FormPanelDoiTac_Load(object sender, EventArgs e)
        {
            DataTable doitac = cnDB.readData("select * from NhaCungCap");
            dgvDoiTac.DataSource = doitac;
        }
    }
}
