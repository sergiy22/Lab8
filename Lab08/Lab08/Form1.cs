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
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPhonesInfo.Text +=
                string.Format("Фірма: {0} | Операційна система: {1} | RAM: {2} | Частота процесора: {3} | Кількість ядер: {4}|  [{5} | {6}] | ",
                phone.Firm, phone.Operating_Systems, phone.RAM,
                phone.Processor_frequency, phone.Number_of_cores,
                phone.HasMini_jack ? "Є Роз'єм для наушників" : "Немає роз'єму",
                phone.HasGPS ? "Є GPS" : "Немає GPS");
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
           "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
