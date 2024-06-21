using System.Diagnostics;

namespace TrainingMauiFundamentals;

public partial class MainPage : ContentPage
{
	int count = 0;
	private ChildPage? _childPage;
	
	// Use the null-coalescing operator to instantiate the ChildPage property
	public ChildPage ChildPage => _childPage ??= new();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void Button_OnClicked(object? sender, EventArgs e)
	{
		App.Current.ModalPopping += ModalPopping;
		Navigation.PushModalAsync(ChildPage);
	}
	
	private void ModalPopping(object? sender, ModalPoppingEventArgs e)
	{
		if (e.Modal == ChildPage)
		{
			Debug.WriteLine("ParentPage: " + sender?.GetType().Name, "PS");
			App.Current.ModalPopping -= ModalPopping;
		}
	}
}

