using Livet;
using Livet.Messaging.IO;

using System.Windows;

namespace TestFolderBrowserDialog.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		public void AddFolderSelected(FolderSelectionMessage folderSelectionMessage)
		{
			MessageBox.Show(folderSelectionMessage.Response[0]);
		}

		// Some useful code snippets for ViewModel are defined as l*(llcom, llcomn, lvcomm, lsprop, etc...).
		public void Initialize()
		{
		}
	}
}
