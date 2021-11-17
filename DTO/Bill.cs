using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
                var dataCheckOutTemp = row["dataCheckOut"];
                if (dataCheckOutTemp.ToString() != "")
                //For cases where the object is null, we check if the value is null ot not. 
                //When the value returns null, we have to string to resolve even though the value is not null by nature.
                this.DateCheckOut = (DateTime?)row["dateCheckOutTemp"];
            this.Status = (int)row["status"]; 
        }

        private int iD;
        public int ID 
        { 
            get => iD; 
            set => iD = value; 
        }

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn 
        { 
            get => dateCheckIn;
            set => dateCheckIn = value;
        }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut 
        { 
            get => dateCheckOut; 
            set => dateCheckOut = value; 
        }

        private int status;
        public int Status 
        { 
            get => status; 
            set => status = value; 
        }
       
    }
}
