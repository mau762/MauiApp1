namespace MauiApp1;

public partial class DisciplinasPesquisar : ContentPage
{
    public DisciplinasPesquisar()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}