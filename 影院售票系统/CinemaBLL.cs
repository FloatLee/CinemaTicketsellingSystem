using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Drawing;

namespace 影院售票系统
{
    //影厅业务逻辑类。
    class HallBLL
    {
        private int hallId;  //影厅在数据库中的编号。
        private string hallName;  //影厅名称。
        private int[] row;  //每排座位数。

        public HallBLL()
        {
            row = new int[16];  //初始化变量。
        }

        public int HallId {get { return hallId; } set { hallId = value; }}  //影厅ID属性。
        public string HallName{get{ return hallName;} set{ hallName = value;}}  //影厅名称属性。
        
        //返回影厅总排数。
        public int getSumRow()
        {
            int z = 0;
            for (int i = 0; i < row.Length; ++i)
            {
                if (row[i] > 0)
                {
                    ++z;
                }
            }
            return z;
        }

        //返回影厅占用的排数（包含两排间的空排数）。
        public int getReallySumRow()
        {
            int i;
            for (i = row.Length - 1; i >= 0 && row[i] == 0; --i) ;
            return i + 1;
        }

        //返回影厅总座位数。
        public int getSumSeat()
        {
            int sum=0;
            for (int i = 0; i < row.Length; ++i)
            {
                sum += row[i];
            }
            return sum;
        }

        //返回影厅第num排的座位数。
        public int getRow(int num)
        {
                return row[num];
        }

        //设置影厅第i+1排的座位数为num。
        public void setRow(int i, int num)
        {
            row[i] = num;
        }

        //存储当前影厅。
        public bool saveHall()
        {
            return HallDAL.newHall(this);
        }

        //更新当前影厅名称到数据库。
        public bool updateHallName()
        {
            return HallDAL.updateHallNameById(this.HallId, this.HallName);
        }

        //删除当前影厅。
        public bool deleteHall()
        {
            return HallDAL.deleteHallById(this.hallId);
        }

        //重写toString，用于输出到下拉框。
        public override string ToString()
        {
            return this.HallName;
        }

        //输出影厅信息。
        public string message()
        {
            string str;
            str = "影院名称：     " + this.hallName;
            str += "\n总座位数：     " + this.getSumSeat();
            str += "\n总排数：        " + this.getSumRow();
            str += "\n占用排数：     " + this.getReallySumRow();
            for (int i = 0, z = 0; i < this.getReallySumRow(); ++i)
            {
                if (row[i] > 0)
                {
                    str += "\n第" + (++z) + "排座位数：" + this.getRow(i);
                }
            }
            return str;

        }

        //返回数据库中所有影厅信息。
        public static ArrayList getAllHall()
        {
            DataSet dataSet = HallDAL.queryHall();
            ArrayList allHall = new ArrayList();
            HallBLL hall;
            for (int i = 0; i < dataSet.Tables["Cinema_Hall"].Rows.Count; ++i)
            {
                hall = new HallBLL();
                hall.HallId = Convert.ToInt32(dataSet.Tables["Cinema_Hall"].Rows[i]["影厅编号"]);
                hall.HallName = Convert.ToString(dataSet.Tables["Cinema_Hall"].Rows[i]["影厅名称"]);
                for (int j = 0; j < 16; ++j)
                {
                    hall.setRow(j, Convert.ToInt32(dataSet.Tables["Cinema_Hall"].Rows[i]["第" + (j + 1) + "列"]));
                }
                allHall.Add(hall); 
            }
            return allHall;
        }


    }

    //影片业务逻辑类。
    class MovieBLL
    {
        private int movieId;  //电影数据库编号。
        private string movieName;  //电影名称。
        private string movieType;  //电影类型。
        private string producer;  //出品方。
        private string director;  //导演。
        private string actor;  //主演。
        private string num;  //播放许可证号。
        private string start;  //上映日期。
        private string end;  //结束日期。
        private string time;  //时长。
        private string introd;  //电影简介。
        private string poster;  //海报存储路径。

