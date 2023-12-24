using System;
using System.Windows.Forms;

namespace WebcamApp;

internal static class Program
{
	/// <summary>
	///     Der Haupteinstiegspunkt für die Anwendung.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			Application.Run(new CameraForm());
		}
		catch (ObjectDisposedException cancelButtonPressed)
		{
			//Error handling for the case that the user pressed the cancel button
		}

	}
}