using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Starcalc
{
	internal static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(mainForm: new Mainform());
		}
	}
}
