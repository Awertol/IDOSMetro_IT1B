namespace IDOSMetro;

public partial class StrankaB : ContentPage
{
    string[] staniceB =
    {
        "Zli��n", "Stod�lky", "Luka", "Lu�iny", "H�rka", "Nov� Butovice", "Jinonice", "Radlick�", "Sm�chovsk� n�dra��", "And�l", "Karlovo n�m�st�",  
        "N�rodn� t��da", "M�stek", "N�m�st� republiky", "Florenc", "K�i��kova", "Invalidovna", "Palmovka", "�eskomoravsk�", "Vyso�ansk�", "Kolbenova", "Hloub�t�n", "Rajsk� zahrada", "�ern� most"
    };
    public StrankaB()
    {
        InitializeComponent();
        pckStanice1.ItemsSource = staniceB;
        pckStanice1.SelectedItem = pckStanice1.Items[0];
        pckStanice2.ItemsSource = staniceB;
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