using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamie.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
        void GetData2(Action<RecipeSet, Exception> callback);
    }
}
