using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FxInformationJob.Tests
{
    public class BaseUnit
    {
        public BaseUnit()
        {
            SimpleInjectorInitializer.Initialize();
        }
    }
}
