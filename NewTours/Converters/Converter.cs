using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTours.Converters
{
    internal class Converter: IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culter)
        {
            return value == "" ? new Bitmap(AssetLoader.Open(new Uri("avares://NewTours/Assets/Tours/picture.png"))) : new Bitmap(AssetLoader.Open(new Uri($"avares://NewTours/Assets/Tours/{value}")));
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culter)
        {
            throw new NotImplementedException();
        }
    }
}
