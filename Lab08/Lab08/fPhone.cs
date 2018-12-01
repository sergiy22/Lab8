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
    public partial class fPhone : Form
    {
        private Phone ThePhone;
        internal fPhone(Phone t)
        {
            ThePhone = t;
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePhone.Firm = tbFirm.Text.Trim();
            ThePhone.Operating_Systems = tbOperating_Systems.Text.Trim();
            ThePhone.RAM = int.Parse(tbRAM.Text.Trim());
            ThePhone.Processor_frequency = double.Parse(tbProcessor_frequency.Text.Trim());
            ThePhone.Number_of_cores = int.Parse(tbNumber_of_cores.Text.Trim());
            ThePhone.HasMini_jack = chbHasMini_jack.Checked;
            ThePhone.HasGPS = chbHasGPS.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPhone_Load(object sender, EventArgs e)
        {
            if (ThePhone != null)
            {
                tbFirm.Text = ThePhone.Firm;
                tbOperating_Systems.Text = ThePhone.Operating_Systems;
                tbRAM.Text = ThePhone.RAM.ToString();
                tbProcessor_frequency.Text = ThePhone.Processor_frequency.ToString();
                tbNumber_of_cores.Text = ThePhone.Number_of_cores.ToString();
                chbHasMini_jack.Checked = ThePhone.HasMini_jack;
                chbHasGPS.Checked = ThePhone.HasGPS;
            }
        }
        private void tbCores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

    }
}
