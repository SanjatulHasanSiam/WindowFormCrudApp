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
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			customer.FirstName = txtFirstName.Text.Trim();
			customer.LastName = txtLastName.Text.Trim();
			customer.City = txtCity.Text.Trim();
			_crudContext.Customers.AddAsync(customer);
			_crudContext.SaveChanges();
			Clear();
			MessageBox.Show("Submitted Successfully");

		}
	}
}