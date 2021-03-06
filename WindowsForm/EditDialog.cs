using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class EditDialog : Form
    {
        public EditDialog(Customer customer)
        {
            InitializeComponent();

            //this._customer = customer;
            //this.jmenoInput.Text = customer.jmeno;
            //this.prijmeniInput.Text = customer.prijmeni;
            //this.vekInput.Text = customer.vek.ToString();


            this.jmenoInput.DataBindings.Add(
                new Binding(nameof(TextBox.Text), customer, nameof(Customer.jmeno), true, DataSourceUpdateMode.OnPropertyChanged)
                );

            this.prijmeniInput.DataBindings.Add(
                new Binding(nameof(TextBox.Text), customer, nameof(Customer.prijmeni), true, DataSourceUpdateMode.OnPropertyChanged)
            );

            this.ulozitBtn.Click += UlozitBtn_Click;
        }

        private void UlozitBtn_Click(object sender, EventArgs e)
        {
            //_customer.jmeno = this.jmenoInput.Text;
            //_customer.prijmeni = this.prijmeniInput.Text;
            //_customer.vek = int.Parse(vekInput.Text);
            this.Close();
        }
    }
}
