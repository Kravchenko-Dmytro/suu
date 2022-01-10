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
    public partial class Form_schedule : Form
    {
        public Form_schedule()
        {
            InitializeComponent();
        }

        private void Form_schedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.suuDataSet.schedule);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.scheduleTableAdapter.Update(this.suuDataSet.schedule);
        }
    }
}
