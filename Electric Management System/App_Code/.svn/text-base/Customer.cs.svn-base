using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Electric_Management_System.App_Code
{
    class Customer : CustomerFunctions
    {
        //Cac thuoc tinh cua Customer
        private String _CustomerID;

        public String CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        private String _StationID;

        public String StationID
        {
            get { return _StationID; }
            set { _StationID = value; }
        }

        private int _CustomerNumber;

        public int CustomerNumber
        {
            get { return _CustomerNumber; }
            set { _CustomerNumber = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _HKNumber;

        public string HKNumber
        {
            get { return _HKNumber; }
            set { _HKNumber = value; }
        }

        private string _TaxNumber;

        public string TaxNumber
        {
            get { return _TaxNumber; }
            set { _TaxNumber = value; }
        }

        //Constructor dung de them khach hang moi
        public Customer(String stationID, int customerNumber, string name, string address, string hkNumber, string taxNumber)
        {
            this.StationID = stationID;
            this.CustomerNumber = customerNumber;
            this.Name = name;
            this.Address = address;
            this.HKNumber = hkNumber;
            this.TaxNumber = taxNumber;
        }

        //Constructor dung de sua thong tin khach hang
        public Customer(String customerID, string name, string address, string hkNumber, string taxNumber)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Address = address;
            this.HKNumber = hkNumber;
            this.TaxNumber = taxNumber;
        }

        //Constructor dung de xac dinh khach hang
        public Customer(String customerID)
        {
            this.CustomerID = customerID;
        }

        //Them khach
        public bool add()
        {
            return this.add(this);
        }

        //Sua thong tin khach
        public bool edit()
        {
            return this.edit(this);
        }

        //Xoa khach
        public bool delete()
        {
            return this.delete(this);
        }
    }

    class CustomerFunctions : DataTier
    {
        //Them khach hang moi
        protected bool add(Customer C)
        {
            sqlCmd = "INSERT INTO tbl_Customer(StationID,CustomerNumber,Name,Address,HKNumber,TaxNumber) VALUES(@StationID,@CustomerNumber,@Name,@Address,@HKNumber,@TaxNumber)";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", C.StationID);
            cmd.Parameters.AddWithValue("@CustomerNumber", C.CustomerNumber);
            cmd.Parameters.AddWithValue("@Name", C.Name);
            cmd.Parameters.AddWithValue("@Address", C.Address);
            cmd.Parameters.AddWithValue("@HKNumber", C.HKNumber);
            cmd.Parameters.AddWithValue("@TaxNumber", C.TaxNumber);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Them khach hang moi thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Them khach hang moi that bai
            return false;
        }

        //Sua thong tin khach hang
        protected bool edit(Customer C)
        {
            sqlCmd = "UPDATE tbl_Customer SET Name=@Name, Address=@Address, HKNumber=@HKNumber, TaxNumber=@TaxNumber WHERE CustomerID=@CustomerID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Name", C.Name);
            cmd.Parameters.AddWithValue("@Address", C.Address);
            cmd.Parameters.AddWithValue("@HKNumber", C.HKNumber);
            cmd.Parameters.AddWithValue("@TaxNumber", C.TaxNumber);
            cmd.Parameters.AddWithValue("@CustomerID", C.CustomerID);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua thong tin khach hang thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua thong tin khach hang that bai
            return false;
        }

        //Xoa khach hang
        protected bool delete(Customer C)
        {
            sqlCmd = "UPDATE tbl_Customer SET Status=0 WHERE CustomerID=@CustomerID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@CustomerID", C.CustomerID);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Xoa khach hang thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Xoa khach hang that bai
            return false;
        }
    }
}