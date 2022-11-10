using AbstractFactoryDesignpattern.Interfaces;
using AbstractFactoryDesignpattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Factories
{
    abstract class CompanyAsset
    {
        public abstract ILaptop GetLaptop();
        public abstract IDesktop GetDesktop();
        public abstract IHeadset GetHeadset();

    }
}
