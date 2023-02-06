namespace IDOSMetro;

public partial class StrankaC : ContentPage
{
    string[] staniceC =
    {
        "Letòany", "Prosek", "Støížkov", "Ládví", "Kobylisy", "Nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží", "Muzeum",
        "I. P. Pavlova", "Vyšehrad", "Pražského povstání", "Pankrác", "Budìjovická", "Kaèerov", "Roztyly", "Chodov", "Opatov", "Háje"
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
        DisplayAlert("Odhadovaný èas cesty", vzdalenost * 2 + " minut", "OK");
    }
}