        //封装字段。
        public int MovieId {get { return movieId; } set{ movieId = value; }}
        public string MovieName{get { return movieName; }set{ movieName = value; }}
        public string MovieType{ get { return movieType; } set { movieType = value; }}
        public string Producer{ get { return producer; } set { producer = value; }}
        public string Director{ get { return director; } set { director = value; }}
        public string Actor{ get { return actor; } set { actor = value; }}
        public string Num{ get { return num; } set { num = value; }}
        public string Start{ get { return start; }set { start = value; }}
        public string End{ get { return end; } set { end = value; }}
        public string Time{ get { return time; } set { time = value; }}
        public string Introd{ get { return introd; } set { introd = value; }}
        public string Poster{ get { return poster; } set { poster = value; }}

        //存储当前影片。
        public bool saveMovie()
        {
            return MovieDAL.newMovie(this);
        }

        //输出影片信息。
        public string message()
        {
            string str = "电影名称：      " + this.MovieName +
                "\n类型：            " + this.MovieType +
                "\n出品方：         " + this.Producer +
                "\n导演：            " + this.Director +
                "\n主演：            " + this.Actor +
                "\n播放许可证号：" + this.Num +
                "\n时长：            " + this.Time +
                "\n上映日期：      " + this.Start +
                "\n结束日期：      " + this.End +
                "\n海报路径：      " + this.Poster +
                "\n电影简介：      " + this.Introd;
            return str;
        }

        //重写toString，用于输出到下拉框。
        public override string ToString()
        {
            return this.MovieName;
        }

        //返回数据库中所有影片信息。
        public static ArrayList getAllMovie()
        {
            DataSet dataSet = MovieDAL.queryMovie();
            ArrayList allMovie = new ArrayList();
            MovieBLL movie;
            for (int i = 0; i < dataSet.Tables["Film"].Rows.Count; ++i)
            {
                movie = new MovieBLL();
                movie.MovieId = Convert.ToInt32(dataSet.Tables["Film"].Rows[i]["影片编号"]);
                movie.MovieName = Convert.ToString(dataSet.Tables["Film"].Rows[i]["影片名称"]);
                movie.MovieType = Convert.ToString(dataSet.Tables["Film"].Rows[i]["影片类型"]);
                movie.Producer = Convert.ToString(dataSet.Tables["Film"].Rows[i]["出品方"]);
                movie.Director = Convert.ToString(dataSet.Tables["Film"].Rows[i]["导演"]);
                movie.Actor = Convert.ToString(dataSet.Tables["Film"].Rows[i]["主演"]);
                movie.Num = Convert.ToString(dataSet.Tables["Film"].Rows[i]["播放许可证号"]);
                movie.Start = Convert.ToString(dataSet.Tables["Film"].Rows[i]["上映日期"]);
                movie.End = Convert.ToString(dataSet.Tables["Film"].Rows[i]["结束日期"]);
                movie.Poster = Convert.ToString(dataSet.Tables["Film"].Rows[i]["海报路径"]);
                movie.Time = Convert.ToString(dataSet.Tables["Film"].Rows[i]["时长"]);
                movie.Introd = Convert.ToString(dataSet.Tables["Film"].Rows[i]["影片简介"]);
                allMovie.Add(movie);
            }
            return allMovie;
        }

        //删除当前影片。
        public bool deleteMovie()
        {
            return MovieDAL.deleteMovie(this.MovieId);
        }

        //更新当前影片。
        public bool updateMovie()
        {
            return MovieDAL.updateMovie(this);
        }
    }

    //排片业务逻辑类。
    class PlanBLL
    {
        private int planId;  //场次编号。
        private int hallId; //存储影厅。
        public int movieId;  //存储电影。
        private string tStart;  //开始时间。
        private string tEnd;  //结束时间。
        private double price;  //票价。

