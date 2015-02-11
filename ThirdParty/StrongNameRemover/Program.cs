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
			var form = new StrongNameRemoverForm
			{
				FormBorderStyle = FormBorderStyle.Sizable,
				ShowInTaskbar = true,
				MaximizeBox = true,
				MinimizeBox = true
			};
			Application.Run(form);
		}
	}
}
