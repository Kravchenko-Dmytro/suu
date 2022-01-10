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
    public partial class Form_faculty : Form
    {
        public Form_faculty()
        {
            InitializeComponent();
        }

        private void Form_faculty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.suuDataSet.faculty);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.facultyTableAdapter.Update(this.suuDataSet.faculty);
        }
    }
}
