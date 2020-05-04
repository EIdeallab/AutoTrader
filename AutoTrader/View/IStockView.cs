using AxKHOpenAPILib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoTrader.View
{
    public interface IMainView
    {
        Presenter.StockPresenter Presenter { get; set; }
        APIExtention kHOpenAPI { get; }
        Chart MainChart { get; set; }

        int SelectedMinuteUnit { get; }
        Label ItemNameLabel { get; set; }
        Label TotalStockLabel { get; set; }
        Label DistribRatioLabel { get; set; }
        Label VolumeChangeLabel { get; set; }
        Label PerLabel { get; set; }
        Label EpsLabel { get; set; }
        Label RoeLabel { get; set; }
        Label PbrLabel { get; set; }
        Label EvLabel { get; set; }

        Label PcpLabel { get; set; }
        Label DayPcpLabel { get; set; }
        Label DayErnLabel { get; set; }
        Label AccPcpLabel { get; set; }
        Label AccErnLabel { get; set; }
        Label TotBuyLabel { get; set; }
        ListView AssetList { get; set; }
        ListView StockList { get; set; }
        ListView FunctionList { get; set; }
        ComboBox AccountListbox { get; set; }
        Series PriceSeries { get; set; }
        Series VolumeSeries { get; set; }
        Series IndicatorSeries { get; set; }
        Series AskSeries { get; set; }
        Series BidSeries { get; set; }
    }

    public interface IConditionView
    {
        Presenter.StockPresenter Presenter { get; set; }

        ListBox ConditionListBox { get; set; }
        Button ConformConditionButton { get; set; }
        Button CancelConditionButton { get; set; }
    }

    public interface IDisclosureView
    {
        Presenter.StockPresenter Presenter { get; set; }
        ListView DisclosureListView { get; set; }
    }
}
