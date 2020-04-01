using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTrader.View
{
    public partial class ConditionForm : Form, IConditionView
    {
        public Presenter.StockPresenter Presenter { get; set; }

        public ListBox ConditionListBox
        {
            get { return conditionListBox; }
            set { conditionListBox = value; }
        }

        public Button ConformConditionButton
        {
            get { return conformButton; }
            set { conformButton = value; }
        }

        public Button CancelConditionButton
        {
            get { return cancelButton; }
            set { cancelButton = value; }
        }

        public ConditionForm()
        {
            InitializeComponent();
        }

        private void ConformButton_Click(object sender, EventArgs e)
        {
            string item = conditionListBox.SelectedItem.ToString();
            {
                string[] keyVal = item.Split('^');
                int key = int.Parse(keyVal[0]);
                string condition = keyVal[1];

                Presenter.SendCondition(key, condition);
            }
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConditionForm_Load(object sender, EventArgs e)
        {
            if (!(conditionListBox.SelectedItem is null))
            {
                conformButton.Enabled = true;
            }
        }
    }
}
