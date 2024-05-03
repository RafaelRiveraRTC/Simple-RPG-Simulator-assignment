using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simple_RPG_Simulator_assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            cmbNames.Items.Add("warrior");
            cmbNames.Items.Add("wizard");
            cmbNames.Items.Add("ranger");
            cmbNames.Items.Add("warlock");
            cmbNames.Items.Add("druid");
            cmbNames.Items.Add("monk");
            cmbNames.Items.Add("paladin");
            cmbNames.Items.Add("cleric");
            cmbNames.Items.Add("barberian");
            cmbNames.Items.Add("bard");
            cmbNames.Items.Add("rouge");
            cmbNames.Items.Add("artificer");
            cmbNames.Items.Add("sorcerer");
            cmbNames.Items.Add("blood hunter");
        }
    }
}