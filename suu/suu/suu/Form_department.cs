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
    public partial class Form_department : Form
    {
        public Form_department()
        {
            InitializeComponent();
        }

        private void Form_department_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.suuDataSet.department);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.departmentTableAdapter.Update(this.suuDataSet.department);
        }
    }
}
