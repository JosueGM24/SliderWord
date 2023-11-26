using Microsoft.Maui.Controls.Shapes;

namespace SliderWord
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            rotateThisObject.Text = message.Text;
        }

        private async void sliderRotate_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            await rotateThisObject.RotateTo((sliderRotate.Value * 360));
            degrees.Text = (sliderRotate.Value * 360) + "°";
        }

        private void sliderImg_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            imagePine.RotateTo((sliderImg.Value * 360));
        }
    }
}