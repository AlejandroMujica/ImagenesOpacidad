
using System.Windows;

using System.Windows.Input;


namespace ImagenesOpacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void episodioImage_MouseEnter(object sender, MouseEventArgs e)
        {
            if (episodioivImage.IsMouseOver)
            {
                episodioivImage.Opacity = 1;
            }
            else if (episodiovImage.IsMouseOver)
            {
                episodiovImage.Opacity = 1;
            }
            else
            {
                episodioviImage.Opacity = 1;
            }
        }

        private void episodioImage_MouseLeave(object sender, MouseEventArgs e)
        {
            episodioivImage.Opacity = 0.5;
            episodiovImage.Opacity = 0.5;
            episodioviImage.Opacity = 0.5;
        }
    }
}
