using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_App.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }


        public Account()
        {

        }
    }

}
