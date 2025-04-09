namespace MauiApp1;

public partial class CursosAdicionar : ContentPage
{
    public CursosAdicionar()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}