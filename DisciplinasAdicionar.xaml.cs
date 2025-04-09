namespace MauiApp1;

public partial class DisciplinasAdicionar : ContentPage
{
    public DisciplinasAdicionar()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}