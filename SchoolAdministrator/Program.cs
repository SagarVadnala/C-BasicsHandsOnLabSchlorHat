using oops;
using oops.ClassesForBuildingDiffTypesOfVehicles;
using oops.ExceptionClastoDisplayCustomError;

namespace SchoolAdministrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SchoolAdministrstor admin = new SchoolAdministrstor();
           // admin.ManageSchool();

            CustmErrorMsg custmErrorMsg = new CustmErrorMsg();

            //custmErrorMsg.ArthmaticExeption();

            SwitchClass switchClass = new SwitchClass();
            switchClass.switchCases();
        }
    }
}
