using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace ChatBox
{

    /// <summary>
    /// A valuye convertor that will giveus direct XAML usage
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="cuture"></param>
    /// <returns></returns>
    public abstract class BaseValueConvertor<T> : MarkupExtension, IValueConverter
        where T: class, new()
    {

        #region Value Convertor Methods


        /// <summary>
        /// The Method to convert value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="cuture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo cuture);

        /// <summary>
        /// Method To convert Back to its source type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="cuture"></param>
        /// <returns></returns>

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo cuture);
        #endregion

        #region Conversion and implementing in XAML Class 
        private static T mConvertor = null;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {


            return mConvertor ?? (mConvertor = new T());
        }


        #endregion
    }
}
