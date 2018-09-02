using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
	public class Shopper
	{
		private readonly ICreditCard creditCard;

		public Shopper(ICreditCard creditCard)
		{
			this.creditCard = creditCard;
		}

		public string Charge()
		{
			return creditCard.Charge();
		}
	}
}
