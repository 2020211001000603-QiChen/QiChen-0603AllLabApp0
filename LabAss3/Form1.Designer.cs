namespace LabAss3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.checkReading = new System.Windows.Forms.CheckBox();
            this.checkPainting = new System.Windows.Forms.CheckBox();
            this.Hobby = new System.Windows.Forms.GroupBox();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.radioUnmarried = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Gender.SuspendLayout();
            this.Hobby.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cutomer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(239, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 35);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nabil";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(56, 30);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(89, 28);
            this.radioMale.TabIndex = 3;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(188, 30);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(113, 28);
            this.radioFemale.TabIndex = 4;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.radioFemale);
            this.Gender.Controls.Add(this.radioMale);
            this.Gender.Location = new System.Drawing.Point(38, 137);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(338, 79);
            this.Gender.TabIndex = 5;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // checkReading
            // 
            this.checkReading.AutoSize = true;
            this.checkReading.Location = new System.Drawing.Point(38, 25);
            this.checkReading.Name = "checkReading";
            this.checkReading.Size = new System.Drawing.Size(126, 28);
            this.checkReading.TabIndex = 6;
            this.checkReading.Text = "Reading";
            this.checkReading.UseVisualStyleBackColor = true;
            // 
            // checkPainting
            // 
            this.checkPainting.AutoSize = true;
            this.checkPainting.Location = new System.Drawing.Point(195, 25);
            this.checkPainting.Name = "checkPainting";
            this.checkPainting.Size = new System.Drawing.Size(138, 28);
            this.checkPainting.TabIndex = 7;
            this.checkPainting.Text = "Painting";
            this.checkPainting.UseVisualStyleBackColor = true;
            // 
            // Hobby
            // 
            this.Hobby.Controls.Add(this.checkPainting);
            this.Hobby.Controls.Add(this.checkReading);
            this.Hobby.Location = new System.Drawing.Point(31, 232);
            this.Hobby.Name = "Hobby";
            this.Hobby.Size = new System.Drawing.Size(344, 74);
            this.Hobby.TabIndex = 8;
            this.Hobby.TabStop = false;
            this.Hobby.Text = "Hobbies";
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(67, 43);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(125, 28);
            this.radioMarried.TabIndex = 9;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // radioUnmarried
            // 
            this.radioUnmarried.AutoSize = true;
            this.radioUnmarried.Location = new System.Drawing.Point(224, 34);
            this.radioUnmarried.Name = "radioUnmarried";
            this.radioUnmarried.Size = new System.Drawing.Size(149, 28);
            this.radioUnmarried.TabIndex = 10;
            this.radioUnmarried.TabStop = true;
            this.radioUnmarried.Text = "Unmarried";
            this.radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.radioUnmarried);
            this.Status.Controls.Add(this.radioMarried);
            this.Status.Location = new System.Drawing.Point(10, 322);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(433, 89);
            this.Status.TabIndex = 11;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            this.Status.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "China"});
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "China",
            "Japan",
            "US"});
            this.cmbCountry.Location = new System.Drawing.Point(226, 87);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(157, 32);
            this.cmbCountry.TabIndex = 13;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(767, 59);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 82;
            this.dtgCustomer.RowTemplate.Height = 37;
            this.dtgCustomer.Size = new System.Drawing.Size(1302, 385);
            this.dtgCustomer.TabIndex = 14;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(147, 555);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 24);
            this.lblID.TabIndex = 17;
            this.lblID.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2399, 710);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Hobby);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.Hobby.ResumeLayout(false);
            this.Hobby.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.CheckBox checkReading;
        private System.Windows.Forms.CheckBox checkPainting;
        private System.Windows.Forms.GroupBox Hobby;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.RadioButton radioUnmarried;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button4;
    }
}

