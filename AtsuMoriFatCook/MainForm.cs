using AtsuMoriFatCook.Properties;
using System.Drawing;

namespace AtsuMoriFatCook
{
    public partial class MainForm : Form
    {
        private readonly ListRetention _listRetention;
        public MainForm()
        {
            InitializeComponent();

            this.Icon = Resource.Icon;
            this.Text = Resource.Title;

            _listRetention = new ListRetention();

            for (int i = 0; i < _listRetention.SettingItems.Count; i++)
            {
                // 左列にチェックボックス
                CheckBox cb = new CheckBox();
                cb.Text = "";  // チェックボックスのテキストは空にして左端に配置のみ
                cb.CheckAlign = ContentAlignment.MiddleLeft;   // チェックマークを左寄せ
                cb.Dock = DockStyle.Fill;   // セルにフィットさせる
                if (_listRetention.SettingItems[i] == 1) cb.CheckState = CheckState.Checked;
                _tableLayoutPanel.Controls.Add(cb, 0, i);

                // 右列にテキストラベルなど
                Label lbl = new Label();
                lbl.Text = nameof(_listRetention.SettingItems[i]);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                _tableLayoutPanel.Controls.Add(lbl, 1, i);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < _listRetention.SettingItems.Count; i++)
            {
                _listRetention.SettingItems[i] = ((CheckBox)_tableLayoutPanel.GetControlFromPosition(0, i)).Checked ? 1 : 0;
            }
        }
    }
}
