using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quotation;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SQLQuery
    {
        public void Connect()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "joelengineering.database.windows.net",
                    UserID = "tony",
                    Password = "Jadenonoy_12",
                    InitialCatalog = "JoelEngineeringDB"
                };

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT * FROM JoelProducts");
                    String sql = sb.ToString();

                   


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Material material = new Material
                                {
                                    Name = reader.GetString(0),
                                    Material_Cost = (float)reader.GetDouble(1),
                                    Setup_Hr = (float)reader.GetDouble(2),
                                    Setup_Cost = (UInt32)reader.GetDouble(3),
                                    Operation_Hr = (float)reader.GetDouble(4),
                                    Operation_Cost = (UInt32)reader.GetDouble(5),
                                    Markup = (float)reader.GetDouble(6),
                                    Qty = 1
                                };

                                material.SetSubTotal();
                                material.SetPricePerPiece();

                                Products.Add(material);
                            }

                            reader.Close();
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }

        }

        public void AddProduct(Material material)
        {
            Products.Add(material);
        }


        public List<Material> Products { get; set; }


        public SQLQuery()
        {
            Products = new List<Material>();
        }
    }
}
