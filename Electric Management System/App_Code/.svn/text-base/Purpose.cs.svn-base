using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Electric_Management_System.App_Code
{
    class Purpose : MucDichSDFunctions
    {
        private string _PurposeID;

        public string PurposeID
        {
            get { return _PurposeID; }
            set { _PurposeID = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private bool _Type;

        public bool Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _Price;

        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public Purpose(string purposeID, string price)
        {
            this.PurposeID = purposeID;
            this.Price = price;
        }

        public bool editPrice()
        {
            return editPrice(this);
        }
    }

    class MucDichSDFunctions : DataTier
    {
        //Sua gia dien
        protected bool editPrice(Purpose p)
        {
            sqlCmd = "UPDATE tbl_Purpose SET Price=@Price WHERE PurposeID=@PurposeID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Price", p.Price);
            cmd.Parameters.AddWithValue("@PurposeID", p.PurposeID);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua gia dien thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua gia dien that bai
            return false;
        }
    }
}
