namespace CalculatorforInformatika;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
		string oldText = e.OldTextValue;
		string newText = e.NewTextValue;
		string input = entry.Text;
	}

	public void OnEntryCompleted(object sender, EventArgs e)
	{
		string text = ((Entry)sender).Text;
	}

	public void Euclids(object sender, EventArgs e, string[] args)
    {
		string Text = ((Entry)sender).Text;

		int x = Int32.Parse(Text);
		int y = Int32.Parse(Text);

		int nsd = EuclidsAlgorithm.EvklidovAlgoritem.NSDRecursive(x, y);
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		CounterLabel.Text = $"Hi";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

