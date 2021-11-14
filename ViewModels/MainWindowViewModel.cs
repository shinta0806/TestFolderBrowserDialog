using Livet;
using Livet.Messaging.IO;

using System.Windows;

namespace TestFolderBrowserDialog.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		public static void AddFolderSelected(FolderSelectionMessage folderSelectionMessage)
		{
			if (folderSelectionMessage.Response == null)
			{
				MessageBox.Show("キャンセル");
			}
			else
			{
				MessageBox.Show(folderSelectionMessage.Response[0]);
			}
		}

		// Some useful code snippets for ViewModel are defined as l*(llcom, llcomn, lvcomm, lsprop, etc...).
		public static void Initialize()
		{
		}
	}
}
