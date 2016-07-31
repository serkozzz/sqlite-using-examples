using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteUsingExample
{
	class NotORMSample
	{
		public void CreateDB()
		{
			using (SQLiteConnection conn = new SQLiteConnection("Data Source=notORMSample.db; Version=3;"))
			{
				conn.Open();
				SQLiteCommand cmd = conn.CreateCommand();
				string sql_command = "DROP TABLE IF EXISTS person;"
				  + "CREATE TABLE person("
				  + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
				  + "first_name TEXT, "
				  + "last_name TEXT, "
				  + "sex INTEGER, "
				  + "birth_date INTEGER);"
				  + "INSERT INTO person(first_name, last_name, sex, birth_date) "
				  + "VALUES ('John', 'Doe', 0, strftime('%s', '1979-12-10'));"
				  + "INSERT INTO person(first_name, last_name, sex, birth_date) "
				  + "VALUES ('Vanessa', 'Maison', 1, strftime('%s', '1977-12-10'));"
				  + "INSERT INTO person(first_name, last_name, sex, birth_date) "
				  + "VALUES ('Ivan', 'Vasiliev', 0, strftime('%s', '1987-01-06'));"
				  + "INSERT INTO person(first_name, last_name, sex, birth_date) "
				  + "VALUES ('Kevin', 'Drago', 0, strftime('%s', '1991-06-11'));"
				  + "INSERT INTO person(first_name, last_name, sex, birth_date) "
				  + "VALUES ('Angel', 'Vasco', 1, strftime('%s', '1987-10-09'));";
				cmd.CommandText = sql_command;
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (SQLiteException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
