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
            _recipePanel = new TableLayoutPanel();
            _fruitsComboBox = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            button1 = new Button();
            _addedValuePanel = new TableLayoutPanel();
            tabPage2 = new TabPage();
            label3 = new Label();
            button2 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            // _recipePanel
            // 
            _recipePanel.AutoScroll = true;
            _recipePanel.BackColor = Color.White;
            _recipePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            _recipePanel.ColumnCount = 2;
            _recipePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            _recipePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            _recipePanel.Location = new Point(318, 12);
            _recipePanel.Name = "_recipePanel";
            _recipePanel.RowCount = 20;
            _recipePanel.RowStyles.Add(new RowStyle());
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _recipePanel.Size = new Size(200, 433);
            _recipePanel.TabIndex = 1;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 49);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(289, 396);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(_addedValuePanel);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(281, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "付加価値";
            // 
            // label2
            // 
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(198, 41);
            label2.TabIndex = 2;
            label2.Text = "料理の売値から材料の売値を引いた額が最も高いレシピを計算します。";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Location = new Point(210, 7);
            button1.Name = "button1";
            button1.Size = new Size(65, 38);
            button1.TabIndex = 1;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _addedValuePanel
            // 
            _addedValuePanel.BackColor = Color.White;
            _addedValuePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            _addedValuePanel.ColumnCount = 2;
            _addedValuePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _addedValuePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _addedValuePanel.Location = new Point(6, 55);
            _addedValuePanel.Name = "_addedValuePanel";
            _addedValuePanel.RowCount = 14;
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _addedValuePanel.Size = new Size(269, 302);
            _addedValuePanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(281, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "早さ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(198, 41);
            label3.TabIndex = 5;
            label3.Text = "料理の完成までにかかる時間が最も短いレシピを計算します。";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Location = new Point(210, 7);
            button2.Name = "button2";
            button2.Size = new Size(65, 38);
            button2.TabIndex = 4;
            button2.Text = "計算";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.77695F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.22305F));
            tableLayoutPanel2.Location = new Point(6, 50);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(269, 210);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(530, 457);
            Controls.Add(tabControl1);
            Controls.Add(_fruitsComboBox);
            Controls.Add(_recipePanel);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Meiryo UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel _recipePanel;
        private ComboBox _fruitsComboBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel _addedValuePanel;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
