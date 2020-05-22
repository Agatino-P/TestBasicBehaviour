/// Add Nuget System.Windows.Interactivity.WPF


using System.Windows;

namespace TestBasicBehaviour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public double Translucent
        {
            get => (double)GetValue(TranslucentProperty);
            set => SetValue(TranslucentProperty, value);
        }

        // Using a DependencyProperty as the backing store for Translucent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TranslucentProperty =
            DependencyProperty.Register("Translucent", typeof(double), typeof(MainWindow), new PropertyMetadata(1.0));


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
