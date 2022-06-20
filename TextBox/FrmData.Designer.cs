namespace TextBox
{
    partial class FrmData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxDoment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.textBoxfirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxWorkDays = new System.Windows.Forms.TextBox();
            this.WorkDays = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPension = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.tslConsultar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.tslacercade = new System.Windows.Forms.ToolStripLabel();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDoment
            // 
            this.textBoxDoment.Location = new System.Drawing.Point(162, 101);
            this.textBoxDoment.Name = "textBoxDoment";
            this.textBoxDoment.ShortcutsEnabled = false;
            this.textBoxDoment.Size = new System.Drawing.Size(215, 23);
            this.textBoxDoment.TabIndex = 0;
            this.textBoxDoment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoment_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(48, 153);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(88, 21);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "FirstName";
            // 
            // textBoxfirstName
            // 
            this.textBoxfirstName.Location = new System.Drawing.Point(162, 155);
            this.textBoxfirstName.Name = "textBoxfirstName";
            this.textBoxfirstName.ShortcutsEnabled = false;
            this.textBoxfirstName.Size = new System.Drawing.Size(215, 23);
            this.textBoxfirstName.TabIndex = 3;
            this.textBoxfirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxfirstName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(162, 206);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ShortcutsEnabled = false;
            this.textBoxLastName.Size = new System.Drawing.Size(215, 23);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salary.Location = new System.Drawing.Point(48, 257);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(58, 21);
            this.Salary.TabIndex = 6;
            this.Salary.Text = "Salary";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(162, 259);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ShortcutsEnabled = false;
            this.textBoxSalary.Size = new System.Drawing.Size(215, 23);
            this.textBoxSalary.TabIndex = 7;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalary_KeyPress);
            // 
            // textBoxWorkDays
            // 
            this.textBoxWorkDays.Location = new System.Drawing.Point(162, 305);
            this.textBoxWorkDays.Name = "textBoxWorkDays";
            this.textBoxWorkDays.ShortcutsEnabled = false;
            this.textBoxWorkDays.Size = new System.Drawing.Size(215, 23);
            this.textBoxWorkDays.TabIndex = 9;
            this.textBoxWorkDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWorkDays_KeyPress);
            // 
            // WorkDays
            // 
            this.WorkDays.AutoSize = true;
            this.WorkDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkDays.Location = new System.Drawing.Point(48, 303);
            this.WorkDays.Name = "WorkDays";
            this.WorkDays.Size = new System.Drawing.Size(88, 21);
            this.WorkDays.TabIndex = 8;
            this.WorkDays.Text = "WorkDays";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save employee record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(228, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee payroll calculation";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "calculate salary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Accrued Value";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(173, 469);
            this.txttotal.Name = "txttotal";
            this.txttotal.ShortcutsEnabled = false;
            this.txttotal.Size = new System.Drawing.Size(215, 23);
            this.txttotal.TabIndex = 15;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "CleanUp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPension
            // 
            this.txtPension.Location = new System.Drawing.Point(173, 436);
            this.txtPension.Name = "txtPension";
            this.txtPension.ShortcutsEnabled = false;
            this.txtPension.Size = new System.Drawing.Size(215, 23);
            this.txtPension.TabIndex = 19;
            this.txtPension.TextChanged += new System.EventHandler(this.txtPension_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pension";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Health";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(173, 407);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.ShortcutsEnabled = false;
            this.txtHealth.Size = new System.Drawing.Size(215, 23);
            this.txtHealth.TabIndex = 21;
            this.txtHealth.TextChanged += new System.EventHandler(this.txtHealth_TextChanged);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(419, 103);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(568, 427);
            this.dgvdata.TabIndex = 24;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // tsmMenu
            // 
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistrar,
            this.tslConsultar,
            this.tslEliminar,
            this.tslSalir,
            this.tslacercade});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(999, 25);
            this.tsmMenu.TabIndex = 25;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslRegistrar
            // 
            this.tslRegistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tslRegistrar.Name = "tslRegistrar";
            this.tslRegistrar.Size = new System.Drawing.Size(86, 22);
            this.tslRegistrar.Text = "To_register";
            this.tslRegistrar.Click += new System.EventHandler(this.tslRegistrar_Click);
            // 
            // tslConsultar
            // 
            this.tslConsultar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tslConsultar.Name = "tslConsultar";
            this.tslConsultar.Size = new System.Drawing.Size(62, 22);
            this.tslConsultar.Text = "Consult";
            this.tslConsultar.Click += new System.EventHandler(this.tslConsultar_Click);
            // 
            // tslEliminar
            // 
            this.tslEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(66, 22);
            this.tslEliminar.Text = "Remove";
            // 
            // tslSalir
            // 
            this.tslSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(35, 22);
            this.tslSalir.Text = "Exit";
            this.tslSalir.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tslacercade
            // 
            this.tslacercade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tslacercade.Name = "tslacercade";
            this.tslacercade.Size = new System.Drawing.Size(53, 22);
            this.tslacercade.Text = "About";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total_income";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Location = new System.Drawing.Point(173, 504);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ShortcutsEnabled = false;
            this.txtTotalIncome.Size = new System.Drawing.Size(215, 23);
            this.txtTotalIncome.TabIndex = 27;
            this.txtTotalIncome.TextChanged += new System.EventHandler(this.txtTotalIncome_TextChanged);
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 575);
            this.Controls.Add(this.txtTotalIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPension);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWorkDays);
            this.Controls.Add(this.WorkDays);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxfirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDoment);
            this.Name = "FrmData";
            this.Text = "Lista de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDoment;
        private Label label1;
        private Label FirstName;
        private System.Windows.Forms.TextBox textBoxfirstName;
        private Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private Label Salary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxWorkDays;
        private Label WorkDays;
        private Button button1;
        private Label label4;
        private Button button2;
        private Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private Button button3;
        private System.Windows.Forms.TextBox txtPension;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.TextBox txtHealth;
        private DataGridView dgvdata;
        private ToolStrip tsmMenu;
        private ToolStripLabel tslRegistrar;
        private ToolStripLabel tslConsultar;
        private ToolStripLabel tslEliminar;
        private ToolStripLabel tslSalir;
        private ToolStripLabel tslacercade;
        private ErrorProvider erpError;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private Label label3;
    }
}