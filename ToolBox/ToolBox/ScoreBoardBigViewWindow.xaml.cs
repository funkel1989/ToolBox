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
        int calls = 4;

        public ScoreBoardBigViewWindow()
        {
            InitializeComponent();
        }

        public Brush BackColor
        {
            
            
            get
            {
                if (calls > 0) return Brushes.Yellow;
                return Brushes.WhiteSmoke;
            }
        }
    }
}
