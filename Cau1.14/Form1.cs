namespace Cau1._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai mã!");
            }
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox.SelectedItems.Count > 0)
                {
                    listBox.Items.Remove(listBox.SelectedItems[0]);
                    for (int i = 0; i < comboBox_class.Items.Count; i++)
                    {
                        if (comboBox_class.Items[i].ToString() != comboBox_class.Text)
                        {
                            comboBox_class.Items.Add(comboBox_class.Text);
                        }
                    }

                    string item = txt_ma.Text + "; " + txt_name.Text + "; " + txt_address.Text + "; " + brithday.Value.ToString() + "; " + comboBox_class.Text;
                    listBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < comboBox_class.Items.Count; i++)
                {
                    if (comboBox_class.Items[i].ToString() != comboBox_class.Text)
                    {
                        comboBox_class.Items.Add(comboBox_class.Text);
                    }
                }

                string item = txt_ma.Text + "; " + txt_name.Text + "; " + txt_address.Text + "; " + brithday.Value.ToString() + "; " + comboBox_class.Text;
                listBox.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) { Application.Exit(); }
        }
    }
}