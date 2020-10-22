
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace ImagenesOpacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Image imagen;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void episodioImage_MouseEnter(object sender, MouseEventArgs e)
        {
            imagen = sender as Image;
            imagen.Opacity = 1;
        }

        private void episodioImage_MouseLeave(object sender, MouseEventArgs e)
        {
            imagen = sender as Image;
            imagen.Opacity = 0.5;
        }
    }
}
