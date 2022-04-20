using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiPrinciple
{
    //Higher Module
    class Project
    {
        private IDeveloper _developer;
        //Constructor Injection
        public Project(IDeveloper dev)
        {
            this._developer = dev;
        }
        //Property Injection
        public IDeveloper Developer { get=>this._developer; set=>this._developer=value; }

        //Method Injection
        public void createDeveloper(IDeveloper developer)
        {
            _developer = developer;
        }

        //Call Developer method
        public void callDeveloper()
        {
            _developer.develop();
        }
    }
}
