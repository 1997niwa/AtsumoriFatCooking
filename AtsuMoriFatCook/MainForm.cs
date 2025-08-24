using AtsuMoriFatCook.Properties;
using AtsuMoriFatCook.Recipe;
using AtsuMoriFatCook.Ingredient;

namespace AtsuMoriFatCook
{
    public partial class MainForm : Form
    {
        private readonly RecipeList _recipeList;
        private readonly IngredientList _ingredientList;
        private readonly Calculator _calculator;
        private Label[] labels;

        public MainForm()
        {
            InitializeComponent();

            this.Icon = Resource.Icon;
            this.Text = Resource.Title;

            _recipeList = new RecipeList();
            _fruitsComboBox.Text = Setting.Default.�f�t�H���g�t���[�c;
            _ingredientList = new IngredientList(Setting.Default.�f�t�H���g�t���[�c);
            _calculator = new Calculator(_recipeList, _ingredientList);

            DisplayRecipePanel();
            DisplayAddedValuePanel();
        }

        private void DisplayRecipePanel()
        {
            TableLayoutRowStyleCollection rowStyles = _recipePanel.RowStyles;
            foreach (RowStyle rowStyle in rowStyles)
            {
                if (rowStyle.SizeType == SizeType.Absolute) rowStyle.Height = 33;
            }

            for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
            {
                // ����Ƀ`�F�b�N�{�b�N�X
                CheckBox cb = new CheckBox();
                cb.Text = "";  // �`�F�b�N�{�b�N�X�̃e�L�X�g�͋�ɂ��č��[�ɔz�u�̂�
                cb.CheckAlign = ContentAlignment.MiddleLeft;   // �`�F�b�N�}�[�N������
                cb.Dock = DockStyle.Fill;   // �Z���Ƀt�B�b�g������
                if ((int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1) cb.CheckState = CheckState.Checked;
                _recipePanel.Controls.Add(cb, 0, i);

                // �E��Ƀe�L�X�g���x���Ȃ�
                Label lbl = new Label();
                lbl.Size = new Size(150, 25);
                lbl.Text = _recipeList.RecipeItems[i].Name;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                _recipePanel.Controls.Add(lbl, 1, i);
            }
        }

        private void DisplayAddedValuePanel()
        {
            TableLayoutRowStyleCollection rowStyles = _addedValuePanel.RowStyles;
            foreach (RowStyle rowStyle in rowStyles)
            {
                if (rowStyle.SizeType == SizeType.Absolute) rowStyle.Height = 18.5f;
            }

            TableLayoutColumnStyleCollection columnStyles = _addedValuePanel.ColumnStyles;
            foreach (ColumnStyle columnStyle in columnStyles)
            {
                if (columnStyle.SizeType == SizeType.Absolute) columnStyle.Width = 100;
            }

            var values = (IngredientEnum[])Enum.GetValues(typeof(IngredientEnum));
            for (int i = 0; i < _ingredientList.IngredientItems.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = _ingredientList.GetIngredientName(values[i]);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.TopLeft;
                lbl.Height = 18;
                _addedValuePanel.Controls.Add(lbl, 0, i);
            }

            labels = new Label[_ingredientList.IngredientItems.Count];
            for (int i = 0; i < _ingredientList.IngredientItems.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = "";
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.TopLeft;
                lbl.Height = 18;
                _addedValuePanel.Controls.Add(lbl, 1, i);
                labels[i] = lbl;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDisplayParameters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveDisplayParameters();

            int[] values = _calculator.CalculateAllAddedRecipe();
            for (int i = 0; i < _ingredientList.IngredientItems.Count; i++)
            {
                if (values[i] ==999) labels[i].Text = "���̂܂ܔ���܂��傤";
                else labels[i].Text = _recipeList.RecipeItems[values[i]].Name;
            }
        }

        private void SaveDisplayParameters()
        {
            Setting.Default.�f�t�H���g�t���[�c = _fruitsComboBox.Text;
            for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
            {
                Setting.Default[_recipeList.RecipeItems[i].Name] = ((CheckBox)_recipePanel.GetControlFromPosition(0, i)).Checked ? 1 : 0;
            }
            Setting.Default.Save();
        }
    }
}
