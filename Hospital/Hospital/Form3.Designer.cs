
namespace Hospital
{
    partial class Form3
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pc = new System.Windows.Forms.TextBox();
            this.tbnC = new System.Windows.Forms.TextBox();
            this.tbnB = new System.Windows.Forms.TextBox();
            this.tbnA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CCOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataserviciosofrece = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataserviciosofrece)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pacientes";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No.Personas";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero Pseudoalatorio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(368, 13);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(78, 20);
            this.pc.TabIndex = 56;
            // 
            // tbnC
            // 
            this.tbnC.Location = new System.Drawing.Point(49, 84);
            this.tbnC.Name = "tbnC";
            this.tbnC.Size = new System.Drawing.Size(52, 20);
            this.tbnC.TabIndex = 55;
            // 
            // tbnB
            // 
            this.tbnB.Location = new System.Drawing.Point(49, 62);
            this.tbnB.Name = "tbnB";
            this.tbnB.Size = new System.Drawing.Size(52, 20);
            this.tbnB.TabIndex = 54;
            // 
            // tbnA
            // 
            this.tbnA.Location = new System.Drawing.Point(49, 40);
            this.tbnA.Name = "tbnA";
            this.tbnA.Size = new System.Drawing.Size(52, 20);
            this.tbnA.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Punto de cambio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mes a simular:";
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
            this.comboBox1.Location = new System.Drawing.Point(124, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CCOSTO
            // 
            this.CCOSTO.HeaderText = "Costo";
            this.CCOSTO.Name = "CCOSTO";
            // 
            // CLS
            // 
            this.CLS.HeaderText = "Limite Superior";
            this.CLS.Name = "CLS";
            // 
            // CLI
            // 
            this.CLI.HeaderText = "Limite Inferior";
            this.CLI.Name = "CLI";
            // 
            // Cp
            // 
            this.Cp.HeaderText = "Probabilidad";
            this.Cp.Name = "Cp";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Servicios";
            this.Column5.Name = "Column5";
            // 
            // Cpp
            // 
            this.Cpp.HeaderText = "Pacientes";
            this.Cpp.Name = "Cpp";
            // 
            // dataserviciosofrece
            // 
            this.dataserviciosofrece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataserviciosofrece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cpp,
            this.Column5,
            this.Cp,
            this.CLI,
            this.CLS,
            this.CCOSTO});
            this.dataserviciosofrece.Location = new System.Drawing.Point(198, 62);
            this.dataserviciosofrece.Name = "dataserviciosofrece";
            this.dataserviciosofrece.Size = new System.Drawing.Size(537, 202);
            this.dataserviciosofrece.TabIndex = 57;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataserviciosofrece);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.tbnC);
            this.Controls.Add(this.tbnB);
            this.Controls.Add(this.tbnA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataserviciosofrece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pc;
        private System.Windows.Forms.TextBox tbnC;
        private System.Windows.Forms.TextBox tbnB;
        private System.Windows.Forms.TextBox tbnA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpp;
        private System.Windows.Forms.DataGridView dataserviciosofrece;
    }
}