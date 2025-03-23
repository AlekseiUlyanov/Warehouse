using System.Windows.Forms;
using UI_WinForms.Data;

namespace UI_WinForms
{
    public partial class Form1 : Form
    {
        private readonly IDataLayer data;

        public Form1()
        {
            InitializeComponent();
            data = new DataLayerInMemory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty)
            {
                MessageBox.Show(
                "Необходимо заполнить все поля",
                "Ошибка при добавлении оборудования",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }

            else
            {
                Equip equip = new();
                equip.Serial = textBox1.Text;
                equip.Type = textBox2.Text;
                equip.Model = textBox3.Text;
                data.Add(equip);
                UpdateListBox();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();

            foreach (var d in data.GetAll())
                listBox1.Items.Add(d);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
