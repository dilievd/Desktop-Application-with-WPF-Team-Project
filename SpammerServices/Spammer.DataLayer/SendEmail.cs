//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spammer.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SendEmail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public System.DateTime SendDate { get; set; }
        public string Recipients { get; set; }
        public string Subject { get; set; }
    
        public virtual User User { get; set; }
    }
}