using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace suu
{
    public partial class Form1 : Form
    {
        //private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.suuDataSet.schedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.suuDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.suuDataSet.groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.suuDataSet.department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.suuDataSet.faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.suuDataSet.disciplines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.suuDataSet.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suuDataSet.setting_university". При необходимости она может быть перемещена или удалена.
            this.setting_universityTableAdapter.Fill(this.suuDataSet.setting_university);
            //sqlConnection = new SqlConnection(@"Data Source = DESKTOP - E7N09RL\SQLEXPRESS;Initial Catalog = suu; Integrated Security = True");
            //sqlConnection.Open();
        }
        //@"Data Source = DESKTOP - E7N09RL\SQLEXPRESS;Initial Catalog = suu; Integrated Security = True"
        private void університетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_university form2 = new Form_university();
            form2.Show();
        }

        private void вчителіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Вчителі form3 = new Вчителі();
            form3.Show();
        }

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_discipline form4 = new Form_discipline();
            form4.Show();
        }

        private void факультетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_faculty form5 = new Form_faculty();
            form5.Show();
        }

        private void відділиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_department form6 = new Form_department();
            form6.Show();
        }

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_groups form7 = new Form_groups();
            form7.Show();
        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_students form8 = new Form_students();
            form8.Show();
        }

        private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_schedule form9 = new Form_schedule();
            form9.Show();
        }
    }
}
