using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChatBox
{//BaseView Model Fire PropertyChange as needed.
   
   public class BasicViewModel: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// pass in the value from our model.name
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }


    }
}
