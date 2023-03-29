using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Currency_Calculator_Page : Page
	{
		//public List<FromCurrency> FromCurrencyList { get; set; }
		//public List<ToCurrency> ToCurrencyList { get; set; }
		public const double USD_TO_EUR = 0.85189982;
		public const double USD_TO_GBP = 0.72872436;
		public const double USD_TO_INR = 74.257327;
		public const double EUR_TO_USD = 1.1739732;
		public const double EUR_TO_GBP = 0.8556672;
		public const double EUR_TO_INR = 87.00755;
		public const double GBP_TO_USD = 1.371907;
		public const double GBP_TO_EUR = 1.1686692;
		public const double GBP_TO_INR = 101.68635;
		public const double INR_TO_EUR = 0.011492628;
		public const double INR_TO_USD = 0.013492774;
		public const double INR_TO_GBP = 0.0098339397;
		public Currency_Calculator_Page()
		{
			this.InitializeComponent();
			//FromCurrencyList = new List<FromCurrency>();
			//ToCurrencyList = new List<ToCurrency>();
			//FromCurrencyList.Add(new FromCurrency("USD - US Dollar", "images/USA1.png"));
			//FromCurrencyList.Add(new FromCurrency("EUR - Euro", "images/eur1.png"));
			//FromCurrencyList.Add(new FromCurrency("GBP - UK Pound", "images/uk1.png"));
			//FromCurrencyList.Add(new FromCurrency("INR - India Rupee", "images/India1.png"));
			//ToCurrencyList.Add(new ToCurrency("USD - US Dollar", "images/USA1.png"));
			//ToCurrencyList.Add(new ToCurrency("EUR - Euro", "images/eur1.png"));
			//ToCurrencyList.Add(new ToCurrency("GBP - UK Pound", "images/uk1.png"));
			//ToCurrencyList.Add(new ToCurrency("INR - India Rupee", "images/India1.png"));
		}

		//public class FromCurrency : INotifyPropertyChanged
		//{
		//	private string name;
		//	private string path;

		//	public string FromCurrencyName
		//	{
		//		get { return name; }
		//		set
		//		{
		//			if (name == value) return;
		//			name = value;
		//			OnPropertyChanged("FromCurrencyName");
		//		}
		//	}
		//	public string FromCurrencyImage
		//	{
		//		get { return path; }
		//		set
		//		{
		//			if (path == value) return;
		//			path = value;
		//			OnPropertyChanged("FromCurrencyImage");
		//		}
		//	}
		//	public FromCurrency(string name, string path)
		//	{
		//		this.FromCurrencyName = name;
		//		this.FromCurrencyImage = path;
		//	}
		//	public event PropertyChangedEventHandler PropertyChanged;
		//	protected void OnPropertyChanged(string name)
		//	{
		//		PropertyChangedEventHandler handler = PropertyChanged;
		//		if (handler != null)
		//		{
		//			handler(this, new PropertyChangedEventArgs(name));
		//		}
		//	}
		//}
		//public class ToCurrency : INotifyPropertyChanged
		//{
		//	private string name;
		//	private string path;

		//	public string ToCurrencyName
		//	{
		//		get { return name; }
		//		set
		//		{
		//			if (name == value) return;
		//			name = value;
		//			OnPropertyChanged("ToCurrencyName");
		//		}
		//	}
		//	public string ToCurrencyImage
		//	{
		//		get { return path; }
		//		set
		//		{
		//			if (path == value) return;
		//			path = value;
		//			OnPropertyChanged("ToCurrencyImage");
		//		}
		//	}
		//	public ToCurrency(string name, string path)
		//	{
		//		this.ToCurrencyName = name;
		//		this.ToCurrencyImage = path;
		//	}
		//	public event PropertyChangedEventHandler PropertyChanged;
		//	protected void OnPropertyChanged(string name)
		//	{
		//		PropertyChangedEventHandler handler = PropertyChanged;
		//		if (handler != null)
		//		{
		//			handler(this, new PropertyChangedEventArgs(name));
		//		}
		//	}
		//}

		private void convertButton_Click(object sender, RoutedEventArgs e)
		{
			double amountInput;
			string fromCurrency;
			string toCurrency;
			amountInput = Convert.ToDouble(amountTextBox.Text.ToString());
			fromCurrency = (this.fromComboBox.SelectedItem as ComboBoxItem).Content.ToString();
			toCurrency = (this.toComboBox.SelectedItem as ComboBoxItem).Content.ToString();
			inputDisplayBlock.Text = amountTextBox.Text.ToString() + fromCurrency.Substring(0, 3) + "=";
			
			double exchangeRate;
			if (fromCurrency.Equals("USD - US Dollar"))
			{
				if (toCurrency.Equals("EUR - Euro"))
				{
					exchangeRate = USD_TO_EUR;
				}
				else if(toCurrency.Equals("GBP - UK Pound"))
				{
					exchangeRate = USD_TO_GBP;
				}
				else if(toCurrency.Equals("INR - India Rupee"))
				{
					exchangeRate = USD_TO_INR;
				}
				else
				{
					exchangeRate = 1;
				}
			}
			else if(fromCurrency.Equals("GBP - UK Pound"))
			{
				if (toCurrency.Equals("EUR - Euro"))
				{
					exchangeRate = GBP_TO_EUR;
				}
				else if (toCurrency.Equals("USD - US Dollar"))
				{
					exchangeRate = GBP_TO_USD;
				}
				else if (toCurrency.Equals("INR - India Rupee"))
				{
					exchangeRate = GBP_TO_INR;
				}
				else
				{
					exchangeRate = 1;
				}
			}
			else if(fromCurrency.Equals("EUR - Euro"))
			{
				if (toCurrency.Equals("USD - US Dollar"))
				{
					exchangeRate = EUR_TO_USD;
				}
				else if (toCurrency.Equals("GBP - UK Pound"))
				{
					exchangeRate = EUR_TO_GBP;
				}
				else if (toCurrency.Equals("INR - India Rupee"))
				{
					exchangeRate = EUR_TO_INR;
				}
				else
				{
					exchangeRate = 1;
				}
			}
			else
			{
				if (toCurrency.Equals("EUR - Euro"))
				{
					exchangeRate = INR_TO_EUR;
				}
				else if (toCurrency.Equals("GBP - UK Pound"))
				{
					exchangeRate = INR_TO_GBP;
				}
				else if (toCurrency.Equals("USD - US Dollar"))
				{
					exchangeRate = INR_TO_USD;
				}
				else
				{
					exchangeRate = 1;
				}
			}
			converterBlock.Text = (amountInput * exchangeRate).ToString();
			currencyBlock.Text = "1 " + fromCurrency.Substring(0,3) + " = " + exchangeRate.ToString() + toCurrency.Substring(0, 3);
			reverseBlock.Text = "1 " + toCurrency.Substring(0,3) + (1 / exchangeRate).ToString() + fromCurrency.Substring(0, 3);
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
