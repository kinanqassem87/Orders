using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Columbus_Order.DAL;

namespace Columbus_Order.BL
{
    class Orders
    {
        public static DataTable sp_SelectAllUser()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SelectAllUser", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable lastOrderId()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("lastOrderId", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int InsertOrder(DateTime Create_Date, string Client_Name, string Order_Desc, string Order_Follower, DateTime Dead_Line,string Order_State)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("InsertOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Create_Date", SqlDbType.Date, Create_Date),
                DataAccessLayer.CreateParameter("@Client_Name", SqlDbType.NVarChar, Client_Name),
                DataAccessLayer.CreateParameter("@Order_Desc", SqlDbType.NVarChar, Order_Desc),
                DataAccessLayer.CreateParameter("@Order_Follower", SqlDbType.NVarChar, Order_Follower),
                DataAccessLayer.CreateParameter("@Dead_Line", SqlDbType.Date, Dead_Line),
                DataAccessLayer.CreateParameter("@Order_State", SqlDbType.NVarChar, Order_State));
            DataAccessLayer.Close();
            return i;
        }

        public static int InsertImg(byte[] arr, int id,string ImgType)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("InsertImg", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Img_Doc", SqlDbType.Image, arr),
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@ImgType", SqlDbType.NVarChar, ImgType));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectOrderView()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderView", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectImgForOneDoc(int OrderId)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectImgForOneDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderId));
            DataAccessLayer.Close();
            return dt;
        }

        public static int DeleteImg(int ImgId)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteImg", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Img_Id", SqlDbType.Int, ImgId));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SelectOrderArchive()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectOrderArchive", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectImgForOneDocOrders(int OrderId,string imgType)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectImgForOneDocOrders", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderId),
                DataAccessLayer.CreateParameter("@ImgType", SqlDbType.NVarChar, imgType));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchOrderArchive(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchOrderArchive", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar, Search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchOrderView(string Search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchOrderView", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.NVarChar, Search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateOrder(int orderId, DateTime Create_Date, string Client_Name, string Order_Desc, string Order_Follower, DateTime Dead_Line, string Order_State)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, orderId),
                DataAccessLayer.CreateParameter("@Create_Date", SqlDbType.Date, Create_Date),
                DataAccessLayer.CreateParameter("@Client_Name", SqlDbType.NVarChar, Client_Name),
                DataAccessLayer.CreateParameter("@Order_Desc", SqlDbType.NVarChar, Order_Desc),
                DataAccessLayer.CreateParameter("@Order_Follower", SqlDbType.NVarChar, Order_Follower),
                DataAccessLayer.CreateParameter("@Dead_Line", SqlDbType.Date, Dead_Line),
                DataAccessLayer.CreateParameter("@Order_State", SqlDbType.NVarChar, Order_State));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteImgOrder(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteImgOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteOrder(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateDoneOrder(int OrderID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateDoneOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, OrderID));
            DataAccessLayer.Close();
            return i;
        }


    }
}
