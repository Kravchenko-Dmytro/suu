using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suu
{
    public partial class Form_groups : Form
    {
        public Form_groups()
        {
            InitializeComponent();
        }

        private void Form_groups_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.suuDataSet.groups);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Update(this.suuDataSet.groups);
        }
    }
}
