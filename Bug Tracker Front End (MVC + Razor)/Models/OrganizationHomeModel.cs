﻿using Bug_Tracker_Library.Models;

namespace Bug_Tracker_Front_End__MVC_plus_Razor.Models
{
    public class OrganizationHomeModel
    {
        public OrganizationModel Organization { get; set; }
        public UserModel User { get; set; }
        public AssignmentModel UserAssignment { get; set; }
    }
}
