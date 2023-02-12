using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Battleship.Core
{
	public class DatabaseManager
	{
		#region Variable Declaration
		static private bool isOpenConnection = false;
		private SQLiteConnection connection;
		private const string connectionString = "Data source=Battleship.db; Version=3";
		#endregion

		public void AddGameData(string p1Name, string p2Name, bool p1Won, TimeSpan gameDuration)
		{
			if (isOpenConnection)
				return;
			openConnection();

			createGameTable();
			string insertSQL = "Insert into Game(p1Name, p2Name, p1Won, gameDuration) values (@p1Name, @p2Name, @p1Won, @gameDuration)";
			SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
			command.Parameters.AddWithValue("p1Name", p1Name);
			command.Parameters.AddWithValue("p2Name", p2Name);
			command.Parameters.AddWithValue("p1Won", p1Won);
			command.Parameters.AddWithValue("gameDuration", gameDuration);
			command.ExecuteNonQuery();

			closeConnection();
		}

		public void PrintGameData()
		{
			if (isOpenConnection)
				return;
			openConnection();

			const string selectSQL = "Select * from Game";
			SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
			SQLiteDataReader reader = command.ExecuteReader();

			StringBuilder dbContent = new StringBuilder();
			const string seperator = ", ";
			while (reader.Read())
			{
				dbContent.Append(reader.GetString(0) + seperator);
				dbContent.Append(reader.GetString(1) + seperator);
				dbContent.Append(reader.GetInt32(2) + seperator);
				dbContent.Append(reader.GetString(3));
				dbContent.Append(Environment.NewLine);
			}
			MessageBox.Show(dbContent.ToString());

			closeConnection();
		}

		private void openConnection()
		{
			if (!isOpenConnection)
			{
				isOpenConnection = true;
				connection = new SQLiteConnection(connectionString);
			}
		}

		private void closeConnection()
		{
			if (isOpenConnection)
			{
				isOpenConnection = false;
				connection.Close();
			}
		}

		private void createGameTable()
		{
			const string createTable = "create table if not exists Game(p1Name Text, p2Name Text, p1Won integer, gameDuration Text";
			SQLiteCommand command = new SQLiteCommand(createTable, connection);
			command.ExecuteNonQuery();
		}

	}
}
