using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 影院售票系统
{
    //数据库连接通用类。
    class CinemaDAL
    {
        private static string connStr = "server = Never-PC; database = cinema_ticketing_database; Integrated Security = SSPI";
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataAdapter sqlDataAdapter;
        private static DataSet dataSet;
        private static int Succnum;

        //执行SQL增删改语句并返回受影响行数。
        public static int executeCommand(string sqlStr)
        {
            sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sqlStr, sqlConnection);
            try
            {
            Succnum = sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return -1;
            }
            sqlConnection.Close();
            return Succnum;
        }

        //执行SQL查询语句并返回所查询的数据集。
        public static DataSet queryData(string sqlStr, string name)
        {
            sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, name);
            return dataSet;
        }
    }

    //影厅数据库连接类。
    class HallDAL
    {
        private static string sqlStr;
        private static int Succnum;
        private static DataSet dataSet;

        //在数据库中增加一条影厅信息并返回操作结果。
        public static bool newHall(HallBLL hall)
        {
            sqlStr = "INSERT INTO Cinema_Hall VALUES ('" +
                hall.HallName + "'," + hall.getSumSeat() +
                "," + hall.getSumRow();
            for (int i = 0; i < 16; ++i)
            {
                sqlStr += "," + hall.getRow(i);
            }
            sqlStr += ")";

            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中查询所有影厅信息。
        public static DataSet queryHall()
        {
            sqlStr = "SELECT Hall_ID AS 影厅编号, Hall_Name AS 影厅名称, Sum_Seat AS 总座位数, Row_Num AS 总排数";
            for (int i = 1; i <= 16; ++i)
            {
                sqlStr += ", Row" + i + " AS 第" + i + "列";
            }
            sqlStr += " FROM Cinema_Hall";
            dataSet =  CinemaDAL.queryData(sqlStr, "Cinema_Hall");
            return dataSet;
        }

        //在数据库中通过影厅Id删除一条影厅信息。
        public static bool deleteHallById(int hallId)
        {
            sqlStr = "DELETE FROM Cinema_Hall WHERE Hall_ID =" + hallId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中通过影厅Id更新一条影厅信息的名称。
        public static bool updateHallNameById(int hallId, string newName)
        {
            sqlStr = "UPDATE Cinema_Hall SET Hall_Name = '" + newName + "' WHERE Hall_ID =" + hallId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //影片数据库连接类。
    class MovieDAL
    {
        private static string sqlStr;
        private static int Succnum;
        private static DataSet dataSet;

        //在数据库中增加一条影片信息并返回操作结果。
        public static bool newMovie(MovieBLL movie)
        {
            sqlStr = "INSERT INTO Film VALUES('" + movie.MovieName +
                "','" + movie.MovieType + "','" + movie.Producer +
                "','" + movie.Director + "','" + movie.Actor +
                "','" + movie.Num + "','" + movie.Start +
                "','" + movie.End + "','" + movie.Poster +
                "'," + movie.Time + ",'" + movie.Introd + "')";

            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中查询所有影片信息。
        public static DataSet queryMovie()
        {
            sqlStr = "SELECT Film_ID AS 影片编号, Film_Name AS 影片名称, Film_Type AS 影片类型," +
                "Producers AS 出品方, Director AS 导演, Actor AS 主演, Broadcast_License AS 播放许可证号," +
                "Start_Time AS 上映日期, End_Time AS 结束日期, Poster AS 海报路径, Duration AS 时长," +
                "Introduction AS 影片简介 FROM Film";
            dataSet = CinemaDAL.queryData(sqlStr, "Film");
            return dataSet;
        }

        //在数据库中通过影片Id删除一条影厅信息。
        public static bool deleteMovie(int movieId)
        {
            sqlStr = "DELETE FROM Film WHERE Film_ID =" + movieId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中通过影片Id更新一条影片的全部信息。
        public static bool updateMovie(MovieBLL movie) 
        {
            sqlStr = "UPDATE Film SET Film_Name = '" + movie.MovieName + "',Film_Type = '" + 
                movie.MovieType + "',Producers = '" + movie.Producer + "',Director = '" +
                movie.Director + "',Actor = '" + movie.Actor + "',Broadcast_License = " + 
                movie.Num + ",Start_Time = '" + movie.Start + "',End_Time = '" +
                movie.End + "',Duration = " + movie.Time  + ",Introduction = '" + 
                movie.Introd + "' WHERE Film_ID = " + movie.MovieId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //排片数据库连接类。
    class PlanDAL
    {
        private static string sqlStr;
        private static int Succnum;
        private static DataSet dataSet;

        //在数据库中增加一条排片信息并返回操作结果。
        public static bool newPlan(PlanBLL plan)
        {
            sqlStr = "INSERT INTO Plan_Film VALUES("+  plan.MovieId + "," + 
                plan.HallId + ",'" + plan.TStart + "','" +
                plan.TEnd + "'," + plan.Price +")";

            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中查询所有场次信息。
        public static DataSet queryPlan()
        {
            sqlStr = "SELECT Plan_ID AS 场次编号,Hall_ID AS 影厅编号,Film_ID AS 影片编号,Time_Start AS 开始时间," +
                "Time_End AS 结束时间,Price AS 票价 FROM Plan_Film";
            dataSet = CinemaDAL.queryData(sqlStr, "Plan_Film");
            return dataSet;
        } 

        //在数据库中通过场次Id删除一条排片的全部信息。
        public static bool deletePlanById(int planId)
        {
            sqlStr = "DELETE FROM Plan_Film WHERE Plan_ID =" + planId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中通过场次Id更新一条排片的票价
        public static bool updatePriceById(int planId, double price)
        {
            sqlStr = "UPDATE Plan_Film SET Price = " + price + " WHERE Plan_ID =" + planId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //售票数据库连接类。
    class TicketDAL
    {
        private static string sqlStr;
        private static int Succnum;
        private static DataSet dataSet;

        //在数据库中增加一条购票信息。
        public static bool newTicket(TicketBLL ticket)
        {
            sqlStr = "INSERT INTO Tickets VALUES(" + ticket.PlanId + ",'" +
                ticket.Discount + "','" + ticket.SaleTime + 
                "'," + ticket.SeatNum + ")";
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中通过Id删除一条购票的全部信息。
        public static bool deleteTicketById(int ticketId)
        {
            sqlStr = "DELETE FROM Tickets WHERE Tickets_ID =" + ticketId;
            Succnum = CinemaDAL.executeCommand(sqlStr);
            if (Succnum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在数据库中查询所有购票信息。
        public static DataSet queryTicket()
        {
            sqlStr = "SELECT Tickets_ID AS 购票编号,Plan_ID AS 场次编号,Discount AS 折扣类型,Sale_Time AS 购票时间,Seat_Num AS 座位编号 FROM Tickets";
            dataSet = CinemaDAL.queryData(sqlStr, "Tickets");
            return dataSet;
        }
    }

    //用户数据库连接类。
    class UserDAL
    {
        private static string sqlStr;
        private static DataSet dataSet;

        //在数据库中查询所以用户信息。
        public static DataSet queryUser()
        {
            sqlStr = "SELECT User_ID AS 用户编号,Name AS 帐号, PassPort AS 密码,Position AS 身份 FROM User_Data";
            dataSet = CinemaDAL.queryData(sqlStr, "User_Data");
            return dataSet;
        }
    }
}
