using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private int id;
        public int Id { 
            get => id; 
            set => id = value; 
        }

        private string name;
        public string Name { 
            get => name; 
            set => name = value; 
        }

        private string status;
        public string Status { 
            get => status; 
            set => status = value; 
        }
    }
}
