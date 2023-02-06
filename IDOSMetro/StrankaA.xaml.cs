namespace IDOSMetro;

public partial class StrankaA : ContentPage
{
	string[] staniceA =
	{
		"Depo Hostivaø", "Skalka", "Strašnická", "Želivského", "Flora",
		"Jiøího z Podìbrad", "Námìstí Míru", "Muzeum", "Mùstek", 
		"Staromìstská", "Malostranská", "Hradèanská", "Dejvická", 
		"Boøislavka", "Nádraží Veleslavín", "Petøiny", "Nemocnice Motol"
	};
	public StrankaA()
	{
		InitializeComponent();
		pckStanice1.ItemsSource = staniceA;
		pckStanice1.SelectedItem = pckStanice1.Items[0];
		pckStanice2.ItemsSource = staniceA;
        pckStanice2.SelectedItem = pckStanice1.Items[0];
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		int indexOdjezd = pckStanice1.SelectedIndex;
        int indexPrijezd = pckStanice2.SelectedIndex;

		int vzdalenost = Math.Abs(indexOdjezd - indexPrijezd);
		DisplayAlert("Odhadovaný èas cesty", vzdalenost * 2 + " minut", "OK");
    }
}