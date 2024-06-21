using System.Diagnostics;

namespace TrainingMauiFundamentals;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
	
	protected override void OnStart()
	{
		Debug.WriteLine("OnStart called", "PSDEMO");
	}
}
