using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Инанов_Егор_Курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sklad__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sklad__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Zakupka__". При необходимости она может быть перемещена или удалена.
            this.zakupka__TableAdapter.Fill(this.dataSet1.Zakupka__);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Proizvoditel_". При необходимости она может быть перемещена или удалена.
            this.proizvoditel_TableAdapter.Fill(this.dataSet1.Proizvoditel_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Prodazha_". При необходимости она может быть перемещена или удалена.
            this.prodazha_TableAdapter.Fill(this.dataSet1.Prodazha_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavshchik_". При необходимости она может быть перемещена или удалена.
            this.postavshchik_TableAdapter.Fill(this.dataSet1.Postavshchik_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.dataSet1.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Sklad__". При необходимости она может быть перемещена или удалена.
            this.sklad__TableAdapter.Fill(this.dataSet1.Sklad__);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void sklad__BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sklad__BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sklad__BindingSource.EndEdit();
            sklad__TableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tovarBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tovarBindingSource.EndEdit();
            tovarTableAdapter.Update(dataSet1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            postavshchik_BindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            postavshchik_BindingSource.EndEdit();
            postavshchik_TableAdapter.Update(dataSet1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prodazha_BindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            prodazha_BindingSource.EndEdit();
            prodazha_TableAdapter.Update(dataSet1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            proizvoditel_BindingSource.AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            proizvoditel_BindingSource.EndEdit();
            proizvoditel_TableAdapter.Update(dataSet1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            zakupka__BindingSource.AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            zakupka__BindingSource.EndEdit();
            zakupka__TableAdapter.Update(dataSet1);
        }
    }
    
}
