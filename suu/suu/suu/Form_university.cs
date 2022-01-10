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
    public partial class Form_university : Form
    {
        public Form_university()
        {
            InitializeComponent();
        }

        private void Form_university_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.setting_university". При необходимости она может быть перемещена или удалена.
            this.setting_universityTableAdapter.Fill(this.suuDataSet.setting_university);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.setting_universityTableAdapter.Update(this.suuDataSet.setting_university);
        }
    }
}
