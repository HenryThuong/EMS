using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Electric_Management_System.App_Code
{
    class Invoice : HoaDonFunctions
    {
        private String _InvoiceID;

        public String InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }

        private String _CustomerID;

        public String CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        private String _PurposeID;

        public String PurposeID
        {
            get { return _PurposeID; }
            set { _PurposeID = value; }
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

        private int _OldNumber;

        public int OldNumber
        {
            get { return _OldNumber; }
            set { _OldNumber = value; }
        }

        private int _NewNumber;

        public int NewNumber
        {
            get { return _NewNumber; }
            set { _NewNumber = value; }
        }

        private int _OldNumber2;

        public int OldNumber2
        {
            get { return _OldNumber2; }
            set { _OldNumber2 = value; }
        }

        private int _NewNumber2;

        public int NewNumber2
        {
            get { return _NewNumber2; }
            set { _NewNumber2 = value; }
        }

        private int _Multiplier;

        public int Multiplier
        {
            get { return _Multiplier; }
            set { _Multiplier = value; }
        }

        private int _Debt;

        public int Debt
        {
            get { return _Debt; }
            set { _Debt = value; }
        }

        private int _PublicECost;

        public int PublicECost
        {
            get { return _PublicECost; }
            set { _PublicECost = value; }
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

        //Constructor to edit hoa don
        public Invoice(string invoiceID, string purposeID, int oldNumber, int newNumber, int oldNumber2, int newNumber2, int multiplier, int debt, int publicECost)
        {
            this.InvoiceID = invoiceID;
            this.PurposeID = purposeID;
            this.OldNumber = oldNumber;
            this.NewNumber = newNumber;
            this.OldNumber2 = oldNumber2;
            this.NewNumber2 = newNumber2;
            this.Multiplier = multiplier;
            this.Debt = debt;
            this.PublicECost = publicECost;
        }

        //Constructor to create hoa don
        public Invoice(string customerID, string purposeID, int month, int year, int oldNumber, int newNumber, int oldNumber2, int newNumber2, int multiplier, int debt, int publicECost)
        {
            this.CustomerID = customerID;
            this.PurposeID = purposeID;
            this.Month = month;
            this.Year = year;
            this.OldNumber = oldNumber;
            this.NewNumber = newNumber;
            this.OldNumber2 = oldNumber2;
            this.NewNumber2 = newNumber2;
            this.Multiplier = multiplier;
            this.Debt = debt;
            this.PublicECost = publicECost;
        }

        //Sua hoa don
        public bool editHoaDon()
        {
            return editHoaDon(this);
        }

        //Lap hoa don
        public bool createHoaDon()
        {
            return createHoaDon(this);
        }

        //Lay hoa don ID
        public string getHoaDonID()
        {
            return getHoaDonID(this);
        }
    }

    class HoaDonFunctions : DataTier
    {
        //Sua hoa don
        protected bool editHoaDon(Invoice hd)
        {
            sqlCmd = "UPDATE tbl_Invoice SET OldNumber=@OldNumber,NewNumber=@NewNumber,OldNumber2=@OldNumber2,NewNumber2=@NewNumber2,Multiplier=@Multiplier,PurposeID=@PurposeID,Debt=@Debt,PublicECost=@PublicECost WHERE InvoiceID=@InvoiceID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@OldNumber", hd.OldNumber);
            cmd.Parameters.AddWithValue("@NewNumber", hd.NewNumber);
            cmd.Parameters.AddWithValue("@OldNumber2", hd.OldNumber2);
            cmd.Parameters.AddWithValue("@NewNumber2", hd.NewNumber2);
            cmd.Parameters.AddWithValue("@Multiplier", hd.Multiplier);
            cmd.Parameters.AddWithValue("@PurposeID", hd.PurposeID);
            cmd.Parameters.AddWithValue("@Debt", hd.Debt);
            cmd.Parameters.AddWithValue("@PublicECost", hd.PublicECost);
            cmd.Parameters.AddWithValue("@InvoiceID", hd.InvoiceID);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua hoa don thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua hoa don that bai
            return false;
        }

        //Lap hoa don
        protected bool createHoaDon(Invoice hd)
        {
            sqlCmd = "INSERT INTO tbl_Invoice(CustomerID,Month,Year,OldNumber,NewNumber,OldNumber2,NewNumber2,Multiplier,PurposeID,Debt,PublicECost,Status) VALUES(@CustomerID,@Month,@Year,@OldNumber,@NewNumber,@OldNumber2,@NewNumber2,@Multiplier,@PurposeID,@Debt,@PublicECost,@Status)";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@CustomerID", hd.CustomerID);
            cmd.Parameters.AddWithValue("@Month", hd.Month);
            cmd.Parameters.AddWithValue("@Year", hd.Year);
            cmd.Parameters.AddWithValue("@OldNumber", hd.OldNumber);
            cmd.Parameters.AddWithValue("@NewNumber", hd.NewNumber);
            cmd.Parameters.AddWithValue("@OldNumber2", hd.OldNumber2);
            cmd.Parameters.AddWithValue("@NewNumber2", hd.NewNumber2);
            cmd.Parameters.AddWithValue("@Multiplier", hd.Multiplier);
            cmd.Parameters.AddWithValue("@PurposeID", hd.PurposeID);
            cmd.Parameters.AddWithValue("@Debt", hd.Debt);
            cmd.Parameters.AddWithValue("@PublicECost", hd.PublicECost);
            cmd.Parameters.AddWithValue("@Status", hd.Status);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Lap hoa don thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Lap hoa don that bai
            return false;
        }

        //Lay hoa don ID
        protected string getHoaDonID(Invoice hd)
        {
            sqlCmd = "SELECT InvoiceID FROM tbl_Invoice WHERE CustomerID=@CustomerID AND Month=@Month AND Year=@Year";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@CustomerID", hd.CustomerID);
            cmd.Parameters.AddWithValue("@Month", hd.Month);
            cmd.Parameters.AddWithValue("@Year", hd.Year);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            string hoaDonID = "";
            while (rd.Read())
            {
                hoaDonID = rd[0].ToString();
            }
            rd.Close();
            con.Close();
            return hoaDonID;
        }
    }
}
