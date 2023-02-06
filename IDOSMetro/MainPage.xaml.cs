namespace IDOSMetro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		DateTime soucasnyCas = DateTime.Now;
		if(soucasnyCas.Hour >= 0 && soucasnyCas.Hour <= 4)
		{
			labelCas.TextColor = Color.FromRgb(255, 20, 0);
			labelCas.Text = "Metro nyní nejezdí 😥";
		}
		else
		{
            labelCas.TextColor = Color.FromRgb(20, 255, 0);
            labelCas.Text = "Metro jezdí! 😎";
        }
	}

	
}

