using System;
using MySql.Data.MySqlClient;

namespace MySoftwareII.Helper_Functions
{
	internal class MySqlcommand
	{
		private object sqlString;
		private object conn;

		public MySqlcommand(object sqlString, object conn)
		{
			this.sqlString = sqlString;
			this.conn = conn;
		}

	}
}