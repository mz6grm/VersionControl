using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyolcadik.Entities
{
	public class CarFactory : IToyInterface
	{
		public Toy CreateNew()
		{
			return new Car();
		}
	}
}
