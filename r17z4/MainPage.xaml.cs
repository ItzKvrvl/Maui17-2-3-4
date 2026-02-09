namespace r17z4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CountImages();
        }

        //klikniecie na obrazek
        private async void clyellow(object? sender, EventArgs e)
        {
            await DisplayAlert("Kliknieto", "to jest zolty", "ok");
        }

        private async void clred(object? sender, EventArgs e)
        {
            await DisplayAlert("Kliknieto", "to jest czerwony", "ok");
        }

        private async void clblue(object? sender, EventArgs e)
        {
            await DisplayAlert("Kliknieto", "to jest niebieski", "ok");
        }

        private async void clgreen(object? sender, EventArgs e)
        {
            await DisplayAlert("Kliknieto", "to jest zielony", "ok");
        }

        private async void clpink(object? sender, EventArgs e)
        {
            await DisplayAlert("Kliknieto", "to jest rozowy", "ok");
        }
        private async void clorange(object? sender, EventArgs e)
        {
            await DisplayAlert("Kliknieto", "to jest pomaranczowy", "ok");
        }

        //liczenie ilosci zdjec
        private void CountImages()
        {
            int count = 0;

            foreach(var child in ImagesGallery.Children)
            {
                if(child is Grid) count++;
            }
            ilosc.Text = $"Aktualna liczba zdjec: {count}";
        }
    }
}