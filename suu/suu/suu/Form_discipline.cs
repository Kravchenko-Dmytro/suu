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
    public partial class Form_discipline : Form
    {
        public Form_discipline()
        {
            InitializeComponent();
        }

        private void Form_discipline_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.suuDataSet.disciplines);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.disciplinesTableAdapter.Update(this.suuDataSet.disciplines);
        }
    }
}
