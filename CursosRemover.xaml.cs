namespace MauiApp1;

public partial class CursosRemover : ContentPage
{
    public CursosRemover()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}