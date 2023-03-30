using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
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
	public sealed partial class main_menu : Page
	{
		public main_menu()
		{
			this.InitializeComponent();
		}

		private void mathsCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage));
		}

		private void mortgageCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(Mortgage_Calculator_Page));
		}

		private void currencyConverterButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(Currency_Calculator_Page));
		}

		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{

		}

		private void TripCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			//Trip calculator C# code will be developed later
		}
	}
}
