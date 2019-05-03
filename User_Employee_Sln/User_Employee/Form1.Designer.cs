namespace User_Employee
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.empTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.salaryBox);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.positionBox);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.surnameBox);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 389);
            this.panel1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(190, 163);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 29);
            this.add.TabIndex = 6;
            this.add.Text = "Əlavə et";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddEmployee);
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(68, 120);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(212, 20);
            this.salaryBox.TabIndex = 5;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(27, 123);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(39, 13);
            this.salary.TabIndex = 0;
            this.salary.Text = "Maaş :";
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(68, 94);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(212, 20);
            this.positionBox.TabIndex = 4;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(27, 97);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(42, 13);
            this.position.TabIndex = 0;
            this.position.Text = "Vəzifə :";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(68, 68);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(212, 20);
            this.emailBox.TabIndex = 3;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(27, 71);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 0;
            this.email.Text = "Email :";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(68, 42);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(212, 20);
            this.surnameBox.TabIndex = 2;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(27, 45);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(43, 13);
            this.surname.TabIndex = 0;
            this.surname.Text = "Soyad :";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(68, 16);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(212, 20);
            this.nameBox.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(27, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(26, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Ad :";
            // 
            // empTable
            // 
            this.empTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nameCol,
            this.surnameCol,
            this.emailCol,
            this.positionCol,
            this.salaryCol});
            this.empTable.Location = new System.Drawing.Point(333, 5);
            this.empTable.Name = "empTable";
            this.empTable.Size = new System.Drawing.Size(445, 341);
            this.empTable.TabIndex = 1;
            this.empTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EditRow);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // surnameCol
            // 
            this.surnameCol.HeaderText = "Surname";
            this.surnameCol.Name = "surnameCol";
            this.surnameCol.ReadOnly = true;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.Name = "emailCol";
            this.emailCol.ReadOnly = true;
            // 
            // positionCol
            // 
            this.positionCol.HeaderText = "Vəzifə";
            this.positionCol.Name = "positionCol";
            this.positionCol.ReadOnly = true;
            // 
            // salaryCol
            // 
            this.salaryCol.HeaderText = "Maaş";
            this.salaryCol.Name = "salaryCol";
            this.salaryCol.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(681, 362);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 31);
            this.delete.TabIndex = 2;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.DeleteRow);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(68, 163);
            this.update.Name = "update";
            this.update.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.update.Size = new System.Drawing.Size(88, 29);
            this.update.TabIndex = 7;
            this.update.Text = "Yenilə";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.updateRow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.empTable);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DataGridView empTable;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryCol;
        private System.Windows.Forms.Button update;
    }
}

