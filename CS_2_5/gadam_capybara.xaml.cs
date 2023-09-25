using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS_2_5
{
    /// <summary>
    /// Логика взаимодействия для gadam_capybara.xaml
    /// </summary>
    public partial class gadam_capybara : UserControl
    {
        public int Index { get; private set; }
        public bool Started { get; private set; }

        public gadam_capybara(string path, string name, bool marked, int ll)
        {
            InitializeComponent();
            shish_capy.Source = new BitmapImage(new Uri(path));
            boxxx.Content = name;
            boxxx.IsChecked = marked;
            Index = ll;
            Started = true;

            // Присоединяем обработчики событий
            boxxx.Checked += BoxChecked;
            boxxx.Unchecked += BoxUnchecked;
        }

        private void BoxChecked(object sender, RoutedEventArgs e)
        {
            UpdatePageCheckedState(true);
        }

        private void BoxUnchecked(object sender, RoutedEventArgs e)
        {
            UpdatePageCheckedState(false);
        }

        private void UpdatePageCheckedState(bool isChecked)
        {
            var page = FindPage();
            if (page != null)
            {
                page.elements[Index].ch_ = isChecked;

                if (isChecked && !page.checked_values.Contains(Index))
                {
                    page.checked_values.Add(Index);
                }
                else if (!isChecked && page.checked_values.Contains(Index))
                {
                    page.checked_values.Remove(Index);
                }

                page.UpdateLytoPage();
            }
        }

        private Page2 FindPage()
        {
            var parentStackPanel = Parent as StackPanel;
            var parentScrollViewer = parentStackPanel?.Parent as ScrollViewer;
            var parentGrid = parentScrollViewer?.Parent as Grid;
            return parentGrid?.Parent as Page2;
        }
    }
}
