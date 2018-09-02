using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
	
	public class MasterCard: ICreditCard
	{
		public string Charge()
		{
			return "Master Card";
		}
	}

	public class Visa: ICreditCard
	{
		public string Charge()
		{
			return "Visa";
		}
	}

	public interface ICreditCard
	{
		string Charge();
	}
}
