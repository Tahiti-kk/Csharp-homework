using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form2 : Form
    {
        Order result = null;

        public Form2()
        {
            InitializeComponent();

            Goods iPod = new Goods("iPod", 1999);
            Goods iTouch = new Goods("iTouch", 3999);
            Goods iPad = new Goods("iPad", 5999);
            Goods iPhone = new Goods("iPhone", 7999);
            goodsBindingSource.Add(iPod);
            goodsBindingSource.Add(iTouch);
            goodsBindingSource.Add(iPad);
            goodsBindingSource.Add(iPhone);
        }

        public Order getResult()
        {
            return result;
        }

        private void goodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        public Form2(Order order) : this()
        {
            orderBindingSource.DataSource = order;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            result = (Order)orderBindingSource.Current;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
