﻿namespace T217_Capstone_Project_API.Models.Projects
{
    public class Project
    {
        public int ProjectID { get; set; }
        public int ProjectUserID { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime EditDateTime { get; set; }
        public string Status { get; set; }
    }
}