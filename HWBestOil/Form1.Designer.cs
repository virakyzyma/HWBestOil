namespace HWBestOil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            GasolinePayGroupBox = new GroupBox();
            GasolinePayGroupBoxLabel = new Label();
            gasStationTotalLabel = new Label();
            label4 = new Label();
            AmountNumeric = new NumericUpDown();
            label5 = new Label();
            CountNumeric = new NumericUpDown();
            groupBox4 = new GroupBox();
            AmountRadioButton = new RadioButton();
            CountRadioButton = new RadioButton();
            label3 = new Label();
            PriceTextBox = new TextBox();
            GasolineComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            TotalToPayLabel = new Label();
            MiniCafeGroupBox = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            groupBox6 = new GroupBox();
            label8 = new Label();
            MiniCafeTotalLabel = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            PayButton = new Button();
            groupBox1.SuspendLayout();
            GasolinePayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).BeginInit();
            groupBox4.SuspendLayout();
            MiniCafeGroupBox.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GasolinePayGroupBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(AmountNumeric);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CountNumeric);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PriceTextBox);
            groupBox1.Controls.Add(GasolineComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 369);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // GasolinePayGroupBox
            // 
            GasolinePayGroupBox.Controls.Add(GasolinePayGroupBoxLabel);
            GasolinePayGroupBox.Controls.Add(gasStationTotalLabel);
            GasolinePayGroupBox.Location = new Point(13, 246);
            GasolinePayGroupBox.Name = "GasolinePayGroupBox";
            GasolinePayGroupBox.Size = new Size(200, 100);
            GasolinePayGroupBox.TabIndex = 11;
            GasolinePayGroupBox.TabStop = false;
            GasolinePayGroupBox.Text = "К оплате";
            // 
            // GasolinePayGroupBoxLabel
            // 
            GasolinePayGroupBoxLabel.AutoSize = true;
            GasolinePayGroupBoxLabel.Location = new Point(120, 46);
            GasolinePayGroupBoxLabel.Name = "GasolinePayGroupBoxLabel";
            GasolinePayGroupBoxLabel.Size = new Size(29, 15);
            GasolinePayGroupBoxLabel.TabIndex = 14;
            GasolinePayGroupBoxLabel.Text = "грн.";
            // 
            // gasStationTotalLabel
            // 
            gasStationTotalLabel.AutoSize = true;
            gasStationTotalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gasStationTotalLabel.Location = new Point(53, 38);
            gasStationTotalLabel.Name = "gasStationTotalLabel";
            gasStationTotalLabel.Size = new Size(22, 25);
            gasStationTotalLabel.TabIndex = 13;
            gasStationTotalLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 198);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "грн.";
            // 
            // AmountNumeric
            // 
            AmountNumeric.Location = new Point(137, 190);
            AmountNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmountNumeric.Name = "AmountNumeric";
            AmountNumeric.Size = new Size(89, 23);
            AmountNumeric.TabIndex = 8;
            AmountNumeric.ValueChanged += AmountNumeric_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 156);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 10;
            label5.Text = "л.";
            // 
            // CountNumeric
            // 
            CountNumeric.Location = new Point(137, 148);
            CountNumeric.Name = "CountNumeric";
            CountNumeric.Size = new Size(89, 23);
            CountNumeric.TabIndex = 7;
            CountNumeric.ValueChanged += CountNumeric_ValueChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(AmountRadioButton);
            groupBox4.Controls.Add(CountRadioButton);
            groupBox4.Location = new Point(7, 126);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(124, 105);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // AmountRadioButton
            // 
            AmountRadioButton.AutoSize = true;
            AmountRadioButton.Location = new Point(6, 64);
            AmountRadioButton.Name = "AmountRadioButton";
            AmountRadioButton.Size = new Size(63, 19);
            AmountRadioButton.TabIndex = 1;
            AmountRadioButton.TabStop = true;
            AmountRadioButton.Text = "Сумма";
            AmountRadioButton.UseVisualStyleBackColor = true;
            AmountRadioButton.CheckedChanged += CountOrPriceRadioButton_CheckedChanged;
            // 
            // CountRadioButton
            // 
            CountRadioButton.AutoSize = true;
            CountRadioButton.Checked = true;
            CountRadioButton.Location = new Point(6, 22);
            CountRadioButton.Name = "CountRadioButton";
            CountRadioButton.Size = new Size(90, 19);
            CountRadioButton.TabIndex = 0;
            CountRadioButton.TabStop = true;
            CountRadioButton.Text = "Количество";
            CountRadioButton.UseVisualStyleBackColor = true;
            CountRadioButton.CheckedChanged += CountOrPriceRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 89);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "грн.";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Enabled = false;
            PriceTextBox.Location = new Point(66, 81);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(135, 23);
            PriceTextBox.TabIndex = 5;
            // 
            // GasolineComboBox
            // 
            GasolineComboBox.FormattingEnabled = true;
            GasolineComboBox.Location = new Point(66, 42);
            GasolineComboBox.Name = "GasolineComboBox";
            GasolineComboBox.Size = new Size(135, 23);
            GasolineComboBox.TabIndex = 4;
            GasolineComboBox.SelectedIndexChanged += GasolineComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 84);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Бензин";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 57);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 12;
            label7.Text = "грн.";
            // 
            // TotalToPayLabel
            // 
            TotalToPayLabel.AutoSize = true;
            TotalToPayLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TotalToPayLabel.Location = new Point(368, 49);
            TotalToPayLabel.Name = "TotalToPayLabel";
            TotalToPayLabel.Size = new Size(22, 25);
            TotalToPayLabel.TabIndex = 0;
            TotalToPayLabel.Text = "0";
            // 
            // MiniCafeGroupBox
            // 
            MiniCafeGroupBox.Controls.Add(label11);
            MiniCafeGroupBox.Controls.Add(label10);
            MiniCafeGroupBox.Controls.Add(groupBox6);
            MiniCafeGroupBox.Location = new Point(301, 12);
            MiniCafeGroupBox.Name = "MiniCafeGroupBox";
            MiniCafeGroupBox.Size = new Size(300, 369);
            MiniCafeGroupBox.TabIndex = 1;
            MiniCafeGroupBox.TabStop = false;
            MiniCafeGroupBox.Text = "Мини-кафе";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(205, 45);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 14;
            label11.Text = "Количество";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(123, 42);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 12;
            label10.Text = "Цена";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(MiniCafeTotalLabel);
            groupBox6.Location = new Point(6, 246);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 100);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "К оплате";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(145, 40);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 12;
            label8.Text = "грн.";
            // 
            // MiniCafeTotalLabel
            // 
            MiniCafeTotalLabel.AutoSize = true;
            MiniCafeTotalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MiniCafeTotalLabel.Location = new Point(73, 36);
            MiniCafeTotalLabel.Name = "MiniCafeTotalLabel";
            MiniCafeTotalLabel.Size = new Size(22, 25);
            MiniCafeTotalLabel.TabIndex = 0;
            MiniCafeTotalLabel.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(PayButton);
            groupBox3.Controls.Add(TotalToPayLabel);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(12, 415);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 115);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Всего к оплате";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PayButton
            // 
            PayButton.Location = new Point(89, 39);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(98, 51);
            PayButton.TabIndex = 0;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 542);
            Controls.Add(groupBox3);
            Controls.Add(MiniCafeGroupBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GasolinePayGroupBox.ResumeLayout(false);
            GasolinePayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            MiniCafeGroupBox.ResumeLayout(false);
            MiniCafeGroupBox.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox MiniCafeGroupBox;
        private GroupBox groupBox3;
        private Button PayButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ComboBox GasolineComboBox;
        private TextBox PriceTextBox;
        private NumericUpDown AmountNumeric;
        private NumericUpDown CountNumeric;
        private GroupBox groupBox4;
        private RadioButton AmountRadioButton;
        private RadioButton CountRadioButton;
        private Label label3;
        private GroupBox GasolinePayGroupBox;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label TotalToPayLabel;
        private Label GasolinePayGroupBoxLabel;
        private Label gasStationTotalLabel;
        private Label label11;
        private Label label10;
        private GroupBox groupBox6;
        private Label label8;
        private Label MiniCafeTotalLabel;
    }
}