        //封装字段。
        public int PlanId { get { return planId; } set { planId = value; } }
        public int HallId { get { return hallId; } set { hallId = value; } }
        public int MovieId { get { return movieId; } set { movieId = value; } }
        public string TStart { get { return tStart; } set { tStart = value; } }
        public string TEnd { get { return tEnd; } set { tEnd = value; } }
        public double Price { get { return price; } set { price = value; } }

        //存储当前排片信息。
        public bool savePlan()
        {
            return PlanDAL.newPlan(this);
        }

        //输出场次信息。
        public string message(HallBLL hall, MovieBLL movie)
        {
            string str = "放映厅   ：" + hall.HallName +
                "\n影片      ：" + movie.MovieName +
                "\n开始时间：" + this.TStart +
                "\n结束时间：" + this.TEnd +
                "\n票价：      " + this.Price;
            return str;
        }

        //返回数据库中所有场次信息。
        public static ArrayList getAllPlan()
        {
            DataSet dataSet = PlanDAL.queryPlan();
            ArrayList allPlan = new ArrayList();
            PlanBLL plan;
            for (int i = 0; i < dataSet.Tables["Plan_Film"].Rows.Count; ++i)
            {
                plan = new PlanBLL();
                plan.MovieId = Convert.ToInt32(dataSet.Tables["Plan_Film"].Rows[i]["影片编号"]);
                plan.HallId = Convert.ToInt32(dataSet.Tables["Plan_Film"].Rows[i]["影厅编号"]);
                plan.PlanId = Convert.ToInt32(dataSet.Tables["Plan_Film"].Rows[i]["场次编号"]);
                plan.TStart = Convert.ToString(dataSet.Tables["Plan_Film"].Rows[i]["开始时间"]);
                plan.TEnd = Convert.ToString(dataSet.Tables["Plan_Film"].Rows[i]["结束时间"]);
                plan.Price = Convert.ToDouble(dataSet.Tables["Plan_Film"].Rows[i]["票价"]);
                allPlan.Add(plan);
            }
            return allPlan;
        }

        //输出影片播放时段。
        public string getTime()
        {
            string s;
            char[] trim = { '年', '月', '日', ':' };
            string[] temp = this.TStart.Split(trim);
            s = temp[0] + "." + temp[1] + "." + temp[2];
            s += temp[3] + ":" + temp[4];
            temp = this.TEnd.Split(trim);
            s += "-" + temp[3].Trim() + ":" + temp[4];
            return s;
        }

        //更新当前票价到数据库。
        public bool updatePrice()
        {
            return PlanDAL.updatePriceById(this.PlanId, this.Price);
        }

        //删除当前场次。
        public bool deletePlan()
        {
            return PlanDAL.deletePlanById(this.PlanId);
        }

        //输出影片播放时间。
        public string getShortTime()
        {
            string s;
            char[] trim = { '年', '月', '日', ':' };
            string[] temp = this.TStart.Split(trim);
            s = temp[3] + ":" + temp[4];
            temp = this.TEnd.Split(trim);
            s += "-" + temp[3].Trim() + ":" + temp[4] + " ";
            return s;
        }
    }

    //售票业务逻辑类。
    class TicketBLL
    {
        private int ticketId;  //售票编号。
        private int planId;  //场次编号。
        private string discount; //折扣类型。
        private string saleTime; //售票时间。
        private int seatNum; //座位编号。

        //封装字段。
        public int TicketId { get { return ticketId; } set { ticketId = value; } }
        public int PlanId { get { return planId; } set { planId = value; } }
        public string Discount { get { return discount; } set { discount = value; } }
        public string SaleTime { get { return saleTime; } set { saleTime = value; } }
        public int SeatNum { get { return seatNum; } set { seatNum = value; } }

