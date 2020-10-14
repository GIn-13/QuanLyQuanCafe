using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {

        // Patern Singleton
        private static DataProvider instance;// ctrl + R + E

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }


        //chuoi xac dinh  ket noi 
        private string connectionSTR = @"Data Source=DESKTOP-4HDJQBF;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

       
        //tra ve so dong ket qua
        public DataTable ExecuteQuery( string query, object[] parameter=null)
        {

            DataTable data = new DataTable();

            //using(){} sau khi ket thuc khoi lenh du lieu duoc giai phong
            //ket noi tu client den sever
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mo ket noi
                connection.Open();

                //Cau truy van thuc thi
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //Trung gian lay du lieu tu database
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                //dong ket noi
                connection.Close();

            }

            return data;
        }
        //tra ve so dong thuc thi
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {

            int data = 0;

            //using(){} sau khi ket thuc khoi lenh du lieu duoc giai phong
            //ket noi tu client den sever
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mo ket noi
                connection.Open();

                //Cau truy van thuc thi
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
             
                //dong ket noi
                connection.Close();

            }

            return data;
        }
        //kq tuong tu select (*) count
        public object ExecuteScalar(string query, object[] parameter = null)
        {

            object data = 0;

            //using(){} sau khi ket thuc khoi lenh du lieu duoc giai phong
            //ket noi tu client den sever
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //mo ket noi
                connection.Open();

                //Cau truy van thuc thi
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                //dong ket noi
                connection.Close();

            }

            return data;
        }
    }
}
