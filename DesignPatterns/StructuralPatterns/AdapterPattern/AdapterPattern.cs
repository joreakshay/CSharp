using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public interface ILegacyService
    {
        void LegacyRequest();
    }
    public class NewService
    {
        public void NewRequest() 
        {
            Console.WriteLine("Printing NewService.NewRequest");
        }
    }
    class Addpter : ILegacyService
    {
        protected readonly NewService newService;
       public Addpter(NewService newService) 
        {
            this.newService = newService;
        }
        public void LegacyRequest()
        {
            newService.NewRequest();
        }
    }

    public class AdapterPattern
    {
        //Main method to call
        public static void Main()
        {
            NewService newService = new NewService();
            Addpter addpter = new Addpter(newService);
            addpter.LegacyRequest();
        }
    }
}
