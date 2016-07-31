using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteUsingExample
{
	class ORMSample
	{
		public void Test()
		{
			using (SQLiteConnection db = new SQLiteConnection("Animals.db"))
			{
				db.CreateTable<Cat>();
				db.Insert(new Cat() { Name = "Barsik" });
				db.Insert(new Cat() { Name = "Murzik" });
				db.Insert(new Cat() { Name = "Masha" });
				db.Insert(new Cat() { Name = "Puska" });


				var query = db.Table<Cat>().Where(cat => cat.Name.StartsWith("M"));

				foreach (var cat in query)
					Console.WriteLine("Cat: " + cat.Name);
			}
		}
	}
}
