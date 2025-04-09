namespace MauiApp1;

public partial class Periodos : ContentPage
{
    public Periodos()
    {
        InitializeComponent();
    }
    private async void OnPesquisarPeriodosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PeriodosPesquisar());
    }

    private async void OnAdicionarPeriodoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PeriodosAdicionar());
    }

    private async void OnRemoverPeriodosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PeriodosRemover());
    }

    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}