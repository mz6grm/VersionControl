using hatodik.Entities;
using hatodik.MnbServiceReference;
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
using System.Xml;

namespace hatodik
{
	public partial class Form1 : Form
	{
		BindingList<RateData> Rates = new BindingList<RateData>();
		public Form1()
		{
			InitializeComponent();
			RefreshData();
		}

		private void RefreshData()
		{
			Rates.Clear();
			Fuggveny();
			dataGridView1.DataSource = Rates;
			chartRateData.DataSource = Rates;
			Fuggveny2();
			Fuggveny3();
		}

		string result;
		public void Fuggveny()
		{
			dataGridView1.DataSource = Rates;
			var mnbService = new MNBArfolyamServiceSoapClient();
			var request = new GetExchangeRatesRequestBody() //ezt kéne módosítani még (7.)
			{
				currencyNames = "EUR",
				startDate = "2020-01-01",
				endDate = "2020-06-30"
			};
			var response = mnbService.GetExchangeRates(request);
			result = response.GetExchangeRatesResult;
		}		
		private void Fuggveny2()
		{
			var xml = new XmlDocument();
			xml.LoadXml(result);
			foreach (XmlElement element in xml.DocumentElement)
			{
				// Létrehozzuk az adatsort és rögtön hozzáadjuk a listához
				// Mivel ez egy referencia típusú változó, megtehetjük, hogy előbb adjuk a listához és csak később töltjük fel a tulajdonságait
				var rate = new RateData();
				Rates.Add(rate);

				// Dátum
				rate.Date = DateTime.Parse(element.GetAttribute("date"));
				
				// Valuta
				var childElement = (XmlElement)element.ChildNodes[0];
				rate.Currency = childElement.GetAttribute("curr");

				// Érték
				var unit = decimal.Parse(childElement.GetAttribute("unit"));
				var value = decimal.Parse(childElement.InnerText);
				if (unit != 0)
					rate.Value = value / unit;
			}			
		}
		private void Fuggveny3()
		{
			chartRateData.DataSource = Rates;

			var series = chartRateData.Series[0];
			series.ChartType = SeriesChartType.Line;
			series.XValueMember = "Date";
			series.YValueMembers = "Value";
			series.BorderWidth = 2;

			var legend = chartRateData.Legends[0];
			legend.Enabled = false;

			var chartArea = chartRateData.ChartAreas[0];
			chartArea.AxisX.MajorGrid.Enabled = false;
			chartArea.AxisY.MajorGrid.Enabled = false;
			chartArea.AxisY.IsStartedFromZero = false;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshData();
		}
	}
}
