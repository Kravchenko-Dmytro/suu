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
    public partial class Вчителі : Form
    {
        public Вчителі()
        {
            InitializeComponent();
        }

        private void Form_teacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.suuDataSet.teachers);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Update(this.suuDataSet.teachers);
        }
    }
}
