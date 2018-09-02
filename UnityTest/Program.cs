using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;


namespace UnityTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//using (var container = new UnityContainer())
			//{
			//	container.RegisterTypes(
			//		AllClasses.FromLoadedAssemblies(),
			//		WithMappings.FromAllInterfaces,
			//		WithName.Default,
			//		WithLifetime.ContainerControlled, 
			//		overwriteExistingMappings: false);

			//	var shopper = container.ResolveAll<Shopper>();
			//	//Console.WriteLine(shopper.Charge());
			//}

			var container = new UnityContainer();
			DependencyResolver.RegisterTypes(container);
			var creditCardResolver = container.Resolve<Func<IEnumerable<ICreditCard>>>();
			IEnumerable<ICreditCard> creditCardInstances = creditCardResolver();
			var shopper = new Shopper(creditCardInstances.Where(x=>x.GetType() == typeof(MasterCard)).FirstOrDefault());
			string result = shopper.Charge();
		}
	}
}
