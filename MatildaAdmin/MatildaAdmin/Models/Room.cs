//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public string MirrorUDID { get; set; }
        public int HotelID { get; set; }
        public string RoomNumber { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