        //查询所有购票数据。
        public static ArrayList getAllTicket()
        {
            DataSet dataSet = TicketDAL.queryTicket();
            ArrayList allTicket = new ArrayList();
            TicketBLL ticket;
            for (int i = 0; i < dataSet.Tables["Tickets"].Rows.Count; ++i)
            {
                ticket = new TicketBLL();
                ticket.TicketId = Convert.ToInt32(dataSet.Tables["Tickets"].Rows[i]["购票编号"]);
                ticket.PlanId = Convert.ToInt32(dataSet.Tables["Tickets"].Rows[i]["场次编号"]);
                ticket.Discount = Convert.ToString(dataSet.Tables["Tickets"].Rows[i]["折扣类型"]);
                ticket.SaleTime = Convert.ToString(dataSet.Tables["Tickets"].Rows[i]["购票时间"]);
                ticket.SeatNum = Convert.ToInt32(dataSet.Tables["Tickets"].Rows[i]["座位编号"]);
                allTicket.Add(ticket);
            }
            return allTicket;
        }

        //存储当前购票信息。
        public bool saveTicket()
        {
            return TicketDAL.newTicket(this);
        }

        //删除当前购票信息。
        public bool deleteTicket()
        {
            return TicketDAL.deleteTicketById(this.TicketId);
        }

        //输出单选购票信息。
        public string message(HallBLL hall, MovieBLL movie, PlanBLL plan, string label)
        {
            string str = "放映厅：   " + hall.HallName +
                "\n片名：      " + movie.MovieName +
                "\n放映时间：" + plan.getTime() +
                "\n座位号：   " + label + "(" + (this.SeatNum + 1) + ")" +
                "\n票价:        " + plan.Price;
            if (this.Discount == "学生票")
            {
                str += "\n优惠类型：" + this.Discount +
                    "\n优惠价：   " + plan.Price * 0.8;
            }
            str += "\n售出时间：" + this.SaleTime;
            return str;
        }

        //输出多选购票信息。
        public string message(HallBLL hall, MovieBLL movie, PlanBLL plan, ArrayList seat, ArrayList label)
        {
            seat.Sort();
            string str = "放映厅：   " + hall.HallName +
                "\n片名：      " + movie.MovieName +
                "\n放映时间：" + plan.getTime() +
                "\n座位号：   " + (string)label[0] + "(" + ((int)seat[0] + 1) + ")";
            for (int i = 1; i < seat.Count; ++i)
            {
                str += "," + (string)label[i] + "(" + ((int)seat[i] + 1) + ")";
            }
            str +=  "\n票价:        " + plan.Price + "×" + seat.Count + "=" + (plan.Price * seat.Count);
            if (this.Discount == "学生票")
            {
                str += "\n优惠类型：" + this.Discount +
                    "\n优惠价：   " + plan.Price + "×" + seat.Count + "×0.8" + "=" + (plan.Price * seat.Count * 0.8);
            }
            str += "\n售出时间：" + this.SaleTime;
            return str;
        }
    }

    //用户业务逻辑类。
    public class UserBLL
    {
        private int userId;  //用户编号。
        private string name;  //帐号。
        private string passport;  //密码。
        private int position;  //身份。

        //封装字段。
        public int UserId { get { return userId; }}
        public string Name { get { return name; }}
        public string Passport { get { return passport; }}
        public int Position { get { return position; }}

        //查询所有用户信息。
        public static ArrayList getAllUser()
        {
            DataSet dataSet = UserDAL.queryUser();
            ArrayList allUser = new ArrayList();
            UserBLL user;
            for (int i = 0; i < dataSet.Tables["User_Data"].Rows.Count; ++i)
            {
                user = new UserBLL();
                user.userId = Convert.ToInt32(dataSet.Tables["User_Data"].Rows[i]["用户编号"]);
                user.name = Convert.ToString(dataSet.Tables["User_Data"].Rows[i]["帐号"]);
                user.passport = Convert.ToString(dataSet.Tables["User_Data"].Rows[i]["密码"]);
                user.position = Convert.ToInt32(dataSet.Tables["User_Data"].Rows[i]["身份"]);
                allUser.Add(user);
            }
            return allUser;
        }
    }
}
