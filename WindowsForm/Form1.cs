using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>()
        {
            new Customer()
            {
                id = 1,
                jmeno = "Petr",
                prijmeni = "Olivka",
                vek = 40
            },
            new Customer()
            {
                id = 2,
                jmeno = "Jakub",
                prijmeni = "Pietrus",
                vek = 21
            }
        };


        public Form1()
        {
            InitializeComponent();
            this.Update();

            RoundButton btn = new RoundButton()
            {
                Left = 100,
                Top = 180,
                Width = 30,
                Height = 30
            };

            btn.MyButtonClick += AddCustomer_Click;
            this.Controls.Add(btn);
        }

        private void Update()
        {
            //this.dataGridView1.Rows.Clear();

            //this.dataGridView1.ColumnCount = 4;
            //this.dataGridView1.Columns[0].HeaderText = "ID";
            //this.dataGridView1.Columns[1].HeaderText = "Jmeno";
            //this.dataGridView1.Columns[2].HeaderText = "Prijmeni";
            //this.dataGridView1.Columns[3].HeaderText = "Vek";

            //foreach (var customer in customers)
            //{
            //    this.dataGridView1.Rows.Add(customer.id, customer.jmeno, customer.prijmeni, customer.vek);
            //}

            this.dataGridView1.Columns.Clear();

            this.dataGridView1.AutoGenerateColumns = false;

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Jmeno",
                DataPropertyName = nameof(Customer.jmeno)
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Prijmeni",
                DataPropertyName = nameof(Customer.prijmeni)
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Vek",
                DataPropertyName = nameof(Customer.vek)
            });

            this.dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "editovat",
                UseColumnTextForButtonValue = true
            });

            this.dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "smazat",
                UseColumnTextForButtonValue = true
            });

            this.dataGridView1.DataSource = customers;

            this.dataGridView1.CellClick += DataGridView1_CellClick;


        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex < 0 || e.RowIndex < 0) {return;}

            DataGridView grid = (DataGridView) sender;
            var col = grid.Columns[e.ColumnIndex];
            if (!(col is DataGridViewButtonColumn))
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                Customer customer = this.customers[e.RowIndex];

                EditDialog dialog = new EditDialog(customer);
                dialog.ShowDialog();
            }
            
            else if (e.ColumnIndex == 4)
            {
                this.customers.RemoveAt(e.RowIndex);
            }

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Customer _customer = new Customer();

            EditDialog editDialog = new EditDialog(_customer);
            editDialog.ShowDialog();

            this.customers.Add(_customer);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string customerStr = JsonConvert.SerializeObject(customers);

            BindingList<Customer> newCustomers = JsonConvert.DeserializeObject<BindingList<Customer>>(customerStr);
        }
    }
}
