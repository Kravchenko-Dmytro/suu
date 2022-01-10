namespace suu
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.setting_university = new System.Windows.Forms.DataGridView();
            this.iduniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortnameuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settinguniversityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suuDataSet = new suu.suuDataSet();
            this.teachers = new System.Windows.Forms.DataGridView();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplines = new System.Windows.Forms.DataGridView();
            this.iddisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faculty = new System.Windows.Forms.DataGridView();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefacultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortnamefacultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduniversityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.department = new System.Windows.Forms.DataGridView();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortnamedepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groups = new System.Windows.Forms.DataGridView();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namegroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students = new System.Windows.Forms.DataGridView();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonestudendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setting_universityTableAdapter = new suu.suuDataSetTableAdapters.setting_universityTableAdapter();
            this.teachersTableAdapter = new suu.suuDataSetTableAdapters.teachersTableAdapter();
            this.disciplinesTableAdapter = new suu.suuDataSetTableAdapters.disciplinesTableAdapter();
            this.facultyTableAdapter = new suu.suuDataSetTableAdapters.facultyTableAdapter();
            this.departmentTableAdapter = new suu.suuDataSetTableAdapters.departmentTableAdapter();
            this.groupsTableAdapter = new suu.suuDataSetTableAdapters.groupsTableAdapter();
            this.studentsTableAdapter = new suu.suuDataSetTableAdapters.studentsTableAdapter();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new suu.suuDataSetTableAdapters.scheduleTableAdapter();
            this.scheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schedule = new System.Windows.Forms.DataGridView();
            this.idscheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namescheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddisciplineDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timescheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.університетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вчителіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисципліниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відділиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.setting_university)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settinguniversityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.department)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setting_university
            // 
            this.setting_university.AutoGenerateColumns = false;
            this.setting_university.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setting_university.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduniversityDataGridViewTextBoxColumn,
            this.nameuniversityDataGridViewTextBoxColumn,
            this.shortnameuniversityDataGridViewTextBoxColumn,
            this.adressuniversityDataGridViewTextBoxColumn,
            this.phoneuniversityDataGridViewTextBoxColumn,
            this.siteuniversityDataGridViewTextBoxColumn});
            this.setting_university.DataSource = this.settinguniversityBindingSource;
            this.setting_university.Location = new System.Drawing.Point(161, 28);
            this.setting_university.Name = "setting_university";
            this.setting_university.RowHeadersWidth = 51;
            this.setting_university.RowTemplate.Height = 24;
            this.setting_university.Size = new System.Drawing.Size(805, 81);
            this.setting_university.TabIndex = 0;
            // 
            // iduniversityDataGridViewTextBoxColumn
            // 
            this.iduniversityDataGridViewTextBoxColumn.DataPropertyName = "id_university";
            this.iduniversityDataGridViewTextBoxColumn.HeaderText = "id_university";
            this.iduniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduniversityDataGridViewTextBoxColumn.Name = "iduniversityDataGridViewTextBoxColumn";
            this.iduniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameuniversityDataGridViewTextBoxColumn
            // 
            this.nameuniversityDataGridViewTextBoxColumn.DataPropertyName = "name_university";
            this.nameuniversityDataGridViewTextBoxColumn.HeaderText = "name_university";
            this.nameuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameuniversityDataGridViewTextBoxColumn.Name = "nameuniversityDataGridViewTextBoxColumn";
            this.nameuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // shortnameuniversityDataGridViewTextBoxColumn
            // 
            this.shortnameuniversityDataGridViewTextBoxColumn.DataPropertyName = "short_name_university";
            this.shortnameuniversityDataGridViewTextBoxColumn.HeaderText = "short_name_university";
            this.shortnameuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortnameuniversityDataGridViewTextBoxColumn.Name = "shortnameuniversityDataGridViewTextBoxColumn";
            this.shortnameuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressuniversityDataGridViewTextBoxColumn
            // 
            this.adressuniversityDataGridViewTextBoxColumn.DataPropertyName = "adress_university";
            this.adressuniversityDataGridViewTextBoxColumn.HeaderText = "adress_university";
            this.adressuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressuniversityDataGridViewTextBoxColumn.Name = "adressuniversityDataGridViewTextBoxColumn";
            this.adressuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneuniversityDataGridViewTextBoxColumn
            // 
            this.phoneuniversityDataGridViewTextBoxColumn.DataPropertyName = "phone_university";
            this.phoneuniversityDataGridViewTextBoxColumn.HeaderText = "phone_university";
            this.phoneuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneuniversityDataGridViewTextBoxColumn.Name = "phoneuniversityDataGridViewTextBoxColumn";
            this.phoneuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // siteuniversityDataGridViewTextBoxColumn
            // 
            this.siteuniversityDataGridViewTextBoxColumn.DataPropertyName = "site_university";
            this.siteuniversityDataGridViewTextBoxColumn.HeaderText = "site_university";
            this.siteuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siteuniversityDataGridViewTextBoxColumn.Name = "siteuniversityDataGridViewTextBoxColumn";
            this.siteuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // settinguniversityBindingSource
            // 
            this.settinguniversityBindingSource.DataMember = "setting_university";
            this.settinguniversityBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // suuDataSetBindingSource
            // 
            this.suuDataSetBindingSource.DataSource = this.suuDataSet;
            this.suuDataSetBindingSource.Position = 0;
            // 
            // suuDataSet
            // 
            this.suuDataSet.DataSetName = "suuDataSet";
            this.suuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachers
            // 
            this.teachers.AutoGenerateColumns = false;
            this.teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacheridDataGridViewTextBoxColumn,
            this.nameteacherDataGridViewTextBoxColumn,
            this.surnameteacherDataGridViewTextBoxColumn,
            this.emailteacherDataGridViewTextBoxColumn,
            this.phoneteacherDataGridViewTextBoxColumn});
            this.teachers.DataSource = this.teachersBindingSource;
            this.teachers.Location = new System.Drawing.Point(12, 115);
            this.teachers.Name = "teachers";
            this.teachers.RowHeadersWidth = 51;
            this.teachers.RowTemplate.Height = 24;
            this.teachers.Size = new System.Drawing.Size(706, 68);
            this.teachers.TabIndex = 1;
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            this.teacheridDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameteacherDataGridViewTextBoxColumn
            // 
            this.nameteacherDataGridViewTextBoxColumn.DataPropertyName = "name_teacher";
            this.nameteacherDataGridViewTextBoxColumn.HeaderText = "name_teacher";
            this.nameteacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameteacherDataGridViewTextBoxColumn.Name = "nameteacherDataGridViewTextBoxColumn";
            this.nameteacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameteacherDataGridViewTextBoxColumn
            // 
            this.surnameteacherDataGridViewTextBoxColumn.DataPropertyName = "surname_teacher";
            this.surnameteacherDataGridViewTextBoxColumn.HeaderText = "surname_teacher";
            this.surnameteacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameteacherDataGridViewTextBoxColumn.Name = "surnameteacherDataGridViewTextBoxColumn";
            this.surnameteacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailteacherDataGridViewTextBoxColumn
            // 
            this.emailteacherDataGridViewTextBoxColumn.DataPropertyName = "email_teacher";
            this.emailteacherDataGridViewTextBoxColumn.HeaderText = "email_teacher";
            this.emailteacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailteacherDataGridViewTextBoxColumn.Name = "emailteacherDataGridViewTextBoxColumn";
            this.emailteacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneteacherDataGridViewTextBoxColumn
            // 
            this.phoneteacherDataGridViewTextBoxColumn.DataPropertyName = "phone_teacher";
            this.phoneteacherDataGridViewTextBoxColumn.HeaderText = "phone_teacher";
            this.phoneteacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneteacherDataGridViewTextBoxColumn.Name = "phoneteacherDataGridViewTextBoxColumn";
            this.phoneteacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // disciplines
            // 
            this.disciplines.AutoGenerateColumns = false;
            this.disciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddisciplineDataGridViewTextBoxColumn,
            this.namedisciplineDataGridViewTextBoxColumn});
            this.disciplines.DataSource = this.disciplinesBindingSource;
            this.disciplines.Location = new System.Drawing.Point(758, 115);
            this.disciplines.Name = "disciplines";
            this.disciplines.RowHeadersWidth = 51;
            this.disciplines.RowTemplate.Height = 24;
            this.disciplines.Size = new System.Drawing.Size(309, 70);
            this.disciplines.TabIndex = 2;
            // 
            // iddisciplineDataGridViewTextBoxColumn
            // 
            this.iddisciplineDataGridViewTextBoxColumn.DataPropertyName = "id_discipline";
            this.iddisciplineDataGridViewTextBoxColumn.HeaderText = "id_discipline";
            this.iddisciplineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddisciplineDataGridViewTextBoxColumn.Name = "iddisciplineDataGridViewTextBoxColumn";
            this.iddisciplineDataGridViewTextBoxColumn.Width = 125;
            // 
            // namedisciplineDataGridViewTextBoxColumn
            // 
            this.namedisciplineDataGridViewTextBoxColumn.DataPropertyName = "name_discipline";
            this.namedisciplineDataGridViewTextBoxColumn.HeaderText = "name_discipline";
            this.namedisciplineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namedisciplineDataGridViewTextBoxColumn.Name = "namedisciplineDataGridViewTextBoxColumn";
            this.namedisciplineDataGridViewTextBoxColumn.Width = 125;
            // 
            // disciplinesBindingSource
            // 
            this.disciplinesBindingSource.DataMember = "disciplines";
            this.disciplinesBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // faculty
            // 
            this.faculty.AutoGenerateColumns = false;
            this.faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyidDataGridViewTextBoxColumn,
            this.namefacultyDataGridViewTextBoxColumn,
            this.shortnamefacultyDataGridViewTextBoxColumn,
            this.iduniversityDataGridViewTextBoxColumn1});
            this.faculty.DataSource = this.facultyBindingSource;
            this.faculty.Location = new System.Drawing.Point(12, 204);
            this.faculty.Name = "faculty";
            this.faculty.RowHeadersWidth = 51;
            this.faculty.RowTemplate.Height = 24;
            this.faculty.Size = new System.Drawing.Size(555, 71);
            this.faculty.TabIndex = 3;
            // 
            // facultyidDataGridViewTextBoxColumn
            // 
            this.facultyidDataGridViewTextBoxColumn.DataPropertyName = "faculty_id";
            this.facultyidDataGridViewTextBoxColumn.HeaderText = "faculty_id";
            this.facultyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyidDataGridViewTextBoxColumn.Name = "facultyidDataGridViewTextBoxColumn";
            this.facultyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // namefacultyDataGridViewTextBoxColumn
            // 
            this.namefacultyDataGridViewTextBoxColumn.DataPropertyName = "name_faculty";
            this.namefacultyDataGridViewTextBoxColumn.HeaderText = "name_faculty";
            this.namefacultyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namefacultyDataGridViewTextBoxColumn.Name = "namefacultyDataGridViewTextBoxColumn";
            this.namefacultyDataGridViewTextBoxColumn.Width = 125;
            // 
            // shortnamefacultyDataGridViewTextBoxColumn
            // 
            this.shortnamefacultyDataGridViewTextBoxColumn.DataPropertyName = "short_name_faculty";
            this.shortnamefacultyDataGridViewTextBoxColumn.HeaderText = "short_name_faculty";
            this.shortnamefacultyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortnamefacultyDataGridViewTextBoxColumn.Name = "shortnamefacultyDataGridViewTextBoxColumn";
            this.shortnamefacultyDataGridViewTextBoxColumn.Width = 125;
            // 
            // iduniversityDataGridViewTextBoxColumn1
            // 
            this.iduniversityDataGridViewTextBoxColumn1.DataPropertyName = "id_university";
            this.iduniversityDataGridViewTextBoxColumn1.HeaderText = "id_university";
            this.iduniversityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iduniversityDataGridViewTextBoxColumn1.Name = "iduniversityDataGridViewTextBoxColumn1";
            this.iduniversityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "faculty";
            this.facultyBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // department
            // 
            this.department.AutoGenerateColumns = false;
            this.department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentidDataGridViewTextBoxColumn,
            this.facultyidDataGridViewTextBoxColumn1,
            this.namedepartmentDataGridViewTextBoxColumn,
            this.shortnamedepartmentDataGridViewTextBoxColumn});
            this.department.DataSource = this.departmentBindingSource;
            this.department.Location = new System.Drawing.Point(606, 204);
            this.department.Name = "department";
            this.department.RowHeadersWidth = 51;
            this.department.RowTemplate.Height = 24;
            this.department.Size = new System.Drawing.Size(560, 71);
            this.department.TabIndex = 7;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            this.departmentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyidDataGridViewTextBoxColumn1
            // 
            this.facultyidDataGridViewTextBoxColumn1.DataPropertyName = "faculty_id";
            this.facultyidDataGridViewTextBoxColumn1.HeaderText = "faculty_id";
            this.facultyidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.facultyidDataGridViewTextBoxColumn1.Name = "facultyidDataGridViewTextBoxColumn1";
            this.facultyidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // namedepartmentDataGridViewTextBoxColumn
            // 
            this.namedepartmentDataGridViewTextBoxColumn.DataPropertyName = "name_department";
            this.namedepartmentDataGridViewTextBoxColumn.HeaderText = "name_department";
            this.namedepartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namedepartmentDataGridViewTextBoxColumn.Name = "namedepartmentDataGridViewTextBoxColumn";
            this.namedepartmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // shortnamedepartmentDataGridViewTextBoxColumn
            // 
            this.shortnamedepartmentDataGridViewTextBoxColumn.DataPropertyName = "short_name_department";
            this.shortnamedepartmentDataGridViewTextBoxColumn.HeaderText = "short_name_department";
            this.shortnamedepartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortnamedepartmentDataGridViewTextBoxColumn.Name = "shortnamedepartmentDataGridViewTextBoxColumn";
            this.shortnamedepartmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // groups
            // 
            this.groups.AutoGenerateColumns = false;
            this.groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgroupDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn1,
            this.namegroupDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.groups.DataSource = this.groupsBindingSource;
            this.groups.Location = new System.Drawing.Point(26, 301);
            this.groups.Name = "groups";
            this.groups.RowHeadersWidth = 51;
            this.groups.RowTemplate.Height = 24;
            this.groups.Size = new System.Drawing.Size(556, 70);
            this.groups.TabIndex = 6;
            // 
            // idgroupDataGridViewTextBoxColumn
            // 
            this.idgroupDataGridViewTextBoxColumn.DataPropertyName = "id_group";
            this.idgroupDataGridViewTextBoxColumn.HeaderText = "id_group";
            this.idgroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idgroupDataGridViewTextBoxColumn.Name = "idgroupDataGridViewTextBoxColumn";
            this.idgroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentidDataGridViewTextBoxColumn1
            // 
            this.departmentidDataGridViewTextBoxColumn1.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn1.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn1.Name = "departmentidDataGridViewTextBoxColumn1";
            this.departmentidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // namegroupDataGridViewTextBoxColumn
            // 
            this.namegroupDataGridViewTextBoxColumn.DataPropertyName = "name_group";
            this.namegroupDataGridViewTextBoxColumn.HeaderText = "name_group";
            this.namegroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namegroupDataGridViewTextBoxColumn.Name = "namegroupDataGridViewTextBoxColumn";
            this.namegroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // students
            // 
            this.students.AutoGenerateColumns = false;
            this.students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.idgroupDataGridViewTextBoxColumn1,
            this.namestudentDataGridViewTextBoxColumn,
            this.emailstudentDataGridViewTextBoxColumn,
            this.phonestudendDataGridViewTextBoxColumn});
            this.students.DataSource = this.studentsBindingSource;
            this.students.Location = new System.Drawing.Point(12, 386);
            this.students.Name = "students";
            this.students.RowHeadersWidth = 51;
            this.students.RowTemplate.Height = 24;
            this.students.Size = new System.Drawing.Size(683, 68);
            this.students.TabIndex = 5;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idgroupDataGridViewTextBoxColumn1
            // 
            this.idgroupDataGridViewTextBoxColumn1.DataPropertyName = "id_group";
            this.idgroupDataGridViewTextBoxColumn1.HeaderText = "id_group";
            this.idgroupDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idgroupDataGridViewTextBoxColumn1.Name = "idgroupDataGridViewTextBoxColumn1";
            this.idgroupDataGridViewTextBoxColumn1.Width = 125;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "name_student";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            this.namestudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailstudentDataGridViewTextBoxColumn
            // 
            this.emailstudentDataGridViewTextBoxColumn.DataPropertyName = "email_student";
            this.emailstudentDataGridViewTextBoxColumn.HeaderText = "email_student";
            this.emailstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailstudentDataGridViewTextBoxColumn.Name = "emailstudentDataGridViewTextBoxColumn";
            this.emailstudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonestudendDataGridViewTextBoxColumn
            // 
            this.phonestudendDataGridViewTextBoxColumn.DataPropertyName = "phone_studend";
            this.phonestudendDataGridViewTextBoxColumn.HeaderText = "phone_studend";
            this.phonestudendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonestudendDataGridViewTextBoxColumn.Name = "phonestudendDataGridViewTextBoxColumn";
            this.phonestudendDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // setting_universityTableAdapter
            // 
            this.setting_universityTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinesTableAdapter
            // 
            this.disciplinesTableAdapter.ClearBeforeFill = true;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "schedule";
            this.scheduleBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleBindingSource1
            // 
            this.scheduleBindingSource1.DataMember = "schedule";
            this.scheduleBindingSource1.DataSource = this.suuDataSetBindingSource;
            // 
            // schedule
            // 
            this.schedule.AutoGenerateColumns = false;
            this.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idscheduleDataGridViewTextBoxColumn,
            this.namescheduleDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn1,
            this.iddisciplineDataGridViewTextBoxColumn1,
            this.idgroupDataGridViewTextBoxColumn2,
            this.timescheduleDataGridViewTextBoxColumn,
            this.classroomDataGridViewTextBoxColumn});
            this.schedule.DataSource = this.scheduleBindingSource2;
            this.schedule.Location = new System.Drawing.Point(26, 474);
            this.schedule.Name = "schedule";
            this.schedule.RowHeadersWidth = 51;
            this.schedule.RowTemplate.Height = 24;
            this.schedule.Size = new System.Drawing.Size(940, 70);
            this.schedule.TabIndex = 8;
            // 
            // idscheduleDataGridViewTextBoxColumn
            // 
            this.idscheduleDataGridViewTextBoxColumn.DataPropertyName = "id_schedule";
            this.idscheduleDataGridViewTextBoxColumn.HeaderText = "id_schedule";
            this.idscheduleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idscheduleDataGridViewTextBoxColumn.Name = "idscheduleDataGridViewTextBoxColumn";
            this.idscheduleDataGridViewTextBoxColumn.Width = 125;
            // 
            // namescheduleDataGridViewTextBoxColumn
            // 
            this.namescheduleDataGridViewTextBoxColumn.DataPropertyName = "name_schedule";
            this.namescheduleDataGridViewTextBoxColumn.HeaderText = "name_schedule";
            this.namescheduleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namescheduleDataGridViewTextBoxColumn.Name = "namescheduleDataGridViewTextBoxColumn";
            this.namescheduleDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacheridDataGridViewTextBoxColumn1
            // 
            this.teacheridDataGridViewTextBoxColumn1.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn1.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.teacheridDataGridViewTextBoxColumn1.Name = "teacheridDataGridViewTextBoxColumn1";
            this.teacheridDataGridViewTextBoxColumn1.Width = 125;
            // 
            // iddisciplineDataGridViewTextBoxColumn1
            // 
            this.iddisciplineDataGridViewTextBoxColumn1.DataPropertyName = "id_discipline";
            this.iddisciplineDataGridViewTextBoxColumn1.HeaderText = "id_discipline";
            this.iddisciplineDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iddisciplineDataGridViewTextBoxColumn1.Name = "iddisciplineDataGridViewTextBoxColumn1";
            this.iddisciplineDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idgroupDataGridViewTextBoxColumn2
            // 
            this.idgroupDataGridViewTextBoxColumn2.DataPropertyName = "id_group";
            this.idgroupDataGridViewTextBoxColumn2.HeaderText = "id_group";
            this.idgroupDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idgroupDataGridViewTextBoxColumn2.Name = "idgroupDataGridViewTextBoxColumn2";
            this.idgroupDataGridViewTextBoxColumn2.Width = 125;
            // 
            // timescheduleDataGridViewTextBoxColumn
            // 
            this.timescheduleDataGridViewTextBoxColumn.DataPropertyName = "time_schedule";
            this.timescheduleDataGridViewTextBoxColumn.HeaderText = "time_schedule";
            this.timescheduleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timescheduleDataGridViewTextBoxColumn.Name = "timescheduleDataGridViewTextBoxColumn";
            this.timescheduleDataGridViewTextBoxColumn.Width = 125;
            // 
            // classroomDataGridViewTextBoxColumn
            // 
            this.classroomDataGridViewTextBoxColumn.DataPropertyName = "classroom";
            this.classroomDataGridViewTextBoxColumn.HeaderText = "classroom";
            this.classroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classroomDataGridViewTextBoxColumn.Name = "classroomDataGridViewTextBoxColumn";
            this.classroomDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleBindingSource2
            // 
            this.scheduleBindingSource2.DataMember = "schedule";
            this.scheduleBindingSource2.DataSource = this.suuDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціToolStripMenuItem
            // 
            this.таблиціToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.університетиToolStripMenuItem,
            this.вчителіToolStripMenuItem,
            this.дисципліниToolStripMenuItem,
            this.факультетиToolStripMenuItem,
            this.відділиToolStripMenuItem,
            this.групиToolStripMenuItem,
            this.студентиToolStripMenuItem,
            this.розкладToolStripMenuItem});
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            // 
            // університетиToolStripMenuItem
            // 
            this.університетиToolStripMenuItem.Name = "університетиToolStripMenuItem";
            this.університетиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.університетиToolStripMenuItem.Text = "Університети";
            this.університетиToolStripMenuItem.Click += new System.EventHandler(this.університетиToolStripMenuItem_Click);
            // 
            // вчителіToolStripMenuItem
            // 
            this.вчителіToolStripMenuItem.Name = "вчителіToolStripMenuItem";
            this.вчителіToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вчителіToolStripMenuItem.Text = "Вчителі";
            this.вчителіToolStripMenuItem.Click += new System.EventHandler(this.вчителіToolStripMenuItem_Click);
            // 
            // дисципліниToolStripMenuItem
            // 
            this.дисципліниToolStripMenuItem.Name = "дисципліниToolStripMenuItem";
            this.дисципліниToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дисципліниToolStripMenuItem.Text = "Дисципліни";
            this.дисципліниToolStripMenuItem.Click += new System.EventHandler(this.дисципліниToolStripMenuItem_Click);
            // 
            // факультетиToolStripMenuItem
            // 
            this.факультетиToolStripMenuItem.Name = "факультетиToolStripMenuItem";
            this.факультетиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.факультетиToolStripMenuItem.Text = "Факультети";
            this.факультетиToolStripMenuItem.Click += new System.EventHandler(this.факультетиToolStripMenuItem_Click);
            // 
            // відділиToolStripMenuItem
            // 
            this.відділиToolStripMenuItem.Name = "відділиToolStripMenuItem";
            this.відділиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.відділиToolStripMenuItem.Text = "Відділи";
            this.відділиToolStripMenuItem.Click += new System.EventHandler(this.відділиToolStripMenuItem_Click);
            // 
            // групиToolStripMenuItem
            // 
            this.групиToolStripMenuItem.Name = "групиToolStripMenuItem";
            this.групиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.групиToolStripMenuItem.Text = "Групи";
            this.групиToolStripMenuItem.Click += new System.EventHandler(this.групиToolStripMenuItem_Click);
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.студентиToolStripMenuItem.Text = "Студенти";
            this.студентиToolStripMenuItem.Click += new System.EventHandler(this.студентиToolStripMenuItem_Click);
            // 
            // розкладToolStripMenuItem
            // 
            this.розкладToolStripMenuItem.Name = "розкладToolStripMenuItem";
            this.розкладToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.розкладToolStripMenuItem.Text = "Розклад";
            this.розкладToolStripMenuItem.Click += new System.EventHandler(this.розкладToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 565);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.department);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.students);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.setting_university);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setting_university)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settinguniversityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.department)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView setting_university;
        private System.Windows.Forms.DataGridView teachers;
        private System.Windows.Forms.DataGridView disciplines;
        private System.Windows.Forms.DataGridView faculty;
        private System.Windows.Forms.DataGridView department;
        private System.Windows.Forms.DataGridView groups;
        private System.Windows.Forms.DataGridView students;
        private System.Windows.Forms.BindingSource suuDataSetBindingSource;
        private suuDataSet suuDataSet;
        private System.Windows.Forms.BindingSource settinguniversityBindingSource;
        private suuDataSetTableAdapters.setting_universityTableAdapter setting_universityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortnameuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private suuDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource disciplinesBindingSource;
        private suuDataSetTableAdapters.disciplinesTableAdapter disciplinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private suuDataSetTableAdapters.facultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefacultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortnamefacultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduniversityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private suuDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortnamedepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private suuDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namegroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private suuDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonestudendDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private suuDataSetTableAdapters.scheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.BindingSource scheduleBindingSource1;
        private System.Windows.Forms.DataGridView schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn idscheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namescheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddisciplineDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timescheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scheduleBindingSource2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem університетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вчителіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисципліниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відділиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розкладToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

