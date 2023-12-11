using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FloatingLabelTextBox.CustomControls
{
    public class FloatingLabelTextBox : Control
    {
        static FloatingLabelTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FloatingLabelTextBox), new FrameworkPropertyMetadata(typeof(FloatingLabelTextBox)));
        }
        public static readonly DependencyProperty LabelTextProperty =
           DependencyProperty.Register("LabelText", typeof(string), typeof(FloatingLabelTextBox), new PropertyMetadata("LabelText"));

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly DependencyProperty LabelForegroundProperty =
            DependencyProperty.Register("LabelForeground", typeof(Brush), typeof(FloatingLabelTextBox), new PropertyMetadata(Brushes.AliceBlue));

        public Brush LabelForeground
        {
            get { return (Brush)GetValue(LabelForegroundProperty); }
            set { SetValue(LabelForegroundProperty, value); }
        }


        public static readonly DependencyProperty LabelFontSizeProperty =
            DependencyProperty.Register("LabelFontSize", typeof(double), typeof(FloatingLabelTextBox), new PropertyMetadata(10.0));

        public double LabelFontSize
        {
            get { return (double)GetValue(LabelFontSizeProperty); }
            set { SetValue(LabelFontSizeProperty, value); }
        }

    }
}
