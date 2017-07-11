using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCWithMongo.Models
{
    public class UserModel
    {
        public object _id { get; set; } //MongoDb uses this field as ideantity.

        public int ID { get; set; } 

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string PhoneNo { get; set; }

        public string Address { get; set; }


    }
}