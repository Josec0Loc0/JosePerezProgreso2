namespace Progreso2JosePerez.JpViews;

public partial class JpRecargaPagina : ContentPage
{
    private const string FileName = "JosePerez.txt";
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

      
        var recarga = new Progreso2JosePerez.JpModels.RecargaJp
        {
            Nombre = nombre,
            Numero = numero
        };


        File.WriteAllText(FileName, recarga.ToString());

        // Mostrar mensaje de éxito
        Jp_Label3.Text = "¡Recarga exitosa!";
        Jp_Label3.TextColor = Colors.Green;

        
        CargarUltimaRecarga();

        // Limpiar formulario
        Jp_Entry1.Text = string.Empty;
        Jp_Entry2.Text = string.Empty;
    }

    private void CargarUltimaRecarga()
    {
        if (File.Exists(FileName))
        {
            Jp_Label5.Text = File.ReadAllText(FileName);
        }
        else
        {
            Jp_Label5.Text = "No hay recargas registradas.";
        }
    }
}