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
    public partial class Form_students : Form
    {
        public Form_students()
        {
            InitializeComponent();
        }

        private void Form_students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.suuDataSet.students);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.suuDataSet.students);
        }
    }
}
