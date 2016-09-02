using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Electric_Management_System.App_Code
{
    class Station : StationFunctions
    {
        //Cac thuoc tinh cua Tram
        private String _StationID;

        public String StationID
        {
            get { return _StationID; }
            set { _StationID = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _StationNumber;

        public int StationNumber
        {
            get { return _StationNumber; }
            set { _StationNumber = value; }
        }

        private int _Duration;

        public int Duration
        {
            get { return _Duration; }
            set { _Duration = value; }
        }

        private int _InvoiceDate;

        public int InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }

        private int _SignDate;

        public int SignDate
        {
            get { return _SignDate; }
            set { _SignDate = value; }
        }

        private int _ReportDate;

        public int ReportDate
        {
            get { return _ReportDate; }
            set { _ReportDate = value; }
        }

        private bool _Status;

        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        //Constructor dung de them tram moi
        public Station(string name, int stationNumber)
        {
            this.Name = name;
            this.StationNumber = stationNumber;
        }

        //Constructor dung de sua ten tram
        public Station(string stationID, string name)
        {
            this.StationID = stationID;
            this.Name = name;
        }

        //Constructor dung de xac dinh tram
        public Station(string stationID)
        {
            this.StationID = stationID;
        }

        //Constructor dung de sua thong tin ngay thang cua tram
        public Station(string stationID, int duration, int invoiceDate, int signDate, int reportDate)
        {
            this.StationID = stationID;
            this.Duration = duration;
            this.InvoiceDate = invoiceDate;
            this.SignDate = signDate;
            this.ReportDate = reportDate;
        }

        //Them tram
        public bool add()
        {
            return add(this);
        }

        //Sua ten tram
        public bool editName()
        {
            return editName(this);
        }

        //Sua ngay tram
        public bool editDate()
        {
            return editDate(this);
        }

        //Xoa tram
        public bool delete()
        {
            return delete(this);
        }

        //Kiem tra ten tram
        public bool CheckName()
        {
            return CheckName(this);
        }

        //Kiem tra so tram
        public bool CheckNumber()
        {
            return CheckNumber(this);
        }
    }

    class StationFunctions : DataTier
    {
        //Them tram moi
        protected bool add(Station s)
        {
            sqlCmd = "INSERT INTO tbl_Station(Name,StationNumber) VALUES(@Name,@StationNumber)";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@StationNumber", s.StationNumber);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Them tram thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Them tram that bai
            return false;
        }

        //Sua ten tram
        protected bool editName(Station s)
        {
            sqlCmd = "UPDATE tbl_Station SET Name=@Name WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@StationID", s.StationID);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua ten tram thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua ten tram that bai
            return false;
        }

        //Sua Ngay thang tram
        protected bool editDate(Station s)
        {
            sqlCmd = "UPDATE tbl_Station SET Duration=@Duration,InvoiceDate=@InvoiceDate,SignDate=@SignDate,ReportDate=@ReportDate WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Duration", s.Duration);
            cmd.Parameters.AddWithValue("@InvoiceDate", s.InvoiceDate);
            cmd.Parameters.AddWithValue("@SignDate", s.SignDate);
            cmd.Parameters.AddWithValue("@ReportDate", s.ReportDate);
            cmd.Parameters.AddWithValue("@StationID", s.StationID);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua ten tram thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua ten tram that bai
            return false;
        }

        //Xoa tram
        protected bool delete(Station s)
        {
            sqlCmd = "Proc_Delete_Station";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StationID", s.StationID);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            if (rd.RecordsAffected > 0)
                //Xoa tram thanh cong
                return true;
            //Xoa tram that bai
            return false;
        }

        //Kiem tra ten tram
        protected bool CheckName(Station s)
        {
            sqlCmd = "SELECT * FROM tbl_Station WHERE Name=@Name";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                con.Close();
                return true;
            }
            rd.Close();
            con.Close();
            return false;
        }

        //Kiem tra so tram
        protected bool CheckNumber(Station s)
        {
            sqlCmd = "SELECT * FROM tbl_Station WHERE StationNumber=@StationNumber";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationNumber", s.StationNumber);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                con.Close();
                return true;
            }
            rd.Close();
            con.Close();
            return false;
        }
    }
}
