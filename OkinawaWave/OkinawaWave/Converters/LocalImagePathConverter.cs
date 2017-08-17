using System;
using System.Globalization;
using Xamarin.Forms;

namespace OkinawaWave.Converters
{
    public class LocalImagePathConverter : IValueConverter
    {
        private static string _assembly;

        static LocalImagePathConverter()
        {
            // Store assembly name (e.g. "ContosoCookbook") with a trailing period
            _assembly = typeof(LocalImagePathConverter).AssemblyQualifiedName.Split(',')[1].Trim() + '.';
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null && parameter == null)
                return null;

            string path = null;
            if(parameter != null){
                path = (string)parameter;
            }else if(value != null){
                path = (string)value;
            }

            // Convert an image-path string (e.g. "images/chinese/photo.jpg" into a resource ID
            // (e.g. "ContosoCookbook.images.chinese.photo.jpg") and return an ImageSource
            // wrapping that resource
            string source = _assembly + path.Replace('/', '.');
            return ImageSource.FromResource(source);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
