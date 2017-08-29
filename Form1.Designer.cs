namespace BMICalculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weightCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBMIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bmiDBDataSet = new BMICalculator.BmiDBDataSet();
            this.tblBMIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBMITableAdapter = new BMICalculator.BmiDBDataSetTableAdapters.tblBMITableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBMIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBMIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Mass Index";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your height(m):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your weight(kg):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(174, 80);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(141, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(174, 120);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(141, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(29, 213);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 29);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Calculate";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 29);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(609, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weightCategoryDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBMIBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(455, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 126);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // weightCategoryDataGridViewTextBoxColumn
            // 
            this.weightCategoryDataGridViewTextBoxColumn.DataPropertyName = "WeightCategory";
            this.weightCategoryDataGridViewTextBoxColumn.HeaderText = "WeightCategory";
            this.weightCategoryDataGridViewTextBoxColumn.Name = "weightCategoryDataGridViewTextBoxColumn";
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            // 
            // tblBMIBindingSource1
            // 
            this.tblBMIBindingSource1.DataMember = "tblBMI";
            this.tblBMIBindingSource1.DataSource = this.bmiDBDataSet;
            // 
            // bmiDBDataSet
            // 
            this.bmiDBDataSet.DataSetName = "BmiDBDataSet";
            this.bmiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBMIBindingSource
            // 
            this.tblBMIBindingSource.DataMember = "tblBMI";
            this.tblBMIBindingSource.DataSource = this.bmiDBDataSet;
            // 
            // tblBMITableAdapter
            // 
            this.tblBMITableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(174, 160);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(141, 20);
            this.txtResult.TabIndex = 10;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(41, 300);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 20);
            this.lblMsg.TabIndex = 11;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(41, 335);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(114, 23);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "More info here..";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 374);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBMIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBMIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BmiDBDataSet bmiDBDataSet;
        private System.Windows.Forms.BindingSource tblBMIBindingSource;
        private BmiDBDataSetTableAdapters.tblBMITableAdapter tblBMITableAdapter;
        private System.Windows.Forms.BindingSource tblBMIBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
    }
}

