using AtsuMoriFatCook.Properties;
using AtsuMoriFatCook.Recipe;

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

            _recipeList = new RecipeList();
            _fruitsComboBox.Text = Setting.Default.�f�t�H���g�t���[�c;

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
                // ����Ƀ`�F�b�N�{�b�N�X
                CheckBox cb = new CheckBox();
                cb.Text = "";  // �`�F�b�N�{�b�N�X�̃e�L�X�g�͋�ɂ��č��[�ɔz�u�̂�
                cb.CheckAlign = ContentAlignment.MiddleLeft;   // �`�F�b�N�}�[�N������
                cb.Dock = DockStyle.Fill;   // �Z���Ƀt�B�b�g������
                if (_listRetention.SettingItems[i] == 1) cb.CheckState = CheckState.Checked;
                _tableLayoutPanel.Controls.Add(cb, 0, i);

                // �E��Ƀe�L�X�g���x���Ȃ�
                Label lbl = new Label();
                lbl.Text = nameof(_listRetention.SettingItems[i]);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                _tableLayoutPanel.Controls.Add(lbl, 1, i);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.Default.�f�t�H���g�t���[�c = _fruitsComboBox.Text;
            for (int i = 0; i < _recipeList.SettingItems.Count; i++)
            {
                _listRetention.SettingItems[i] = ((CheckBox)_tableLayoutPanel.GetControlFromPosition(0, i)).Checked ? 1 : 0;
            }
        }
    }
}
