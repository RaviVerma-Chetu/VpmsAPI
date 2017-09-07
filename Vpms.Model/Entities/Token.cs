using System;

namespace Vpms.Model.Entities
{
    public class Token
    {
        public string  UserName { get; set; }
        public string TokenId { get; set; }
        public DateTime TokenExpireDate { get; set; }
    }
}