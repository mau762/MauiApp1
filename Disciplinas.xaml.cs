namespace MauiApp1;

public partial class Disciplinas : ContentPage
{
    public Disciplinas()
    {
        InitializeComponent();
    }
    private async void OnPesquisarDisciplinasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisciplinasPesquisar());
    }

    private async void OnAdicionarDisciplinaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisciplinasAdicionar());
    }

    private async void OnRemoverDisciplinasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisciplinasRemover());
    }

    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }




}