
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceLog
{
    public partial class Form1 : Form
    {
        // Минимальное и максимальное время заезда.
        private const int MinLapSeconds = 30;
        private const int MaxLapSeconds = 600;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Журнал заездов";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1000, 550);
            this.MinimumSize = new Size(1016, 589);
            this.Font = new Font("Segoe UI", 10);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;

            cmbCar.SelectedIndex = 0;
            cmbTrack.SelectedIndex = 0;

            this.AutoScaleMode = AutoScaleMode.None;
        }

        // Добавление новой записи.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string driver = txtDriver.Text.Trim();

            if (driver.Length == 0)
            {
                ShowError("Введите имя пилота");
                txtDriver.Focus();
                return;
            }

            if (cmbCar.SelectedIndex < 0 || cmbTrack.SelectedIndex < 0)
            {
                ShowError("Выберите автомобиль и трассу");
                return;
            }

            string timeText = txtTime.Text.Trim();

            bool valid = int.TryParse(timeText, out int seconds);

            if (!valid)
            {
                ShowError("Время должно быть целым числом");
                txtTime.Focus();
                return;
            }

            if (seconds < MinLapSeconds || seconds > MaxLapSeconds)
            {
                ShowError("Время должно быть от 30 до 600 секунд");
                txtTime.Focus();
                return;
            }

            string record = $"{driver} | {cmbCar.Text} | {cmbTrack.Text} | {seconds} с";

            lstResults.Items.Add(record);

            ClearInput();

            lblStatus.Text = "Добавлено. Всего записей: " + lstResults.Items.Count;
        }

        // Удаление выбранной записи.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstResults.SelectedIndex;

            if (index < 0)
            {
                ShowError("Сначала выберите запись в списке");
                return;
            }

            lstResults.Items.RemoveAt(index);

            lblStatus.Text = $"Запись удалена. Всего записей: {lstResults.Items.Count}";
        }

        // Очистка полей ввода.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();

            lblStatus.Text = "Поля очищены. Результаты сохранены в списке";
        }

        // Очистка полей и восстановление значений по умолчанию.
        private void ClearInput()
        {
            txtDriver.Clear();
            txtTime.Clear();

            cmbCar.SelectedIndex = 0;
            cmbTrack.SelectedIndex = 0;

            txtDriver.Focus();
        }

        // Вывод сообщения об ошибке.
        private void ShowError(string message)
        {
            lblStatus.Text = message;
        }

        // Обработчик Label, оставшийся в дизайнере Visual Studio.
        private void label1_Click(object sender, EventArgs e)
        {
            // Не используется.
        }

        private void lblCar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
