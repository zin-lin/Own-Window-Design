using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox
{
    public class ApplicationPageValueConvertor : BaseValueConvertor<ApplicationPageValueConvertor>
    {
        /// <summary>
        /// This Class Will Be the Actual Value Convertor
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="cuture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo cuture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                default:
                    Debugger.Break();
                    return null;

            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo cuture)
        {
            throw new NotImplementedException();
        }
    }
}
