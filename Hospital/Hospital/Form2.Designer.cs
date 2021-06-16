
namespace Hospital
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPacientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CContadorPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnA = new System.Windows.Forms.TextBox();
            this.tbnB = new System.Windows.Forms.TextBox();
            this.tbnC = new System.Windows.Forms.TextBox();
            this.pc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ci,
            this.CRi,
            this.CPacientes,
            this.CContadorPaciente,
            this.CDia,
            this.CIngreso});
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ci
            // 
            this.Ci.HeaderText = "i";
            this.Ci.Name = "Ci";
            // 
            // CRi
            // 
            this.CRi.HeaderText = "Ri";
            this.CRi.Name = "CRi";
            // 
            // CPacientes
            // 
            this.CPacientes.HeaderText = "Pacientes";
            this.CPacientes.Name = "CPacientes";
            // 
            // CContadorPaciente
            // 
            this.CContadorPaciente.HeaderText = "Contador Paciente";
            this.CContadorPaciente.Name = "CContadorPaciente";
            // 
            // CDia
            // 
            this.CDia.HeaderText = "Dia";
            this.CDia.Name = "CDia";
            // 
            // CIngreso
            // 
            this.CIngreso.HeaderText = "Ingreso";
            this.CIngreso.Name = "CIngreso";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox1.Location = new System.Drawing.Point(106, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes a simular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Punto de cambio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "c:";
            // 
            // tbnA
            // 
            this.tbnA.Location = new System.Drawing.Point(31, 40);
            this.tbnA.Name = "tbnA";
            this.tbnA.Size = new System.Drawing.Size(52, 20);
            this.tbnA.TabIndex = 8;
            // 
            // tbnB
            // 
            this.tbnB.Location = new System.Drawing.Point(31, 62);
            this.tbnB.Name = "tbnB";
            this.tbnB.Size = new System.Drawing.Size(52, 20);
            this.tbnB.TabIndex = 9;
            // 
            // tbnC
            // 
            this.tbnC.Location = new System.Drawing.Point(31, 84);
            this.tbnC.Name = "tbnC";
            this.tbnC.Size = new System.Drawing.Size(52, 20);
            this.tbnC.TabIndex = 10;
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(350, 13);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(78, 20);
            this.pc.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.tbnC);
            this.Controls.Add(this.tbnB);
            this.Controls.Add(this.tbnA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CContadorPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIngreso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbnA;
        private System.Windows.Forms.TextBox tbnB;
        private System.Windows.Forms.TextBox tbnC;
        private System.Windows.Forms.TextBox pc;
    }
}