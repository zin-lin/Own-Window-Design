using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatBox
{/// <summary>
 /// Our Own View Model For the own Window
 /// </summary>
    public class WindowViewModel : BasicViewModel
    {
      

        #region Private Members

        private Window Mwindow;
        private int OuteMargin = 10;
        private int WindowRadius = 10;
        /// <summary>
        /// Corner Radius and the default shadow of the window
        /// </summary>
        /// <param name="window"></param>
        #endregion

        #region Commands

        
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }
        /// <summary>
        /// Commands
        /// </summary>
        public RelayCommand MenuCommand { get; set; }




        #endregion


        #region Public Attributes
        /// <summary>
        /// Minimun Window Size: Height
        /// </summary>
        /// 

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        public double MinHeight { get; set; } = 400.0;

        /// <summary>
        /// Minimum Window Size: Width
        /// </summary>
        public double MinWidth { get; set; } = 400.0;

        public Thickness InnerContentPadding { get { return new Thickness(0); } }

        public string Test { get; set; } = "My String";

        public bool Borderless { get { return (Mwindow.WindowState == WindowState.Maximized); } }

        public int ResizeBorder { get { return Borderless ? 0 : 6; } }

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        public int OuterMarginSize
        {
            get
            {
                return Mwindow.WindowState == WindowState.Maximized ? 0 : OuteMargin;

            }
            set
            {
                OuteMargin = value;

            }
        }

        //simple property
        public int TitleHeight { get; set; } = 42;

        public GridLength TitlePro{ get { return new GridLength(TitleHeight+ ResizeBorder); } }

        public Thickness OuterMarginSizeThinkness
        {
            get
            {
                return new Thickness(OuterMarginSize);

            }
          
        }

        public int WindowRadiusSize
        {
            get
            {
                return Mwindow.WindowState == WindowState.Maximized ? 0 : WindowRadius;

            }
            set
            {
                WindowRadius = value;

            }
        }

        public CornerRadius WindowRadiusSizeRadius
        {
            get
            {
                return new CornerRadius(WindowRadiusSize);

            }
        }


        #endregion

        #region Costructor

        /// <summary>
        /// Make all The changes with Views and Models when Page Is Constructed
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {

            this.Mwindow = window;

            //Listen for Windows State Change

            Mwindow.StateChanged += (s, e) => {

                //Fire When Resized
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThinkness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowRadiusSize));
                OnPropertyChanged(nameof(WindowRadiusSizeRadius));
                OnPropertyChanged(nameof(ResizeBorder));
           

            };
            MinimizeCommand = new RelayCommand(() => Mwindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => Mwindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => Mwindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(Mwindow, GetMousePosition()));

            Mwindow.MinWidth = 400;
            Mwindow.MinHeight = 400;

            var resizerHelpeMe = new WindowResizer(Mwindow);


        }

        #region Helper Imports


        public Point GetMousePosition()
        {
            var position = Mouse.GetPosition(Mwindow);

            return new Point(position.X + Mwindow.Left, position.Y + Mwindow.Top);
        }

        #endregion
        #endregion

    }
}
