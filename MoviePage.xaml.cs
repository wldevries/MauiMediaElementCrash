namespace MauiApp1;

public partial class MoviePage : ContentPage
{
	public MoviePage()
	{
		InitializeComponent();
        this.Unloaded += HandleUnloaded;
	}

    private void HandleUnloaded(object sender, EventArgs e)
    {
        try
        {
            // Stop and cleanup MediaElement when we navigate away
            mediaElement.Handler?.DisconnectHandler();
        }
        catch (Exception)
        { }
    }
}