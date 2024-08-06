namespace LoginLibrary
{
    partial class student
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tpBook = new TabPage();
            txtAuthorNameBook = new TextBox();
            label14 = new Label();
            btnExit = new Button();
            txtCategory = new TextBox();
            txtAuthorID = new TextBox();
            label7 = new Label();
            dgvListBook = new DataGridView();
            dtpPublishDate = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBorowName = new TextBox();
            txtBorowID = new TextBox();
            tbLoan = new TabPage();
            btnExitLoans = new Button();
            dtpReturnLoan = new DateTimePicker();
            dtpBorrowLoan = new DateTimePicker();
            txtBorrowLoan = new TextBox();
            txtBookLoan = new TextBox();
            txtIDLoan = new TextBox();
            dgvLoan = new DataGridView();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBook).BeginInit();
            tbLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoan).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpBook);
            tabControl1.Controls.Add(tbLoan);
            tabControl1.Location = new Point(-3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1158, 649);
            tabControl1.TabIndex = 0;
            // 
            // tpBook
            // 
            tpBook.Controls.Add(txtAuthorNameBook);
            tpBook.Controls.Add(label14);
            tpBook.Controls.Add(btnExit);
            tpBook.Controls.Add(txtCategory);
            tpBook.Controls.Add(txtAuthorID);
            tpBook.Controls.Add(label7);
            tpBook.Controls.Add(dgvListBook);
            tpBook.Controls.Add(dtpPublishDate);
            tpBook.Controls.Add(label6);
            tpBook.Controls.Add(label4);
            tpBook.Controls.Add(label3);
            tpBook.Controls.Add(label2);
            tpBook.Controls.Add(label1);
            tpBook.Controls.Add(txtBorowName);
            tpBook.Controls.Add(txtBorowID);
            tpBook.Location = new Point(4, 29);
            tpBook.Name = "tpBook";
            tpBook.Padding = new Padding(3);
            tpBook.Size = new Size(1150, 616);
            tpBook.TabIndex = 0;
            tpBook.Text = "Book";
            tpBook.UseVisualStyleBackColor = true;
            // 
            // txtAuthorNameBook
            // 
            txtAuthorNameBook.Enabled = false;
            txtAuthorNameBook.Location = new Point(812, 118);
            txtAuthorNameBook.Name = "txtAuthorNameBook";
            txtAuthorNameBook.Size = new Size(250, 27);
            txtAuthorNameBook.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(695, 121);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 18;
            label14.Text = "Author Name";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1027, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 17;
            btnExit.Text = "Logout";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += txtExitBook_Click;
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Location = new Point(167, 175);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(151, 27);
            txtCategory.TabIndex = 16;
            // 
            // txtAuthorID
            // 
            txtAuthorID.Enabled = false;
            txtAuthorID.Location = new Point(812, 65);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.Size = new Size(250, 27);
            txtAuthorID.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(499, 314);
            label7.Name = "label7";
            label7.Size = new Size(174, 38);
            label7.TabIndex = 14;
            label7.Text = "List of Book";
            // 
            // dgvListBook
            // 
            dgvListBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBook.Location = new Point(34, 355);
            dgvListBook.Name = "dgvListBook";
            dgvListBook.RowHeadersWidth = 51;
            dgvListBook.Size = new Size(1087, 265);
            dgvListBook.TabIndex = 13;
            dgvListBook.CellClick += dataGridView1_CellClick;
            // 
            // dtpPublishDate
            // 
            dtpPublishDate.Enabled = false;
            dtpPublishDate.Location = new Point(812, 175);
            dtpPublishDate.Name = "dtpPublishDate";
            dtpPublishDate.Size = new Size(250, 27);
            dtpPublishDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(695, 178);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 11;
            label6.Text = "Publish Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 178);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 9;
            label4.Text = "Publisher ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 68);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 8;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 67);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // txtBorowName
            // 
            txtBorowName.Enabled = false;
            txtBorowName.Location = new Point(167, 118);
            txtBorowName.Name = "txtBorowName";
            txtBorowName.Size = new Size(151, 27);
            txtBorowName.TabIndex = 1;
            // 
            // txtBorowID
            // 
            txtBorowID.Enabled = false;
            txtBorowID.Location = new Point(167, 65);
            txtBorowID.Name = "txtBorowID";
            txtBorowID.Size = new Size(151, 27);
            txtBorowID.TabIndex = 0;
            // 
            // tbLoan
            // 
            tbLoan.Controls.Add(btnExitLoans);
            tbLoan.Controls.Add(dtpReturnLoan);
            tbLoan.Controls.Add(dtpBorrowLoan);
            tbLoan.Controls.Add(txtBorrowLoan);
            tbLoan.Controls.Add(txtBookLoan);
            tbLoan.Controls.Add(txtIDLoan);
            tbLoan.Controls.Add(dgvLoan);
            tbLoan.Controls.Add(label12);
            tbLoan.Controls.Add(label11);
            tbLoan.Controls.Add(label10);
            tbLoan.Controls.Add(label9);
            tbLoan.Controls.Add(label8);
            tbLoan.Controls.Add(label5);
            tbLoan.Location = new Point(4, 29);
            tbLoan.Name = "tbLoan";
            tbLoan.Padding = new Padding(3);
            tbLoan.Size = new Size(1150, 616);
            tbLoan.TabIndex = 1;
            tbLoan.Text = "Loans";
            tbLoan.UseVisualStyleBackColor = true;
            tbLoan.Click += tbLoan_Click;
            // 
            // btnExitLoans
            // 
            btnExitLoans.Location = new Point(1018, 309);
            btnExitLoans.Name = "btnExitLoans";
            btnExitLoans.Size = new Size(94, 29);
            btnExitLoans.TabIndex = 12;
            btnExitLoans.Text = "Logout";
            btnExitLoans.UseVisualStyleBackColor = true;
            btnExitLoans.Click += btnExitLoans_Click;
            // 
            // dtpReturnLoan
            // 
            dtpReturnLoan.Enabled = false;
            dtpReturnLoan.Location = new Point(752, 123);
            dtpReturnLoan.Name = "dtpReturnLoan";
            dtpReturnLoan.Size = new Size(250, 27);
            dtpReturnLoan.TabIndex = 11;
            // 
            // dtpBorrowLoan
            // 
            dtpBorrowLoan.Enabled = false;
            dtpBorrowLoan.Location = new Point(752, 71);
            dtpBorrowLoan.Name = "dtpBorrowLoan";
            dtpBorrowLoan.Size = new Size(250, 27);
            dtpBorrowLoan.TabIndex = 10;
            // 
            // txtBorrowLoan
            // 
            txtBorrowLoan.Enabled = false;
            txtBorrowLoan.Location = new Point(201, 182);
            txtBorrowLoan.Name = "txtBorrowLoan";
            txtBorrowLoan.Size = new Size(125, 27);
            txtBorrowLoan.TabIndex = 9;
            // 
            // txtBookLoan
            // 
            txtBookLoan.Enabled = false;
            txtBookLoan.Location = new Point(201, 123);
            txtBookLoan.Name = "txtBookLoan";
            txtBookLoan.Size = new Size(125, 27);
            txtBookLoan.TabIndex = 8;
            // 
            // txtIDLoan
            // 
            txtIDLoan.Enabled = false;
            txtIDLoan.Location = new Point(201, 71);
            txtIDLoan.Name = "txtIDLoan";
            txtIDLoan.Size = new Size(125, 27);
            txtIDLoan.TabIndex = 7;
            // 
            // dgvLoan
            // 
            dgvLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoan.Location = new Point(37, 355);
            dgvLoan.Name = "dgvLoan";
            dgvLoan.RowHeadersWidth = 51;
            dgvLoan.Size = new Size(1080, 258);
            dgvLoan.TabIndex = 6;
            dgvLoan.CellClick += dgvLoan_CellClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(492, 288);
            label12.Name = "label12";
            label12.Size = new Size(148, 31);
            label12.TabIndex = 5;
            label12.Text = "List of ticket";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(584, 126);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 4;
            label11.Text = "Return Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(584, 74);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 3;
            label10.Text = "Borrow Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(102, 182);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 2;
            label9.Text = "Borrower";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(102, 123);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 1;
            label8.Text = "Book";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 71);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 0;
            label5.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 652);
            Controls.Add(tabControl1);
            Name = "student";
            Text = "student";
            Load += student_Load;
            tabControl1.ResumeLayout(false);
            tpBook.ResumeLayout(false);
            tpBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBook).EndInit();
            tbLoan.ResumeLayout(false);
            tbLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpBook;
        private TabPage tbLoan;
        private TextBox txtBorowName;
        private TextBox txtBorowID;
        private Label label7;
        private DataGridView dgvListBook;
        private DateTimePicker dtpPublishDate;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCategory;
        private TextBox txtAuthorID;
        private ContextMenuStrip contextMenuStrip1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private DataGridView dgvLoan;
        private Label label12;
        private Label label11;
        private TextBox txtIDLoan;
        private DateTimePicker dtpReturnLoan;
        private DateTimePicker dtpBorrowLoan;
        private TextBox txtBorrowLoan;
        private TextBox txtBookLoan;
        private Button btnExit;
        private Button btnExitLoans;
        private TextBox txtAuthorNameBook;
        private Label label14;
    }
}