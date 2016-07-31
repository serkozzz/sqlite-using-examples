﻿using SQLite;


namespace SQLiteUsingExample
{
	public class Cat
	{
		[PrimaryKey, AutoIncrement]
		public int Id
		{ get; set; }
		public string Name
		{ get; set; }
	}
}
