namespace WindowFormCrudApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			txtFirstName = new TextBox();
			btnSave = new Button();
			printDialog1 = new PrintDialog();
			dgvCustomer = new DataGridView();
			id = new DataGridViewTextBoxColumn();
			FirstName = new DataGridViewTextBoxColumn();
			LastName = new DataGridViewTextBoxColumn();
			City = new DataGridViewTextBoxColumn();
			txtLastName = new TextBox();
			label2 = new Label();
			txtCity = new TextBox();
			label3 = new Label();
			btnDelete = new Button();
			btnCancel = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(53, 30);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 0;
			label1.Text = "First Name:";
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(129, 27);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(100, 23);
			txtFirstName.TabIndex = 1;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(53, 231);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 2;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// printDialog1
			// 
			printDialog1.UseEXDialog = true;
			// 
			// dgvCustomer
			// 
			dgvCustomer.AllowUserToDeleteRows = false;
			dgvCustomer.BackgroundColor = SystemColors.ButtonHighlight;
			dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { id, FirstName, LastName, City });
			dgvCustomer.GridColor = SystemColors.ActiveCaption;
			dgvCustomer.Location = new Point(388, 12);
			dgvCustomer.Name = "dgvCustomer";
			dgvCustomer.ReadOnly = true;
			dgvCustomer.RowTemplate.Height = 25;
			dgvCustomer.Size = new Size(400, 426);
			dgvCustomer.TabIndex = 3;
			dgvCustomer.DoubleClick += dgvCustomer_DoubleClick;
			// 
			// id
			// 
			id.DataPropertyName = "id";
			id.HeaderText = "CustomerID";
			id.Name = "id";
			id.ReadOnly = true;
			id.Visible = false;
			// 
			// FirstName
			// 
			FirstName.DataPropertyName = "firstName";
			FirstName.HeaderText = "First Name";
			FirstName.Name = "FirstName";
			FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			LastName.DataPropertyName = "lastName";
			LastName.HeaderText = "Last Name";
			LastName.Name = "LastName";
			LastName.ReadOnly = true;
			// 
			// City
			// 
			City.DataPropertyName = "city";
			City.HeaderText = "City";
			City.Name = "City";
			City.ReadOnly = true;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(129, 67);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(100, 23);
			txtLastName.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(53, 75);
			label2.Name = "label2";
			label2.Size = new Size(66, 15);
			label2.TabIndex = 4;
			label2.Text = "Last Name:";
			// 
			// txtCity
			// 
			txtCity.Location = new Point(129, 108);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(100, 23);
			txtCity.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(53, 111);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 6;
			label3.Text = "City:";
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(144, 231);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 23);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(234, 231);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 2;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtCity);
			Controls.Add(label3);
			Controls.Add(txtLastName);
			Controls.Add(label2);
			Controls.Add(dgvCustomer);
			Controls.Add(btnCancel);
			Controls.Add(btnDelete);
			Controls.Add(btnSave);
			Controls.Add(txtFirstName);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form Crud App";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtFirstName;
		private Button btnSave;
		private PrintDialog printDialog1;
		private DataGridView dgvCustomer;
		private TextBox txtLastName;
		private Label label2;
		private TextBox txtCity;
		private Label label3;
		private Button btnDelete;
		private Button btnCancel;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn FirstName;
		private DataGridViewTextBoxColumn LastName;
		private DataGridViewTextBoxColumn City;
	}
}