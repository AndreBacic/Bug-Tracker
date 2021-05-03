﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bug_Tracker_Library.Models
{
    /// <summary>
    /// A Project to be tracked and managed by the appliction.
    /// </summary>
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int ParentProjectId { get; set; }
        /// <summary>
        /// Lesser projects under the umbrella of this.
        /// </summary>
        public List<ProjectModel> SubProjects { get; set; }
        /// <summary>
        /// The Users assigned to work on this.
        /// </summary>
        public List<UserModel> Workers { get; set; }
        /// <summary>
        /// The description of this, which may be just a short statement or a very long list of instructions to Workers.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// All comments that the Workers have posted to this.
        /// </summary>
        public List<CommentModel> Comments { get; set; }
        /// <summary>
        /// The date that all work on this must be done.
        /// </summary>
        public DateTime Deadline { get; set; }
        public ProjectStatus Status { get; set; }
        public ProjectPriority Priority { get; set; }
    }
}
