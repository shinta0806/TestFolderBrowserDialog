using Livet;

using System;
using System.Windows;

namespace TestFolderBrowserDialog
{
	public partial class App : Application
	{
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			DispatcherHelper.UIDispatcher = Dispatcher;
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
		}

		// Application level error handling
		private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			String message = "Something errors were occurred.";
			if (e.ExceptionObject is Exception excep)
			{
				message += "\n" + excep.Message;
			}
			MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			Environment.Exit(1);
		}
	}
}
