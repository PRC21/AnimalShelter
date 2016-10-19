namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.lblChipRegistrationNumber = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbChipRegistrationNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbAddAnimal = new System.Windows.Forms.GroupBox();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.lblBadHabits = new System.Windows.Forms.Label();
            this.lblLastWalkDate = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpLastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.lbReserved = new System.Windows.Forms.ListBox();
            this.lbUnreserved = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.gbFindAnimal = new System.Windows.Forms.GroupBox();
            this.lblFindAnimalResult = new System.Windows.Forms.Label();
            this.lblFindAnimalChipRegistrationNumber = new System.Windows.Forms.Label();
            this.btnFindAnimal = new System.Windows.Forms.Button();
            this.tbFindAnimal = new System.Windows.Forms.TextBox();
            this.btnUnReserve = new System.Windows.Forms.Button();
            this.nudChipRegistrationNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbAddAnimal.SuspendLayout();
            this.gbFindAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipRegistrationNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(204, 165);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(6, 19);
            this.rbCat.Name = "rbCat";
            this.rbCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbCat.Size = new System.Drawing.Size(41, 17);
            this.rbCat.TabIndex = 3;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "Cat";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(76, 19);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(45, 17);
            this.rbDog.TabIndex = 4;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Dog";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // lblChipRegistrationNumber
            // 
            this.lblChipRegistrationNumber.AutoSize = true;
            this.lblChipRegistrationNumber.Location = new System.Drawing.Point(3, 48);
            this.lblChipRegistrationNumber.Name = "lblChipRegistrationNumber";
            this.lblChipRegistrationNumber.Size = new System.Drawing.Size(120, 13);
            this.lblChipRegistrationNumber.TabIndex = 5;
            this.lblChipRegistrationNumber.Text = "Chip registration number";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(3, 74);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date of birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // tbChipRegistrationNumber
            // 
            this.tbChipRegistrationNumber.Location = new System.Drawing.Point(129, 45);
            this.tbChipRegistrationNumber.Name = "tbChipRegistrationNumber";
            this.tbChipRegistrationNumber.Size = new System.Drawing.Size(139, 20);
            this.tbChipRegistrationNumber.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(139, 20);
            this.tbName.TabIndex = 11;
            // 
            // gbAddAnimal
            // 
            this.gbAddAnimal.Controls.Add(this.tbBadHabits);
            this.gbAddAnimal.Controls.Add(this.rbDog);
            this.gbAddAnimal.Controls.Add(this.rbCat);
            this.gbAddAnimal.Controls.Add(this.lblBadHabits);
            this.gbAddAnimal.Controls.Add(this.lblLastWalkDate);
            this.gbAddAnimal.Controls.Add(this.dtpDateOfBirth);
            this.gbAddAnimal.Controls.Add(this.dtpLastWalkDate);
            this.gbAddAnimal.Controls.Add(this.createAnimalButton);
            this.gbAddAnimal.Controls.Add(this.tbName);
            this.gbAddAnimal.Controls.Add(this.lblChipRegistrationNumber);
            this.gbAddAnimal.Controls.Add(this.lblDateOfBirth);
            this.gbAddAnimal.Controls.Add(this.tbChipRegistrationNumber);
            this.gbAddAnimal.Controls.Add(this.lblName);
            this.gbAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.gbAddAnimal.Name = "gbAddAnimal";
            this.gbAddAnimal.Size = new System.Drawing.Size(280, 197);
            this.gbAddAnimal.TabIndex = 14;
            this.gbAddAnimal.TabStop = false;
            this.gbAddAnimal.Text = "Add Animal";
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(129, 143);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(139, 20);
            this.tbBadHabits.TabIndex = 20;
            // 
            // lblBadHabits
            // 
            this.lblBadHabits.AutoSize = true;
            this.lblBadHabits.Location = new System.Drawing.Point(3, 146);
            this.lblBadHabits.Name = "lblBadHabits";
            this.lblBadHabits.Size = new System.Drawing.Size(57, 13);
            this.lblBadHabits.TabIndex = 17;
            this.lblBadHabits.Text = "Bad habits";
            // 
            // lblLastWalkDate
            // 
            this.lblLastWalkDate.AutoSize = true;
            this.lblLastWalkDate.Location = new System.Drawing.Point(3, 129);
            this.lblLastWalkDate.Name = "lblLastWalkDate";
            this.lblLastWalkDate.Size = new System.Drawing.Size(76, 13);
            this.lblLastWalkDate.TabIndex = 16;
            this.lblLastWalkDate.Text = "Last walk date";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(129, 71);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(139, 20);
            this.dtpDateOfBirth.TabIndex = 15;
            // 
            // dtpLastWalkDate
            // 
            this.dtpLastWalkDate.Location = new System.Drawing.Point(129, 123);
            this.dtpLastWalkDate.Name = "dtpLastWalkDate";
            this.dtpLastWalkDate.Size = new System.Drawing.Size(139, 20);
            this.dtpLastWalkDate.TabIndex = 14;
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(298, 18);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(443, 108);
            this.lbReserved.TabIndex = 16;
            // 
            // lbUnreserved
            // 
            this.lbUnreserved.FormattingEnabled = true;
            this.lbUnreserved.Location = new System.Drawing.Point(298, 163);
            this.lbUnreserved.Name = "lbUnreserved";
            this.lbUnreserved.Size = new System.Drawing.Size(443, 108);
            this.lbUnreserved.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(655, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(298, 132);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(67, 23);
            this.btnReserve.TabIndex = 19;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // gbFindAnimal
            // 
            this.gbFindAnimal.Controls.Add(this.lblFindAnimalResult);
            this.gbFindAnimal.Controls.Add(this.lblFindAnimalChipRegistrationNumber);
            this.gbFindAnimal.Controls.Add(this.btnFindAnimal);
            this.gbFindAnimal.Controls.Add(this.tbFindAnimal);
            this.gbFindAnimal.Location = new System.Drawing.Point(12, 215);
            this.gbFindAnimal.Name = "gbFindAnimal";
            this.gbFindAnimal.Size = new System.Drawing.Size(280, 100);
            this.gbFindAnimal.TabIndex = 20;
            this.gbFindAnimal.TabStop = false;
            this.gbFindAnimal.Text = "Find Animal";
            // 
            // lblFindAnimalResult
            // 
            this.lblFindAnimalResult.AutoSize = true;
            this.lblFindAnimalResult.Location = new System.Drawing.Point(3, 43);
            this.lblFindAnimalResult.Name = "lblFindAnimalResult";
            this.lblFindAnimalResult.Size = new System.Drawing.Size(59, 13);
            this.lblFindAnimalResult.TabIndex = 21;
            this.lblFindAnimalResult.Text = "Animal Info";
            // 
            // lblFindAnimalChipRegistrationNumber
            // 
            this.lblFindAnimalChipRegistrationNumber.AutoSize = true;
            this.lblFindAnimalChipRegistrationNumber.Location = new System.Drawing.Point(3, 22);
            this.lblFindAnimalChipRegistrationNumber.Name = "lblFindAnimalChipRegistrationNumber";
            this.lblFindAnimalChipRegistrationNumber.Size = new System.Drawing.Size(120, 13);
            this.lblFindAnimalChipRegistrationNumber.TabIndex = 6;
            this.lblFindAnimalChipRegistrationNumber.Text = "Chip registration number";
            // 
            // btnFindAnimal
            // 
            this.btnFindAnimal.Location = new System.Drawing.Point(199, 71);
            this.btnFindAnimal.Name = "btnFindAnimal";
            this.btnFindAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnFindAnimal.TabIndex = 1;
            this.btnFindAnimal.Text = "Find";
            this.btnFindAnimal.UseVisualStyleBackColor = true;
            this.btnFindAnimal.Click += new System.EventHandler(this.btnFindAnimal_Click);
            // 
            // tbFindAnimal
            // 
            this.tbFindAnimal.Location = new System.Drawing.Point(129, 19);
            this.tbFindAnimal.Name = "tbFindAnimal";
            this.tbFindAnimal.Size = new System.Drawing.Size(139, 20);
            this.tbFindAnimal.TabIndex = 0;
            // 
            // btnUnReserve
            // 
            this.btnUnReserve.Location = new System.Drawing.Point(371, 132);
            this.btnUnReserve.Name = "btnUnReserve";
            this.btnUnReserve.Size = new System.Drawing.Size(67, 23);
            this.btnUnReserve.TabIndex = 21;
            this.btnUnReserve.Text = "Unreserve";
            this.btnUnReserve.UseVisualStyleBackColor = true;
            this.btnUnReserve.Click += new System.EventHandler(this.btnUnReserve_Click);
            // 
            // nudChipRegistrationNumber
            // 
            this.nudChipRegistrationNumber.Location = new System.Drawing.Point(445, 135);
            this.nudChipRegistrationNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudChipRegistrationNumber.Name = "nudChipRegistrationNumber";
            this.nudChipRegistrationNumber.Size = new System.Drawing.Size(120, 20);
            this.nudChipRegistrationNumber.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(380, 278);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 327);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudChipRegistrationNumber);
            this.Controls.Add(this.btnUnReserve);
            this.Controls.Add(this.gbFindAnimal);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbUnreserved);
            this.Controls.Add(this.lbReserved);
            this.Controls.Add(this.gbAddAnimal);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.gbAddAnimal.ResumeLayout(false);
            this.gbAddAnimal.PerformLayout();
            this.gbFindAnimal.ResumeLayout(false);
            this.gbFindAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipRegistrationNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.Label lblChipRegistrationNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbChipRegistrationNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbAddAnimal;
        private System.Windows.Forms.Label lblBadHabits;
        private System.Windows.Forms.Label lblLastWalkDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpLastWalkDate;
        private System.Windows.Forms.ListBox lbReserved;
        private System.Windows.Forms.ListBox lbUnreserved;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.GroupBox gbFindAnimal;
        private System.Windows.Forms.TextBox tbFindAnimal;
        private System.Windows.Forms.Label lblFindAnimalChipRegistrationNumber;
        private System.Windows.Forms.Button btnFindAnimal;
        private System.Windows.Forms.Button btnUnReserve;
        private System.Windows.Forms.NumericUpDown nudChipRegistrationNumber;
        private System.Windows.Forms.Label lblFindAnimalResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

