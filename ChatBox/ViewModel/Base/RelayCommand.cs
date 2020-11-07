

using System;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ChatBox
{
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// The event that fires when the CanExecute value has been changed...
        /// 
        /// 
        /// </summary>
        /// 
        /// 


        #region private materials

        private Action Maction;

        //maeke a function of action to run the constuctor will take the action we pass in and make it an action 
        //the action can contain command with lambda in tkinter but here we dun need to pass in anything...
        #endregion
        #region Constrtuctor

        public RelayCommand(Action Act)
        {

            Maction = Act;
            

        }

        #endregion

        /// <summary>
        ///        Making this region codable by letting all actions to be true 
        ///        So that they all will be carrided out fast and easy
        /// </summary>

        public event EventHandler CanExecuteChanged =(sender, e)=>{};

        public bool CanExecute(object parameter)
        {
            return true;//so that the button or file will be always executable
        }
  

        public void Execute(object parameter)
        {

           Maction();
        }



    }
}
