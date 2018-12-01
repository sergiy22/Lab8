using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fMain : Form
    {
        private BindingList<Phone> phones = new BindingList<Phone>();
        public fMain()
        {
            InitializeComponent();
            tbPhonesInfo.DataSource = phones;
            tbPhonesInfo.DisplayMember = "Firm";
            tbPhonesInfo.SelectedIndexChanged += new EventHandler(tbPhonesInfo_SelectedIndexChanged);
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                phones.Add(phone);
             
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", 
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
        private void tbPhonesInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string family = tbPhonesInfo.SelectedValue.ToString();

            Phone phone = (Phone)tbPhonesInfo.SelectedItem;
            MessageBox.Show("Фірма: " + phone.Firm + " " +
            phone.Operating_Systems + " | Операційна система: " +
            phone.RAM + " | RAM: " +
            phone.Processor_frequency + " | Частота процесора: " +
            phone.Number_of_cores + " | Кількість ядер: " +
            phone.HasMini_jack + " | Наявність роз'єму для наушників: " +
            phone.HasGPS, "Наявність GPS");
        }
    }
}
