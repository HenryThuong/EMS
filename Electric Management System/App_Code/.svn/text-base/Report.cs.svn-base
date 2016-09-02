using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Electric_Management_System.App_Code
{
    class Report : ReportFunctions
    {
        private String _TotalReportID;

        public String TotalReportID
        {
            get { return _TotalReportID; }
            set { _TotalReportID = value; }
        }

        private String _StationID;

        public String StationID
        {
            get { return _StationID; }
            set { _StationID = value; }
        }

        private int _Month;

        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        private int _Year;

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        private int _TotalReceived;

        public int TotalReceived
        {
            get { return _TotalReceived; }
            set { _TotalReceived = value; }
        }

        private int _LivingPurpose;

        public int LivingPurpose
        {
            get { return _LivingPurpose; }
            set { _LivingPurpose = value; }
        }

        private int _Poor;

        public int Poor
        {
            get { return _Poor; }
            set { _Poor = value; }
        }

        private int _LowIncome;

        public int LowIncome
        {
            get { return _LowIncome; }
            set { _LowIncome = value; }
        }

        private int _OtherPurpose;

        public int OtherPurpose
        {
            get { return _OtherPurpose; }
            set { _OtherPurpose = value; }
        }

        private long _TotalPaid;

        public long TotalPaid
        {
            get { return _TotalPaid; }
            set { _TotalPaid = value; }
        }

        /// <summary>
        /// Constructor to create new total report
        /// </summary>
        public Report(String stationID, int month, int year, int totalReceived, int livingPurpose, int poor, int lowIncome, int otherPurpose, long totalPaid)
        {
            this.StationID = stationID;
            this.Month = month;
            this.Year = year;
            this.TotalReceived = totalReceived;
            this.LivingPurpose = livingPurpose;
            this.Poor = poor;
            this.LowIncome = lowIncome;
            this.OtherPurpose = otherPurpose;
            this.TotalPaid = totalPaid;
        }

        /// <summary>
        /// Constructor to edi total report
        /// </summary>
        public Report(String totalReportID, int totalReceived, int livingPurpose, int poor, int lowIncome, int otherPurpose, long totalPaid)
        {
            this.TotalReportID = totalReportID;
            this.TotalReceived = totalReceived;
            this.LivingPurpose = livingPurpose;
            this.Poor = poor;
            this.LowIncome = lowIncome;
            this.OtherPurpose = otherPurpose;
            this.TotalPaid = totalPaid;
        }

        public bool CreateTotalReport()
        {
            return CreateTotalReport(this);
        }

        public bool EditTotalReport()
        {
            return EditTotalReport(this);
        }
    }

    class ReportFunctions : DataTier
    {
        //Tao bao cao tong hop moi
        protected bool CreateTotalReport(Report r)
        {
            sqlCmd = "INSERT INTO tbl_TotalReport(StationID,Month,Year,TotalReceived,LivingPurpose,Poor,LowIncome,OtherPurpose,TotalPaid) VALUES(@StationID,@Month,@Year,@TotalReceived,@LivingPurpose,@Poor,@LowIncome,@OtherPurpose,@TotalPaid)";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", r.StationID);
            cmd.Parameters.AddWithValue("@Month", r.Month);
            cmd.Parameters.AddWithValue("@Year", r.Year);
            cmd.Parameters.AddWithValue("@TotalReceived", r.TotalReceived);
            cmd.Parameters.AddWithValue("@LivingPurpose", r.LivingPurpose);
            cmd.Parameters.AddWithValue("@Poor", r.Poor);
            cmd.Parameters.AddWithValue("@LowIncome", r.LowIncome);
            cmd.Parameters.AddWithValue("@OtherPurpose", r.OtherPurpose);
            cmd.Parameters.AddWithValue("@TotalPaid", r.TotalPaid);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Lap bao cao tong hop thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Lap bao cao tong hop that bai
            return false;
        }

        //Sua bao cao tong hop
        protected bool EditTotalReport(Report r)
        {
            sqlCmd = "UPDATE tbl_TotalReport SET TotalReceived=@TotalReceived,LivingPurpose=@LivingPurpose,Poor=@Poor,LowIncome=@LowIncome,OtherPurpose=@OtherPurpose,TotalPaid=@TotalPaid WHERE TotalReportID=@TotalReportID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@TotalReportID", r.TotalReportID);
            cmd.Parameters.AddWithValue("@TotalReceived", r.TotalReceived);
            cmd.Parameters.AddWithValue("@LivingPurpose", r.LivingPurpose);
            cmd.Parameters.AddWithValue("@Poor", r.Poor);
            cmd.Parameters.AddWithValue("@LowIncome", r.LowIncome);
            cmd.Parameters.AddWithValue("@OtherPurpose", r.OtherPurpose);
            cmd.Parameters.AddWithValue("@TotalPaid", r.TotalPaid);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua bao cao tong hop thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua bao cao tong hop that bai
            return false;
        }
    }
}
