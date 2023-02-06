namespace IDOSMetro;

public partial class StrankaB : ContentPage
{
    string[] staniceB =
    {
        "Zlièín", "Stodùlky", "Luka", "Lužiny", "Hùrka", "Nové Butovice", "Jinonice", "Radlická", "Smíchovské nádraží", "Andìl", "Karlovo námìstí",  
        "Národní tøída", "Mùstek", "Námìstí republiky", "Florenc", "Køižíkova", "Invalidovna", "Palmovka", "Èeskomoravská", "Vysoèanská", "Kolbenova", "Hloubìtín", "Rajská zahrada", "Èerný most"
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
        DisplayAlert("Odhadovaný èas cesty", vzdalenost * 2 + " minut", "OK");
    }
}