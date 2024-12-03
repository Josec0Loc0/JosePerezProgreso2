
namespace Progreso2JosePerez.JpViews;

public partial class JpRecargaPagina : ContentPage
{
    private readonly string FilePath = Path.Combine(FileSystem.AppDataDirectory, "JosePerez.txt");
    public JpRecargaPagina()
    {
        InitializeComponent();
        CargarUltimaRecarga();
    }

    private void OnRecargarClicked(object sender, EventArgs e)
    {
        string numero = Jp_Entry1.Text;
        string nombre = Jp_Entry2.Text;

        if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(nombre))
        {
            Jp_Label3.Text = "Por favor, complete todos los campos.";
            Jp_Label3.TextColor = Colors.Red;
            return;
        }

        
        var recarga = new JpModels.RecargaJp
        {
            Nombre = nombre,
            Numero = numero
        };

        // Guardar la información en el archivo
        File.WriteAllText(FilePath, recarga.ToString());

        Jp_Label3.Text = "¡Recarga exitosa!";
        Jp_Label3.TextColor = Colors.Green;

      
        CargarUltimaRecarga();

      
        Jp_Entry1.Text = string.Empty;
        Jp_Entry2.Text = string.Empty;
    }

    private void CargarUltimaRecarga()
    {
        if (File.Exists(FilePath))
        {
            Jp_Label5.Text = File.ReadAllText(FilePath);
        }
        else
        {
            Jp_Label5.Text = "No hay recargas registradas.";
        }
    }
}
