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
        public void GetProducts()
        {
            try
            {
                //connection.Open();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Products.Clear();
                    ProductList.Clear();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    //sb.Append("SELECT * FROM JoelProducts");
                    sb.Append("SELECT * FROM Sheet1$ WHERE GRP_ID IS NULL;");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Material material = new Material
                                {
                                    Name = reader.GetString(0),
                                    //Material_Cost = (float)reader.GetDouble(1),
                                    Material_Cost = reader.IsDBNull(1) ? 0 : (float)reader.GetDouble(1),
                                    //Setup_Hr = (float)reader.GetDouble(2),
                                    //Setup_Cost = (UInt32)reader.GetDouble(3),
                                    //Operation_Hr = (float)reader.GetDouble(4),
                                    //Operation_Cost = (UInt32)reader.GetDouble(5),
                                    //Markup = (float)reader.GetDouble(6),
                                    Setup_Hr = reader.IsDBNull(2) ? 0 : (float)reader.GetDouble(2),
                                    Setup_Cost = reader.IsDBNull(3) ? 0 : (UInt32)reader.GetDouble(3),
                                    Operation_Hr = reader.IsDBNull(4) ? 0 : (float)reader.GetDouble(4),
                                    Operation_Cost = reader.IsDBNull(5) ? 0 : (UInt32)reader.GetDouble(5),
                                    Markup = reader.IsDBNull(6) ? 0 : (float)reader.GetDouble(6),
                                    Qty = 1,
                                    Id = (float)reader.GetInt32(7),
                                    Grp_Id = reader.IsDBNull(8) ? 0 : (float)reader.GetInt32(8)
                                };

                                material.SetSubTotal();
                                material.SetPricePerPiece();

                                Products.Add(material);
                                ProductList.Add(material);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void GetMaterials(float id)
        {
            try
            {
                //connection.Open();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Products.Clear();
                    MaterialList.Clear();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    //sb.Append("SELECT * FROM JoelProducts");
                    sb.Append("SELECT * FROM Sheet1$ WHERE GRP_ID = " + id.ToString() + ";");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Material material = new Material
                                {
                                    Name = reader.GetString(0),
                                    //Material_Cost = (float)reader.GetDouble(1),
                                    Material_Cost = reader.IsDBNull(1) ? 0 : (float)reader.GetDouble(1),
                                    //Setup_Hr = (float)reader.GetDouble(2),
                                    //Setup_Cost = (UInt32)reader.GetDouble(3),
                                    //Operation_Hr = (float)reader.GetDouble(4),
                                    //Operation_Cost = (UInt32)reader.GetDouble(5),
                                    //Markup = (float)reader.GetDouble(6),
                                    Setup_Hr = reader.IsDBNull(2) ? 0 : (float)reader.GetDouble(2),
                                    Setup_Cost = reader.IsDBNull(3) ? 0 : (UInt32)reader.GetDouble(3),
                                    Operation_Hr = reader.IsDBNull(4) ? 0 : (float)reader.GetDouble(4),
                                    Operation_Cost = reader.IsDBNull(5) ? 0 : (UInt32)reader.GetDouble(5),
                                    Markup = reader.IsDBNull(6) ? 0 : (float)reader.GetDouble(6),
                                    Qty = reader.IsDBNull(9) ? 0 : (UInt32)reader.GetDouble(9),
                                    Id = (float)reader.GetInt32(7),
                                    Grp_Id = reader.IsDBNull(8) ? 0 : (float)reader.GetInt32(8)
                                };

                                material.SetSubTotal();
                                material.SetPricePerPiece();

                                Products.Add(material);
                                MaterialList.Add(material);
                                Console.WriteLine("hey");
                            }
                            Console.WriteLine("heywala");
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
            //Products.Add(material);
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Sheet1$ VALUES ('");
                    sb.Append(material.Name + "', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void AddMaterial(Material material)
        {
            //Products.Add(material);
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    //sb.Append("INSERT INTO JoelProducts VALUES ('");
                    sb.Append("INSERT INTO Sheet1$ VALUES ('");
                    sb.Append(material.Name + "', ");
                    sb.Append(material.Material_Cost + ", ");
                    sb.Append(material.Setup_Hr + ", ");
                    sb.Append(material.Setup_Cost + ", ");
                    sb.Append(material.Operation_Hr + ", ");
                    sb.Append(material.Operation_Cost + ", ");
                    sb.Append(material.Markup + ", ");
                    sb.Append(material.Grp_Id + ", ");
                    sb.Append(material.Qty + ");");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    
                }  
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void DeleteProduct(float id)
        {
            //Products.Add(material);
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    //sb.Append("INSERT INTO JoelProducts VALUES ('");
                    sb.Append("DELETE FROM Sheet1$ WHERE ID=" + id.ToString());
                    String sql = sb.ToString(); 

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void DeleteMaterial(float id)
        {
            //Products.Add(material);
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    //sb.Append("INSERT INTO JoelProducts VALUES ('");
                    sb.Append("DELETE FROM Sheet1$ WHERE ID=" + id.ToString());
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }




        public List<Material> Products { get; set; }

        public List<Material> ProductList { get; set; }
        public List<Material> MaterialList { get; set; }



        private readonly SqlConnectionStringBuilder builder;

        //private readonly SqlConnection connection;

        public SQLQuery()
        {
            Products = new List<Material>();
            ProductList = new List<Material>();
            MaterialList = new List<Material>();
            
            builder = new SqlConnectionStringBuilder
            {
                DataSource = "joelengineering.database.windows.net",
                UserID = "tony",
                Password = "Jadenonoy_12",
                InitialCatalog = "JoelEngineeringDB"
            };

            //connection = new SqlConnection(builder.ConnectionString);
        }
        
        
    }
}
