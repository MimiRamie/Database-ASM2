namespace LoginLibrary
{
    partial class AdminManagement
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
            tabControl = new TabControl();
            tabManBook = new TabPage();
            txtAuthorName = new TextBox();
            label16 = new Label();
            txtPublishID = new TextBox();
            label21 = new Label();
            btnExit = new Button();
            BookManagementView = new DataGridView();
            txtAuthor = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            btnClear = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dtPublish = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabManBorrow = new TabPage();
            btnLogoutBor = new Button();
            label23 = new Label();
            btnClearBor = new Button();
            btnUpBor = new Button();
            btnDelBor = new Button();
            btnAddBor = new Button();
            dgvBorrowMan = new DataGridView();
            dtDOB = new DateTimePicker();
            txtMail = new TextBox();
            txtPhoneBorrow = new TextBox();
            txtAddressBorrower = new TextBox();
            txtNameBorrow = new TextBox();
            txtIDBorrow = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabManLoan = new TabPage();
            btnLogoutLoan = new Button();
            txtLoanID = new TextBox();
            label5 = new Label();
            label22 = new Label();
            dgvListLoan = new DataGridView();
            btnClearLoan = new Button();
            btnDelLoan = new Button();
            btnUpLoan = new Button();
            btnAddLoan = new Button();
            dtpReturnDateLoan = new DateTimePicker();
            dtpBorrowDateLoan = new DateTimePicker();
            txtBorrowerIDLoan = new TextBox();
            txtBookLoanID = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label15 = new Label();
            tabControl.SuspendLayout();
            tabManBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookManagementView).BeginInit();
            tabManBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowMan).BeginInit();
            tabManLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLoan).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabManBook);
            tabControl.Controls.Add(tabManBorrow);
            tabControl.Controls.Add(tabManLoan);
            tabControl.Location = new Point(1, -5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1130, 768);
            tabControl.TabIndex = 0;
            // 
            // tabManBook
            // 
            tabManBook.Controls.Add(txtAuthorName);
            tabManBook.Controls.Add(label16);
            tabManBook.Controls.Add(txtPublishID);
            tabManBook.Controls.Add(label21);
            tabManBook.Controls.Add(btnExit);
            tabManBook.Controls.Add(BookManagementView);
            tabManBook.Controls.Add(txtAuthor);
            tabManBook.Controls.Add(txtName);
            tabManBook.Controls.Add(txtID);
            tabManBook.Controls.Add(btnClear);
            tabManBook.Controls.Add(btnDel);
            tabManBook.Controls.Add(btnUpdate);
            tabManBook.Controls.Add(btnAdd);
            tabManBook.Controls.Add(dtPublish);
            tabManBook.Controls.Add(label7);
            tabManBook.Controls.Add(label6);
            tabManBook.Controls.Add(label4);
            tabManBook.Controls.Add(label3);
            tabManBook.Controls.Add(label2);
            tabManBook.Controls.Add(label1);
            tabManBook.Location = new Point(4, 29);
            tabManBook.Name = "tabManBook";
            tabManBook.Padding = new Padding(3);
            tabManBook.Size = new Size(1122, 735);
            tabManBook.TabIndex = 0;
            tabManBook.Text = "Manage Book";
            tabManBook.UseVisualStyleBackColor = true;
            tabManBook.Click += tabManBook_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(340, 289);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(194, 289);
            label16.Name = "label16";
            label16.Size = new Size(98, 20);
            label16.TabIndex = 23;
            label16.Text = "Author Name";
            // 
            // txtPublishID
            // 
            txtPublishID.Location = new Point(718, 121);
            txtPublishID.Name = "txtPublishID";
            txtPublishID.Size = new Size(246, 27);
            txtPublishID.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(491, 379);
            label21.Name = "label21";
            label21.Size = new Size(143, 31);
            label21.TabIndex = 21;
            label21.Text = "List of Book";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1013, 399);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 29);
            btnExit.TabIndex = 20;
            btnExit.Text = "Logout";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BookManagementView
            // 
            BookManagementView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookManagementView.Location = new Point(40, 434);
            BookManagementView.Name = "BookManagementView";
            BookManagementView.RowHeadersWidth = 51;
            BookManagementView.Size = new Size(1041, 290);
            BookManagementView.TabIndex = 19;
            BookManagementView.CellClick += dataGridView1_CellClick;
            BookManagementView.CellContentClick += BookManagementView_CellContentClick;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(340, 227);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 17;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(340, 176);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.Location = new Point(340, 125);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 15;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(870, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDel
            // 
            btnDel.Enabled = false;
            btnDel.Location = new Point(718, 289);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 11;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(870, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(718, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtPublish
            // 
            dtPublish.Location = new Point(718, 178);
            dtPublish.Name = "dtPublish";
            dtPublish.Size = new Size(246, 27);
            dtPublish.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 183);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 6;
            label7.Text = "PublishDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 129);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 230);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Author ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 179);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 128);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Book ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 41);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 0;
            label1.Text = "Books Management";
            // 
            // tabManBorrow
            // 
            tabManBorrow.Controls.Add(btnLogoutBor);
            tabManBorrow.Controls.Add(label23);
            tabManBorrow.Controls.Add(btnClearBor);
            tabManBorrow.Controls.Add(btnUpBor);
            tabManBorrow.Controls.Add(btnDelBor);
            tabManBorrow.Controls.Add(btnAddBor);
            tabManBorrow.Controls.Add(dgvBorrowMan);
            tabManBorrow.Controls.Add(dtDOB);
            tabManBorrow.Controls.Add(txtMail);
            tabManBorrow.Controls.Add(txtPhoneBorrow);
            tabManBorrow.Controls.Add(txtAddressBorrower);
            tabManBorrow.Controls.Add(txtNameBorrow);
            tabManBorrow.Controls.Add(txtIDBorrow);
            tabManBorrow.Controls.Add(label14);
            tabManBorrow.Controls.Add(label13);
            tabManBorrow.Controls.Add(label12);
            tabManBorrow.Controls.Add(label11);
            tabManBorrow.Controls.Add(label10);
            tabManBorrow.Controls.Add(label9);
            tabManBorrow.Controls.Add(label8);
            tabManBorrow.Location = new Point(4, 29);
            tabManBorrow.Name = "tabManBorrow";
            tabManBorrow.Padding = new Padding(3);
            tabManBorrow.Size = new Size(1122, 735);
            tabManBorrow.TabIndex = 1;
            tabManBorrow.Text = "Manage Borrower";
            tabManBorrow.UseVisualStyleBackColor = true;
            // 
            // btnLogoutBor
            // 
            btnLogoutBor.Location = new Point(985, 392);
            btnLogoutBor.Name = "btnLogoutBor";
            btnLogoutBor.Size = new Size(94, 29);
            btnLogoutBor.TabIndex = 19;
            btnLogoutBor.Text = "Logout";
            btnLogoutBor.UseVisualStyleBackColor = true;
            btnLogoutBor.Click += btnLogoutBor_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(472, 374);
            label23.Name = "label23";
            label23.Size = new Size(187, 31);
            label23.TabIndex = 18;
            label23.Text = "List of Borrower";
            // 
            // btnClearBor
            // 
            btnClearBor.Location = new Point(779, 314);
            btnClearBor.Name = "btnClearBor";
            btnClearBor.Size = new Size(94, 29);
            btnClearBor.TabIndex = 17;
            btnClearBor.Text = "Clear";
            btnClearBor.UseVisualStyleBackColor = true;
            btnClearBor.Click += btnClearBor_Click;
            // 
            // btnUpBor
            // 
            btnUpBor.Enabled = false;
            btnUpBor.Location = new Point(779, 251);
            btnUpBor.Name = "btnUpBor";
            btnUpBor.Size = new Size(94, 29);
            btnUpBor.TabIndex = 16;
            btnUpBor.Text = "Update";
            btnUpBor.UseVisualStyleBackColor = true;
            btnUpBor.Click += btnUpBor_Click;
            // 
            // btnDelBor
            // 
            btnDelBor.Enabled = false;
            btnDelBor.Location = new Point(623, 314);
            btnDelBor.Name = "btnDelBor";
            btnDelBor.Size = new Size(94, 29);
            btnDelBor.TabIndex = 15;
            btnDelBor.Text = "Delete";
            btnDelBor.UseVisualStyleBackColor = true;
            btnDelBor.Click += btnDelBor_Click;
            // 
            // btnAddBor
            // 
            btnAddBor.Location = new Point(623, 251);
            btnAddBor.Name = "btnAddBor";
            btnAddBor.Size = new Size(94, 29);
            btnAddBor.TabIndex = 14;
            btnAddBor.Text = "Add";
            btnAddBor.UseVisualStyleBackColor = true;
            btnAddBor.Click += btnAddBor_Click;
            // 
            // dgvBorrowMan
            // 
            dgvBorrowMan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowMan.Location = new Point(38, 427);
            dgvBorrowMan.Name = "dgvBorrowMan";
            dgvBorrowMan.RowHeadersWidth = 51;
            dgvBorrowMan.Size = new Size(1041, 308);
            dgvBorrowMan.TabIndex = 13;
            dgvBorrowMan.CellClick += dgvBorrowMan_CellClick;
            dgvBorrowMan.CellContentClick += dgvBorrowMan_CellContentClick;
            // 
            // dtDOB
            // 
            dtDOB.Location = new Point(623, 181);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(250, 27);
            dtDOB.TabIndex = 12;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(626, 117);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(247, 27);
            txtMail.TabIndex = 11;
            // 
            // txtPhoneBorrow
            // 
            txtPhoneBorrow.Location = new Point(267, 311);
            txtPhoneBorrow.Name = "txtPhoneBorrow";
            txtPhoneBorrow.Size = new Size(125, 27);
            txtPhoneBorrow.TabIndex = 10;
            // 
            // txtAddressBorrower
            // 
            txtAddressBorrower.Location = new Point(267, 248);
            txtAddressBorrower.Name = "txtAddressBorrower";
            txtAddressBorrower.Size = new Size(125, 27);
            txtAddressBorrower.TabIndex = 9;
            // 
            // txtNameBorrow
            // 
            txtNameBorrow.Location = new Point(267, 183);
            txtNameBorrow.Name = "txtNameBorrow";
            txtNameBorrow.Size = new Size(125, 27);
            txtNameBorrow.TabIndex = 8;
            // 
            // txtIDBorrow
            // 
            txtIDBorrow.Location = new Point(267, 121);
            txtIDBorrow.Name = "txtIDBorrow";
            txtIDBorrow.Size = new Size(125, 27);
            txtIDBorrow.TabIndex = 7;
            txtIDBorrow.TextChanged += txtIDBorrow_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(429, 51);
            label14.Name = "label14";
            label14.Size = new Size(322, 38);
            label14.TabIndex = 6;
            label14.Text = "Borrower Management";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(517, 186);
            label13.Name = "label13";
            label13.Size = new Size(40, 20);
            label13.TabIndex = 5;
            label13.Text = "DOB";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(517, 124);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 4;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(161, 314);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 3;
            label11.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(162, 251);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 2;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(162, 186);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 1;
            label9.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 124);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 0;
            label8.Text = "ID";
            // 
            // tabManLoan
            // 
            tabManLoan.Controls.Add(btnLogoutLoan);
            tabManLoan.Controls.Add(txtLoanID);
            tabManLoan.Controls.Add(label5);
            tabManLoan.Controls.Add(label22);
            tabManLoan.Controls.Add(dgvListLoan);
            tabManLoan.Controls.Add(btnClearLoan);
            tabManLoan.Controls.Add(btnDelLoan);
            tabManLoan.Controls.Add(btnUpLoan);
            tabManLoan.Controls.Add(btnAddLoan);
            tabManLoan.Controls.Add(dtpReturnDateLoan);
            tabManLoan.Controls.Add(dtpBorrowDateLoan);
            tabManLoan.Controls.Add(txtBorrowerIDLoan);
            tabManLoan.Controls.Add(txtBookLoanID);
            tabManLoan.Controls.Add(label20);
            tabManLoan.Controls.Add(label19);
            tabManLoan.Controls.Add(label18);
            tabManLoan.Controls.Add(label17);
            tabManLoan.Controls.Add(label15);
            tabManLoan.Location = new Point(4, 29);
            tabManLoan.Name = "tabManLoan";
            tabManLoan.Padding = new Padding(3);
            tabManLoan.Size = new Size(1122, 735);
            tabManLoan.TabIndex = 2;
            tabManLoan.Text = "Manage Loans";
            tabManLoan.UseVisualStyleBackColor = true;
            // 
            // btnLogoutLoan
            // 
            btnLogoutLoan.Location = new Point(981, 405);
            btnLogoutLoan.Name = "btnLogoutLoan";
            btnLogoutLoan.Size = new Size(94, 29);
            btnLogoutLoan.TabIndex = 20;
            btnLogoutLoan.Text = "Logout";
            btnLogoutLoan.UseVisualStyleBackColor = true;
            btnLogoutLoan.Click += btnLogoutLoan_Click;
            // 
            // txtLoanID
            // 
            txtLoanID.Location = new Point(322, 89);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(125, 27);
            txtLoanID.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 147);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 18;
            label5.Text = "Book ID";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(492, 382);
            label22.Name = "label22";
            label22.Size = new Size(166, 31);
            label22.TabIndex = 16;
            label22.Text = "List of Borrow";
            // 
            // dgvListLoan
            // 
            dgvListLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListLoan.Location = new Point(46, 440);
            dgvListLoan.Name = "dgvListLoan";
            dgvListLoan.RowHeadersWidth = 51;
            dgvListLoan.Size = new Size(1029, 272);
            dgvListLoan.TabIndex = 15;
            dgvListLoan.CellClick += dgvListLoan_CellClick;
            // 
            // btnClearLoan
            // 
            btnClearLoan.Location = new Point(885, 254);
            btnClearLoan.Name = "btnClearLoan";
            btnClearLoan.Size = new Size(94, 29);
            btnClearLoan.TabIndex = 14;
            btnClearLoan.Text = "Clear";
            btnClearLoan.UseVisualStyleBackColor = true;
            btnClearLoan.Click += btnClearLoan_Click;
            // 
            // btnDelLoan
            // 
            btnDelLoan.Enabled = false;
            btnDelLoan.Location = new Point(885, 198);
            btnDelLoan.Name = "btnDelLoan";
            btnDelLoan.Size = new Size(94, 29);
            btnDelLoan.TabIndex = 13;
            btnDelLoan.Text = "Delete";
            btnDelLoan.UseVisualStyleBackColor = true;
            btnDelLoan.Click += btnDelLoan_Click;
            // 
            // btnUpLoan
            // 
            btnUpLoan.Enabled = false;
            btnUpLoan.Location = new Point(728, 254);
            btnUpLoan.Name = "btnUpLoan";
            btnUpLoan.Size = new Size(94, 29);
            btnUpLoan.TabIndex = 12;
            btnUpLoan.Text = "Update";
            btnUpLoan.UseVisualStyleBackColor = true;
            btnUpLoan.Click += btnUpLoan_Click;
            // 
            // btnAddLoan
            // 
            btnAddLoan.Location = new Point(728, 200);
            btnAddLoan.Name = "btnAddLoan";
            btnAddLoan.Size = new Size(94, 29);
            btnAddLoan.TabIndex = 11;
            btnAddLoan.Text = "Add";
            btnAddLoan.UseVisualStyleBackColor = true;
            btnAddLoan.Click += btnAddLoan_Click;
            // 
            // dtpReturnDateLoan
            // 
            dtpReturnDateLoan.Location = new Point(729, 144);
            dtpReturnDateLoan.Name = "dtpReturnDateLoan";
            dtpReturnDateLoan.Size = new Size(250, 27);
            dtpReturnDateLoan.TabIndex = 10;
            // 
            // dtpBorrowDateLoan
            // 
            dtpBorrowDateLoan.Location = new Point(729, 87);
            dtpBorrowDateLoan.Name = "dtpBorrowDateLoan";
            dtpBorrowDateLoan.Size = new Size(250, 27);
            dtpBorrowDateLoan.TabIndex = 9;
            // 
            // txtBorrowerIDLoan
            // 
            txtBorrowerIDLoan.Location = new Point(322, 147);
            txtBorrowerIDLoan.Name = "txtBorrowerIDLoan";
            txtBorrowerIDLoan.Size = new Size(125, 27);
            txtBorrowerIDLoan.TabIndex = 8;
            // 
            // txtBookLoanID
            // 
            txtBookLoanID.Location = new Point(322, 202);
            txtBookLoanID.Name = "txtBookLoanID";
            txtBookLoanID.Size = new Size(125, 27);
            txtBookLoanID.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(430, 25);
            label20.Name = "label20";
            label20.Size = new Size(263, 38);
            label20.TabIndex = 5;
            label20.Text = "Loan Management";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(570, 147);
            label19.Name = "label19";
            label19.Size = new Size(88, 20);
            label19.TabIndex = 4;
            label19.Text = "Return Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(570, 90);
            label18.Name = "label18";
            label18.Size = new Size(93, 20);
            label18.TabIndex = 3;
            label18.Text = "Borrow Date";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(201, 202);
            label17.Name = "label17";
            label17.Size = new Size(89, 20);
            label17.TabIndex = 2;
            label17.Text = "Borrower ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(201, 92);
            label15.Name = "label15";
            label15.Size = new Size(24, 20);
            label15.TabIndex = 0;
            label15.Text = "ID";
            // 
            // AdminManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 760);
            Controls.Add(tabControl);
            Name = "AdminManagement";
            Text = "AdminManagement";
            Load += AdminManagement_Load;
            tabControl.ResumeLayout(false);
            tabManBook.ResumeLayout(false);
            tabManBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookManagementView).EndInit();
            tabManBorrow.ResumeLayout(false);
            tabManBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowMan).EndInit();
            tabManLoan.ResumeLayout(false);
            tabManLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabManBook;
        private TabPage tabManBorrow;
        private TabPage tabManLoan;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Button btnClear;
        private Button btnDel;
        private Button btnUpdate;
        private Button btnAdd;
        private DateTimePicker dtPublish;
        private TextBox txtAuthor;
        private TextBox txtName;
        private TextBox txtID;
        private DataGridView BookManagementView;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label14;
        private Label label13;
        private TextBox txtNameBorrow;
        private TextBox txtIDBorrow;
        private DateTimePicker dtDOB;
        private TextBox txtMail;
        private DataGridView dgvBorrowMan;
        private Button btnDelBor;
        private Button btnAddBor;
        private Button btnClearBor;
        private Button btnUpBor;
        private Button btnExit;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private DateTimePicker dtpReturnDateLoan;
        private DateTimePicker dtpBorrowDateLoan;
        private TextBox txtBorrowerIDLoan;
        private TextBox txtBookLoanID;
        private Label label22;
        private DataGridView dgvListLoan;
        private Button btnClearLoan;
        private Button btnDelLoan;
        private Button btnUpLoan;
        private Button btnAddLoan;
        private Label label23;
        private TextBox txtPhoneBorrow;
        private TextBox txtAddressBorrower;
        private Label label11;
        private Label label10;
        private TextBox txtPublishID;
        private Label label5;
        private TextBox txtLoanID;
        private TextBox txtAuthorName;
        private Label label16;
        private Button btnLogoutBor;
        private Button btnLogoutLoan;
    }
}