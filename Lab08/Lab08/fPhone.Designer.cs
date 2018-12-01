namespace Lab08
{
    partial class fPhone
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOperating_Systems = new System.Windows.Forms.TextBox();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.tbProcessor_frequency = new System.Windows.Forms.TextBox();
            this.tbNumber_of_cores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasGPS = new System.Windows.Forms.CheckBox();
            this.chbHasMini_jack = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFirm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbOperating_Systems);
            this.groupBox1.Controls.Add(this.tbRAM);
            this.groupBox1.Controls.Add(this.tbProcessor_frequency);
            this.groupBox1.Controls.Add(this.tbNumber_of_cores);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbOperating_Systems
            // 
            this.tbOperating_Systems.Location = new System.Drawing.Point(318, 88);
            this.tbOperating_Systems.Name = "tbOperating_Systems";
            this.tbOperating_Systems.Size = new System.Drawing.Size(100, 22);
            this.tbOperating_Systems.TabIndex = 6;
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(318, 125);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(100, 22);
            this.tbRAM.TabIndex = 5;
            // 
            // tbProcessor_frequency
            // 
            this.tbProcessor_frequency.Location = new System.Drawing.Point(318, 165);
            this.tbProcessor_frequency.Name = "tbProcessor_frequency";
            this.tbProcessor_frequency.Size = new System.Drawing.Size(100, 22);
            this.tbProcessor_frequency.TabIndex = 4;
            // 
            // tbNumber_of_cores
            // 
            this.tbNumber_of_cores.Location = new System.Drawing.Point(318, 201);
            this.tbNumber_of_cores.Name = "tbNumber_of_cores";
            this.tbNumber_of_cores.Size = new System.Drawing.Size(100, 22);
            this.tbNumber_of_cores.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість ядер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Частота процесора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Операційна система";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasGPS);
            this.groupBox2.Controls.Add(this.chbHasMini_jack);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатки";
            // 
            // chbHasGPS
            // 
            this.chbHasGPS.AutoSize = true;
            this.chbHasGPS.Location = new System.Drawing.Point(53, 111);
            this.chbHasGPS.Name = "chbHasGPS";
            this.chbHasGPS.Size = new System.Drawing.Size(151, 21);
            this.chbHasGPS.TabIndex = 1;
            this.chbHasGPS.Text = "Телефон має GPS";
            this.chbHasGPS.UseVisualStyleBackColor = true;
            // 
            // chbHasMini_jack
            // 
            this.chbHasMini_jack.AutoSize = true;
            this.chbHasMini_jack.Location = new System.Drawing.Point(53, 54);
            this.chbHasMini_jack.Name = "chbHasMini_jack";
            this.chbHasMini_jack.Size = new System.Drawing.Size(270, 21);
            this.chbHasMini_jack.TabIndex = 0;
            this.chbHasMini_jack.Text = "Телефон має роз\'єм для навушників";
            this.chbHasMini_jack.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(625, 30);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 38);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(625, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Фірма";
            // 
            // tbFirm
            // 
            this.tbFirm.Location = new System.Drawing.Point(318, 43);
            this.tbFirm.Name = "tbFirm";
            this.tbFirm.Size = new System.Drawing.Size(100, 22);
            this.tbFirm.TabIndex = 8;
            //this.tbFirm.TextChanged += new System.EventHandler(this.tbFirm_TextChanged);
            // 
            // fPhone
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(764, 444);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fPhone";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий телефон";
            this.Load += new System.EventHandler(this.fPhone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOperating_Systems;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.TextBox tbProcessor_frequency;
        private System.Windows.Forms.TextBox tbNumber_of_cores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasGPS;
        private System.Windows.Forms.CheckBox chbHasMini_jack;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbFirm;
        private System.Windows.Forms.Label label5;
    }
}