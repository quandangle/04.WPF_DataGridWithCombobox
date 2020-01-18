using System;
using Autodesk.Revit.DB;
using System.Windows;
using System.Windows.Input;

namespace QApps
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class AutoJoinWindow
    {
        private AutoJoinViewModel _viewModel;
        private Transaction trans;


        public AutoJoinWindow(AutoJoinViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
        }


        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
            // code
        }
    }
}
