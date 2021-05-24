using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EDA.Domain.Extensions
{
    public static class Convert
    {
        public static IEnumerable<TTarget> ConvertAll<TSource, TTarget>(this IEnumerable<Extensions.IConverter.IConvertModel<TSource, TTarget>> values)
          => values.Select(value => value.Convert());
    }
}
