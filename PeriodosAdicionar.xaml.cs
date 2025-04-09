namespace MauiApp1;

public partial class PeriodosAdicionar : ContentPage
{
    public PeriodosAdicionar()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}