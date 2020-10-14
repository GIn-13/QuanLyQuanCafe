using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO();return BillDAO.instance; } 
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        public int GetUncheckBillIDByTableID(int id)
        {
            return (int)DataProvider.Instance.ExecuteScalar("");
        }

    }
}

