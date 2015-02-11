using System;
using System.Windows.Forms;
using Reflexil.Forms;

namespace StrongNameRemover
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new StrongNameRemoverForm {FormBorderStyle = FormBorderStyle.Sizable, ShowInTaskbar = true});
		}
	}
}
