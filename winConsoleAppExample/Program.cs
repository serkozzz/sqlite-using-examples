using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace SQLiteUsingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			NotORMSample notORMSample = new NotORMSample();
			notORMSample.CreateDB();

			ORMSample ormSample = new ORMSample();
			ormSample.Test();

		}
	}
}
