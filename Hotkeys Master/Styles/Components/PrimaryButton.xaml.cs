using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Hotkeys_Master.Styles.Components
{
    /// <summary>
    /// Логика взаимодействия для PrimaryButton.xaml
    /// </summary>
    public partial class PrimaryButton : UserControl
    {
        public PrimaryButton()
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
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(PrimaryButton));

        /// <summary>
        /// Button Icon
        /// </summary>
        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(PackIconMaterialKind), typeof(PrimaryButton));

        /// <summary>
        /// Button Background
        /// </summary>
        public new SolidColorBrush Background
        {
            get { return (SolidColorBrush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register(nameof(Background), typeof(SolidColorBrush), typeof(PrimaryButton));

        /// <summary>
        /// Button Command
        /// </summary>
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(PrimaryButton), new PropertyMetadata(null));
    }
}
