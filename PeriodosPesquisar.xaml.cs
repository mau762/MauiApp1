namespace MauiApp1;

public partial class PeriodosPesquisar : ContentPage
{
    public PeriodosPesquisar()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}