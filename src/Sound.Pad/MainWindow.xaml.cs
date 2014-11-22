using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Sound.Pad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeBehaviour();
        }

        private void InitializeBehaviour()
        {
            var toggleButtons = Enumerable.Range(0, VisualTreeHelper.GetChildrenCount(Grid))
                .Select(index => VisualTreeHelper.GetChild(Grid, index) as ToggleButton)
                .Where(item => item != null)
                .Select((item, index) => new { ToggleButton = item, Index = index});
            foreach (var item in toggleButtons)
            {
                item.ToggleButton.Tag = item.Index;
                item.ToggleButton.Click += ToggleButton_OnClick;
            }
        }

        private void ToggleButton_OnClick(object sender, RoutedEventArgs e)
        {
            var button = sender as ToggleButton;
            if (button == null)
                return;
            var index = (int) button.Tag;

            throw new NotImplementedException();
        }
    }
}
