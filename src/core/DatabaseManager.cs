using System;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Battleship.Core
{
	public class DatabaseManager
	{
		#region Variable Declaration
		private const string connectionString = "Data source=Battleship.db; Version=3";
		#endregion

		public void AddGameData(string p1Name, string p2Name, bool p1Won, TimeSpan gameDuration)
		{
			createGameTable();
			string insertSQL = "Insert into Game(p1Name, p2Name, p1Won, gameDuration) values (@p1Name, @p2Name, @p1Won, @gameDuration)";
			SQLiteCommand command = new SQLiteCommand(insertSQL);
			command.Parameters.AddWithValue("p1Name", p1Name);
			command.Parameters.AddWithValue("p2Name", p2Name);
			command.Parameters.AddWithValue("p1Won", p1Won);
			command.Parameters.AddWithValue("gameDuration", gameDuration);
			executeNonQuerySQLiteCommand(command);
		}

		public void PrintGameData()
		{
			const string selectSQL = "Select * from Game";

			StringBuilder dbContent = new StringBuilder();
			const string seperator = ", ";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            dbContent.Append(reader.GetString(0) + seperator);
                            dbContent.Append(reader.GetString(1) + seperator);
                            dbContent.Append(reader.GetInt32(2) + seperator);
                            dbContent.Append(reader.GetString(3));
                            dbContent.Append(Environment.NewLine);
                        }
                }
            }
			MessageBox.Show(dbContent.ToString());
		}

        private void executeNonQuerySQLiteCommand(SQLiteCommand command)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        private void createGameTable()
		{
			const string createTable = "create table if not exists Game(p1Name Text, p2Name Text, p1Won integer, gameDuration Text)";
			executeNonQuerySQLiteCommand(new SQLiteCommand(createTable));
		}
	}
}
