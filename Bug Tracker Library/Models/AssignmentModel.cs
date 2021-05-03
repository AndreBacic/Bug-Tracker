﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bug_Tracker_Library.Models
{
    /// <summary>
    /// A link between a User and a Project.
    /// </summary>
    public class AssignmentModel
    {
        public int Id { get; set; }
        /// <summary>
        /// The User this is assigned to.
        /// </summary>
        public UserModel Assignee { get; set; }
        /// <summary>
        /// The Project that Assignee is assigned to.
        /// </summary>
        public ProjectModel Project { get; set; }
        /// <summary>
        /// Position (level of access) Assignee has to Project.
        /// </summary>
        public UserPosition AssigneeAccess { get; set; }
        /// <summary>
        /// Hours of work Assignee has spent on Project.
        /// </summary>
        public double HoursLogged { get; set; }
    }
}
