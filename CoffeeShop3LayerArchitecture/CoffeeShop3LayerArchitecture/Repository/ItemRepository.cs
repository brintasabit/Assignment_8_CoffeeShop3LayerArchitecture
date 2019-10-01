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
    }
}
