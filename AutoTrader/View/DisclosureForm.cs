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
    public partial class DisclosureForm : Form, IDisclosureView
    {
        public Presenter.StockPresenter Presenter { get; set; }

        public ListView DisclosureListView
        {
            get { return disclosureListview; }
            set { disclosureListview = value; }
        }

        public DisclosureForm()
        {
            InitializeComponent();
        }

        private void DisclosureList_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = disclosureListview.SelectedItems[0];
            var CorpCodeSubItem = firstSelectedItem.SubItems[2];
            var RCeptNumSubItem = firstSelectedItem.SubItems[3];
            Presenter.RequestDartViewer(RCeptNumSubItem.Text);
        }
    }
}
