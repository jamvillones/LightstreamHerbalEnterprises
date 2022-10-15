using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.ViewModels
{
    internal interface IViewmodelDataHolder<IData> where IData : class
    {
        public IData Data { get; set; }
    }
}
