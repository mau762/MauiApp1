namespace MauiApp1;

public partial class Cursos : ContentPage
{
    public Cursos()
    {
        InitializeComponent();
    }

    private async void OnPesquisarCursosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CursosPesquisar());
    }

    private async void OnAdicionarCursoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CursosAdicionar());
    }

    private async void OnRemoverCursosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CursosRemover());
    }

    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}