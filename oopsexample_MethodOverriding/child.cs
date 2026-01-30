using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample_MethodOverriding
{
    //if you want to implement overrding 2 classes required(1 parent class and 1 child class)
    //parent class method having virtual keyword before return type.
    //child class method having override keyword before return type.
    //Same method name and same parameters we will use in parent and child class.
    //then only we can implement the overriding concept.
    //without inheritence we can't implement methodoverriding.
    //Compiler always checks for override keyword method first.if it is availble it will call override method.
    //if there is no override keyword in child class it will call the parent class virtual method.
    internal class child: parent
    {
        //override method always in child class
        //To overirde the method is optional.(not a mandatory)

        //public override void sum()
        //{
        //    //base.sum();
        //    int x = 100, y = 200, z = 300, res;//here 3 variables created and assigned data and decalring one int variable.
        //    res = x + y + z;
        //    Console.WriteLine("the sum is " + res);
        //}
    }
}
