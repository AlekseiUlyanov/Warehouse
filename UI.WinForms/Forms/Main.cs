using Application.Equips.Dto;
using Application.Equips.Services;

namespace UI.WinForms.Forms
{
    public partial class Main : Form
    {
        private readonly IEquipService _equipService;

        public Main(IEquipService equipService)
        {
            _equipService = equipService;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EquipDto equipDto = new()
                {
                    Serial = tbSerial.Text.Trim(),
                    Type = tbType.Text.Trim(),
                    Model = tbModel.Text.Trim()
                };

                _equipService.Create(equipDto);

                UpdateListBox();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка при добавлении оборудования",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка при добавлении оборудования",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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

            foreach (var d in _equipService.GetAll())
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
