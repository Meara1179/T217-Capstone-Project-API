﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using T217_Capstone_Project_API.Models.Projects;

namespace T217_Capstone_Project_API.Models.Risks
{
    public class EnvironmentalRiskDTO
    {
        public int StakeholderGroupID { get; set; }

        public int ChangeVolume { get; set; }

        public int Infrastructure {  get; set; }

        public int Industry { get; set; }

        public int OfficePolitics { get; set; }
    }
}
