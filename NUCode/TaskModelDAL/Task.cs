//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskModelDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int id { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateStarted { get; set; }
        public Nullable<DateTime> DateCompleted { get; set; }
        public string EstimatedDuration { get; set; }
        public bool isCompleted { get; set; }
        public string Description { get; set; }
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public string Tag3 { get; set; }
    }
}