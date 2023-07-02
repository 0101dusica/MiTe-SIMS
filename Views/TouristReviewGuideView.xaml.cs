using MiTe.Storage;
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
using System.Windows.Shapes;
using MiTe.ViewModels;

namespace MiTe.Views
{
    /// <summary>
    /// Interaction logic for TouristReviewGuideView.xaml
    /// </summary>
    public partial class TouristReviewGuideView : Window
    {
        public TouristReviewGuideView(MainStorage mainStorage)
        {
            InitializeComponent();
            DataContext = new TouristReviewGuideViewModel(mainStorage, this);
        }
    }
}
