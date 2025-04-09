namespace MauiApp1;

public partial class DisciplinasRemover : ContentPage
{
    public DisciplinasRemover()
    {
        InitializeComponent();
    }
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}