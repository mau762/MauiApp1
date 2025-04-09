namespace MauiApp1;

public partial class PeriodosRemover : ContentPage
{
    public PeriodosRemover()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}