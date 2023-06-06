using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFirstApp.Models
{
    [Table("Accounts")]
    public class Account
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<RelatedObject> RelatedObjects { get; set; }
    }
    [Table("RelatedObject")]
    public class RelatedObject
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public string SomeData { get; set; }

        [ForeignKey(typeof(Account))]
        public string UserId { get; set; }
    }
}
