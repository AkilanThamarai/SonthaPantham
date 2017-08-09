using System;

using System.IO;
using SQLite;

namespace Sontham
{
    [Table("Contacts")]
    public class ToDoTask
    {

        [PrimaryKey, AutoIncrement, Column("_Id")]
        public int Id { get; set; }

        [MaxLength(50)]
        public string TContactName { get; set; }
        public string TFatherName { get; set; }
        public string TMName { get; set; }
        public string TSiblings1 { get; set; }
        public string TSiblings2 { get; set; }
        public string TAddress1 { get; set; }
        public string TAddress2 { get; set; }
        public string TCity { get; set; }
        public string TPincode { get; set; }
        public string TKootam { get; set; }
        public string TFamilyGod { get; set; }
        public string TJob { get; set; }
        public string TMobileNo1 { get; set; }
        public string TMobileNo2 { get; set; }
        public string TBirthPlace { get; set; }

    }
}