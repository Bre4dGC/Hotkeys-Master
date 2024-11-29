using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Hotkeys_Master.Styles.Components
{
    /// <summary>
    /// Логика взаимодействия для NavButton.xaml
    /// </summary>
    public partial class NavButton : UserControl
    {
        public NavButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button Iext
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(NavButton));

        /// <summary>
        /// Button Icon
        /// </summary>
        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(PackIconMaterialKind), typeof(NavButton));

        /// <summary>
        /// Button Command
        /// </summary>
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(NavButton), new PropertyMetadata(null));

        /// <summary>
        /// Button IsChecked
        /// </summary>
        public bool IsChecked
        {
            get { return (bool)GetValue(CheckedProperty); }
            set { SetValue(CheckedProperty, value); }
        }

        public static readonly DependencyProperty CheckedProperty =
            DependencyProperty.Register(nameof(IsChecked), typeof(bool), typeof(NavButton));
    }
}
