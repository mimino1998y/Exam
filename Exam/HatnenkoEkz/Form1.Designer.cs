namespace HatnenkoEkz
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.overviewB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addB = new System.Windows.Forms.Button();
            this.redQuotaTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.redB = new System.Windows.Forms.Button();
            this.redQuantityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.redNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redIdTB = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(441, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // overviewB
            // 
            this.overviewB.Location = new System.Drawing.Point(12, 178);
            this.overviewB.Name = "overviewB";
            this.overviewB.Size = new System.Drawing.Size(441, 39);
            this.overviewB.TabIndex = 2;
            this.overviewB.Text = "Сформировать выписку по недостающим товарам";
            this.overviewB.UseVisualStyleBackColor = true;
            this.overviewB.Click += new System.EventHandler(this.overviewB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addB);
            this.groupBox1.Controls.Add(this.redQuotaTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.redB);
            this.groupBox1.Controls.Add(this.redQuantityTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.redNameTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.redIdTB);
            this.groupBox1.Location = new System.Drawing.Point(459, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование позиции";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(9, 173);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(227, 23);
            this.addB.TabIndex = 12;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // redQuotaTB
            // 
            this.redQuotaTB.Location = new System.Drawing.Point(136, 118);
            this.redQuotaTB.Name = "redQuotaTB";
            this.redQuotaTB.Size = new System.Drawing.Size(100, 20);
            this.redQuotaTB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Квота товара:";
            // 
            // redB
            // 
            this.redB.Location = new System.Drawing.Point(9, 144);
            this.redB.Name = "redB";
            this.redB.Size = new System.Drawing.Size(227, 23);
            this.redB.TabIndex = 5;
            this.redB.Text = "Отредактировать";
            this.redB.UseVisualStyleBackColor = true;
            this.redB.Click += new System.EventHandler(this.redB_Click);
            // 
            // redQuantityTB
            // 
            this.redQuantityTB.Location = new System.Drawing.Point(136, 87);
            this.redQuantityTB.Name = "redQuantityTB";
            this.redQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.redQuantityTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество товара:";
            // 
            // redNameTB
            // 
            this.redNameTB.Location = new System.Drawing.Point(136, 56);
            this.redNameTB.Name = "redNameTB";
            this.redNameTB.Size = new System.Drawing.Size(100, 20);
            this.redNameTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID товара:";
            // 
            // redIdTB
            // 
            this.redIdTB.Location = new System.Drawing.Point(136, 23);
            this.redIdTB.Name = "redIdTB";
            this.redIdTB.Size = new System.Drawing.Size(100, 20);
            this.redIdTB.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Квота";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.overviewB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Складской учет";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button overviewB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox redQuantityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox redNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox redIdTB;
        private System.Windows.Forms.TextBox redQuotaTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button redB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

