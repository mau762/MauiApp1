namespace MauiApp1;

public partial class CursosPesquisar : ContentPage
{
    public CursosPesquisar()
    {
        InitializeComponent();
    }

    private async void OnPesquisarClicked(object sender, EventArgs e)
    {

        var cursoPesquisado = PesquisarCursoEntry.Text;

        if (!string.IsNullOrWhiteSpace(cursoPesquisado))
        {
            await Navigation.PushAsync(new DisciplinasDoCurso(cursoPesquisado));
        }
        else
        {
            await DisplayAlert("Erro", "Por favor, insira o nome do curso.", "OK");
        }
    }

    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
