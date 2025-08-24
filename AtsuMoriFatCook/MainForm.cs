using AtsuMoriFatCook.Properties;

namespace AtsuMoriFatCook
{
    public partial class MainForm : Form
    {

        private readonly RecipeList _recipeList;
        public MainForm()
        {
            InitializeComponent();

            this.Icon = Resource.Icon;
            this.Text = Resource.Title;

            _recipeList = new RecipeList();

            //TableLayoutColumnStyleCollection columnStyles = _tableLayoutPanel.ColumnStyles;
            //foreach (ColumnStyle style in columnStyles)
            //{
            //    if (style.SizeType == SizeType.Percent)
            //    {
            //        style.Width = 15;
            //    }
            //}

            TableLayoutRowStyleCollection rowStyles = _tableLayoutPanel.RowStyles;
            foreach (RowStyle rowStyle in rowStyles)
            {
                if (rowStyle.SizeType == SizeType.Absolute)
                {
                    rowStyle.Height = 33;
                }
            }

            for (int i = 0; i < _recipeList.SettingItems.Count; i++)
            {
                // 左列にチェックボックス
                CheckBox cb = new CheckBox();
                cb.Text = "";  // チェックボックスのテキストは空にして左端に配置のみ
                cb.CheckAlign = ContentAlignment.MiddleLeft;   // チェックマークを左寄せ
                cb.Dock = DockStyle.Fill;   // セルにフィットさせる
                if ((int)Setting.Default[_recipeList.SettingItems[i].Name] == 1) cb.CheckState = CheckState.Checked;
                _tableLayoutPanel.Controls.Add(cb, 0, i);

                // 右列にテキストラベルなど
                Label lbl = new Label();
                lbl.Text = _recipeList.SettingItems[i].Name;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                _tableLayoutPanel.Controls.Add(lbl, 1, i);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < _recipeList.SettingItems.Count; i++)
            {
                Setting.Default[_recipeList.SettingItems[i].Name] = ((CheckBox)_tableLayoutPanel.GetControlFromPosition(0, i)).Checked ? 1 : 0;
            }
            Setting.Default.Save();
        }
    }
}
