using System;
using Eto;
using Eto.Forms;

namespace PostMachine.EtoGui
{
	public class Program
	{
		[STAThread]
		static void Main ()
		{
			Generator generator;
			
			if (Eto.Misc.Platform.IsWindows)
			{
				generator = Generator.GetGenerator("Eto.Platform.Windows.Generator, Eto.Platform.Windows");
			}
			else if (Eto.Misc.Platform.IsMac)
			{
				generator = Generator.GetGenerator("Eto.Platform.Mac.Generator, Eto.Platform.Mac");
			}
			else // use GTK#
			{
				generator = Generator.GetGenerator("Eto.Platform.GtkSharp.Generator, Eto.Platform.Gtk");
			}
			
			var app = new Application(generator);
			app.Initialized += delegate {
				app.MainForm = new MainForm();
				app.MainForm.Show();
			};
				
			app.Run();
		}
	}
}

