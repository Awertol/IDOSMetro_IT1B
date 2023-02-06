namespace IDOSMetro;

public partial class StrankaA : ContentPage
{
	string[] staniceA =
	{
		"Depo Hostiva�", "Skalka", "Stra�nick�", "�elivsk�ho", "Flora",
		"Ji��ho z Pod�brad", "N�m�st� M�ru", "Muzeum", "M�stek", 
		"Starom�stsk�", "Malostransk�", "Hrad�ansk�", "Dejvick�", 
		"Bo�islavka", "N�dra�� Veleslav�n", "Pet�iny", "Nemocnice Motol"
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
		DisplayAlert("Odhadovan� �as cesty", vzdalenost * 2 + " minut", "OK");
    }
}