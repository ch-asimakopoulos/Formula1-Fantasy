using F1Fantasy.SharedKernel.BaseModel;
using System;

namespace F1Fantasy.Core.Domain
{
    /// <summary>
    /// A class that contains information regarding a Formula 1 Fantasy League.
    /// </summary>
    public class League : TrackingChangesEntity
    {
        /// <summary>
        /// The league's unique identifier.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// The league's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The league's logo.
        /// </summary>
        public string Logo { get; set; }
        /// <summary>
        /// The league administrator's unique identifier.
        /// </summary>
        public string AdminId { get; set; }
        /// <summary>
        /// The league leading team's unique identifier.
        /// </summary>
        public long LeadingTeamId { get; set; }


        //public ICollection<Team> Teams { get; set; }


        //public virtual Team LeadingTeam { get; set; }
        //public virtual ApplicationUser AdminUser { get; set; }

    }
}
