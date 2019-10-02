using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop3LayerArchitecture.Model;
namespace CoffeeShop3LayerArchitecture.Repository
{
     class ItemRepository
    {
        public DataTable ShowItem()
        {

            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Items";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConn.Close();
            return dataTable;


        }
        public DataTable SearchItem(Item _item)
        {

            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Items where Name='" + _item.SearchName + "'";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConn.Close();

            return dataTable;
        }
        public bool AddItem(Item _item)
        {
            string connectionString = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"insert into Items values('" + _item.Name + "' ," + _item.Price + " )";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }
        public bool UpdateItem(Item _item)
        {
            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"update Items set Name='" + _item.Name + "',Price= " + _item.Price + " where ID=" + _item.Id + "";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            bool isExecuted = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
            if (isExecuted)
            {
                string command2 = @"select * from Items where ID=" + _item.Id + "";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
            }
            sqlConn.Close();
            return false;
        }
        public bool DeleteItem(Item _item)
        {
            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"delete from Items where ID=" + _item.Id + "";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                return true;
            }
            sqlConn.Close();
            return false;
        }
    }
}
