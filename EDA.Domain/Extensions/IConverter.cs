using System;
using System.Collections.Generic;
using System.Text;

namespace EDA.Domain.Extensions
{
   public interface IConverter
    {
        public interface IConvertModel<TSource, TTarget>
        {
            TTarget Convert();
        }
    }
}
