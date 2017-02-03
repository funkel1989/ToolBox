using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;



namespace ToolBox
{
    /// <summary>
    /// Interaction logic for ScoreBoardBigViewWindow.xaml
    /// </summary>
    public partial class ScoreBoardBigViewWindow : Window
    {
        public ScoreBoardBigViewWindow()
        {
            InitializeComponent();
        }

        public class TextToColorConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (((int)value) > 0)
                    return Brushes.Yellow;
                else
                    // for default value 
                    return Brushes.Blue;
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                // no need to implement it 
                throw new NotImplementedException();
            }

        }
    }    
}
