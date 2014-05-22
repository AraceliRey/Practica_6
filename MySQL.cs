using System;
using MySql.Data.MySqlClient;

namespace Practica6
{
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}

		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=Profesor;" +
	          	"User ID=Araceli;" +
	          	"Password=12345;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}

		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}
