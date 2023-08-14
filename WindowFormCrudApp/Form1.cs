using Microsoft.EntityFrameworkCore;
using WindowFormCrudApp.Models;

namespace WindowFormCrudApp
{
	public partial class Form1 : Form
	{
		private form_crudContext _crudContext;
		Customer customer;
		//List<Customer> cusList;
		public Form1()
		{
			InitializeComponent();
			_crudContext = new form_crudContext();
			customer = new Customer();
			//cusList = _crudContext.Customers.Select(c=>c).ToList();
			//foreach (Customer customer in cusList)
			//{
			//	label1.Text += customer.ToString();
			//}
		}
		void Clear()
		{
			txtFirstName.Text = txtLastName.Text = txtCity.Text = "";
			btnSave.Text = "Save";
			btnDelete.Enabled = false;
			customer.Id = 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Clear();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			Clear();
			PopulateDataGridView();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			customer.FirstName = txtFirstName.Text.Trim();
			customer.LastName = txtLastName.Text.Trim();
			customer.City = txtCity.Text.Trim();

			if (customer.Id == 0)//Insert Operation
				_crudContext.Customers.Add(customer);
			else//Update operation
				_crudContext.Customers.Update(customer);
			_crudContext.SaveChanges();
			Clear();
			PopulateDataGridView();
			MessageBox.Show("Submitted Successfully");

		}

		void PopulateDataGridView()
		{
			dgvCustomer.AutoGenerateColumns = false;
			dgvCustomer.DataSource = _crudContext.Customers.ToList<Customer>();
		}

		private  void dgvCustomer_DoubleClick(object sender, EventArgs e)
		{
			if(dgvCustomer.CurrentRow.Index != -1)
			{
				customer.Id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["id"].Value);
				customer = _crudContext.Customers.Where(x=>x.Id==customer.Id).FirstOrDefault();
				txtFirstName.Text = customer.FirstName;
				txtLastName.Text = customer.LastName;
				txtCity.Text = customer.City;
				btnSave.Text = "Update";
				btnDelete.Enabled = true;
			}
		}
	}
}