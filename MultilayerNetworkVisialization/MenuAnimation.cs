using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MultilayerNetworkVisialization
{
    public static class StoryboardLibrary
    {
        public enum MenuAnimOption
        {
            Hide,
            Show
        }

        public enum MoveDirection
        {
            UpDown,
            RightLeft
        }

        public static Storyboard MenuAnim(UIElement obj, MenuAnimOption option, double size, MoveDirection moveDirection)
        {
            Storyboard storyboard = new Storyboard();
            DoubleAnimation doubleAnim = new DoubleAnimation();
            obj.RenderTransform = new TranslateTransform();

            if (option == MenuAnimOption.Hide)
            {
                doubleAnim.From = 0;
                doubleAnim.To = size;
            }

            if (option == MenuAnimOption.Show)
            {
                doubleAnim.From = size;
                doubleAnim.To = 0;
            }

            doubleAnim.Duration = new Duration(TimeSpan.FromSeconds(3));
            doubleAnim.EasingFunction = new QuarticEase();

            Storyboard.SetTarget(doubleAnim, obj);
            //Storyboard.SetTargetName(transformXAnim, obj.Name);
            if (moveDirection == MoveDirection.RightLeft)
                Storyboard.SetTargetProperty(doubleAnim, new PropertyPath("(FrameworkElement.RenderTransform).(TranslateTransform.X)"));
            else if (moveDirection == MoveDirection.UpDown)
                Storyboard.SetTargetProperty(doubleAnim, new PropertyPath("(FrameworkElement.RenderTransform).(TranslateTransform.Y)"));

            //Storyboard.SetTargetProperty(transformXAnim, "(UIElement.RenderTransform).(CompositeTransform.ScaleX)");

            storyboard.Children.Add(doubleAnim);

            return storyboard;
        }
    }
}

