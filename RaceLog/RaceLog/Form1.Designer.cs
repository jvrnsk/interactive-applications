
namespace RaceLog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblDriver = new Label();
            txtDriver = new TextBox();
            lblCar = new Label();
            cmbCar = new ComboBox();
            lblTrack = new Label();
            cmbTrack = new ComboBox();
            lblTime = new Label();
            txtTime = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            lblResults = new Label();
            lstResults = new ListBox();
            btnDelete = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Font = new Font("Segoe UI", 14F);
            lblDriver.Location = new Point(34, 32);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(82, 32);
            lblDriver.TabIndex = 0;
            lblDriver.Text = "Пилот";
            // 
            // txtDriver
            // 
            txtDriver.Location = new Point(190, 32);
            txtDriver.Margin = new Padding(3, 4, 3, 4);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(290, 27);
            txtDriver.TabIndex = 1;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Font = new Font("Segoe UI", 14F);
            lblCar.Location = new Point(34, 88);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(150, 32);
            lblCar.TabIndex = 2;
            lblCar.Text = "Автомобиль";
            lblCar.Click += lblCar_Click;
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCar.FormattingEnabled = true;
            cmbCar.Items.AddRange(new object[] { "Street", "Sport", "Prototype" });
            cmbCar.Location = new Point(190, 94);
            cmbCar.Margin = new Padding(3, 4, 3, 4);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(290, 28);
            cmbCar.TabIndex = 2;
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.Font = new Font("Segoe UI", 14F);
            lblTrack.Location = new Point(34, 141);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(87, 32);
            lblTrack.TabIndex = 3;
            lblTrack.Text = "Трасса";
            // 
            // cmbTrack
            // 
            cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrack.FormattingEnabled = true;
            cmbTrack.Items.AddRange(new object[] { "Учебный овал", "Городское кольцо", "Спринт" });
            cmbTrack.Location = new Point(190, 145);
            cmbTrack.Margin = new Padding(3, 4, 3, 4);
            cmbTrack.Name = "cmbTrack";
            cmbTrack.Size = new Size(290, 28);
            cmbTrack.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 14F);
            lblTime.Location = new Point(34, 194);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(146, 32);
            lblTime.TabIndex = 4;
            lblTime.Text = "Время (сек.)";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(190, 200);
            txtTime.Margin = new Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(290, 27);
            txtTime.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(34, 253);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(206, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(251, 253);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(206, 41);
            btnClear.TabIndex = 6;
            btnClear.Text = "Очистить поля";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 14F);
            lblResults.Location = new Point(514, 35);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(231, 32);
            lblResults.TabIndex = 7;
            lblResults.Text = "Результаты заездов";
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true;
            lstResults.Location = new Point(514, 71);
            lstResults.Margin = new Padding(3, 4, 3, 4);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(438, 384);
            lstResults.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13F);
            btnDelete.Location = new Point(514, 476);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(284, 41);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить выбранную";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 14F);
            lblStatus.Location = new Point(34, 353);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(446, 106);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Готово к работе";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 583);
            Controls.Add(lblDriver);
            Controls.Add(txtDriver);
            Controls.Add(lblCar);
            Controls.Add(cmbCar);
            Controls.Add(lblTrack);
            Controls.Add(cmbTrack);
            Controls.Add(lblTime);
            Controls.Add(txtTime);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(lblResults);
            Controls.Add(lstResults);
            Controls.Add(btnDelete);
            Controls.Add(lblStatus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Журнал заездов";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.ComboBox cmbTrack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
    }
}
