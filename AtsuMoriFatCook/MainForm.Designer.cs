namespace AtsuMoriFatCook
{
    partial class MainForm
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
            label1 = new Label();
            _tableLayoutPanel = new TableLayoutPanel();
            _fruitsComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 0;
            label1.Text = "島のデフォルトフルーツ\r\n";
            // 
            // _tableLayoutPanel
            // 
            _tableLayoutPanel.AutoScroll = true;
            _tableLayoutPanel.BackColor = Color.White;
            _tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            _tableLayoutPanel.ColumnCount = 2;
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            _tableLayoutPanel.Location = new Point(318, 12);
            _tableLayoutPanel.Name = "_tableLayoutPanel";
            _tableLayoutPanel.RowCount = 20;
            _tableLayoutPanel.RowStyles.Add(new RowStyle());
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tableLayoutPanel.Size = new Size(200, 340);
            _tableLayoutPanel.TabIndex = 1;
            // 
            // _fruitsComboBox
            // 
            _fruitsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _fruitsComboBox.FormattingEnabled = true;
            _fruitsComboBox.Items.AddRange(new object[] { "リンゴ", "オレンジ", "ナシ", "モモ", "さくらんぼ" });
            _fruitsComboBox.Location = new Point(140, 18);
            _fruitsComboBox.Name = "_fruitsComboBox";
            _fruitsComboBox.Size = new Size(121, 25);
            _fruitsComboBox.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(530, 357);
            Controls.Add(_fruitsComboBox);
            Controls.Add(_tableLayoutPanel);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Meiryo UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel _tableLayoutPanel;
        private ComboBox _fruitsComboBox;
    }
}
