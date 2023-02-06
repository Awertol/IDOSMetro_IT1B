namespace IDOSMetro;

public partial class StrankaC : ContentPage
{
    string[] staniceC =
    {
        "Let�any", "Prosek", "St��kov", "L�dv�", "Kobylisy", "N�dra�� Hole�ovice", "Vltavsk�", "Florenc", "Hlavn� n�dra��", "Muzeum",
        "I. P. Pavlova", "Vy�ehrad", "Pra�sk�ho povst�n�", "Pankr�c", "Bud�jovick�", "Ka�erov", "Roztyly", "Chodov", "Opatov", "H�je"
    };
    public StrankaC()
    {
        InitializeComponent();
        pckStanice1.ItemsSource = staniceC;
        pckStanice1.SelectedItem = pckStanice1.Items[0];
        pckStanice2.ItemsSource = staniceC;
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