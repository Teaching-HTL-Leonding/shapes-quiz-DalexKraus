using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using ShapesQuiz.Model;
using Rectangle = ShapesQuiz.Model.Rectangle;

namespace ShapesQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ShapeBase> CreatedShapes { get; } = new();

        public List<ShapeBase> ShapeTypes { get; } = new()
        {
            new Rectangle(), new Triangle(), new Circle()
        };


        private ShapeBase _currentShapeModel;
        public ShapeBase CurrentShapeModel
        {
            get => _currentShapeModel;
            set
            {
                _currentShapeModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentShapeModel)));
            }
        }

        public double TotalArea => CreatedShapes.Sum(s => s.Area);

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void CreateShape_Click(object sender, RoutedEventArgs e)
        {
            var obj = CurrentShapeModel;
            CreatedShapes.Add(obj);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalArea)));
        }
    }
}