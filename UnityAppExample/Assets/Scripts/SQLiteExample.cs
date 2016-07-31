using UnityEngine;
using System.Collections;
using SQLite;

namespace SQLiteUsingExample
{
	public class SQLiteExample : MonoBehaviour
	{

		// Use this for initialization
		void Start()
		{
			using (var db = new SQLiteConnection(Application.dataPath + "/cats.db")) //for Editor Application.dataPath = "Unity_Project_Dir_Name/Assets"
			{
				db.CreateTable<Cat>();
				db.Insert(new Cat() { Name = "Barsik" });
				db.Insert(new Cat() { Name = "Murzik" });
				db.Insert(new Cat() { Name = "Masha" });
				db.Insert(new Cat() { Name = "Puska" });


				var query = db.Table<Cat>().Where(cat => cat.Name.StartsWith("M"));

				foreach (var cat in query)
					Debug.Log("Cat: " + cat.Name);
			}
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}