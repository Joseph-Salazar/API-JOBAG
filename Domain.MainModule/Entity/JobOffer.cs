using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Entity;

namespace Domain.MainModule.Entity
{
    public class JobOffer : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Wage { get; set; }
        public bool HasHired { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<JobLabel> JobLabels { get; set; }
        public ICollection<Postulation> Postulations { get; set; }
        public ICollection<SavedJobOffers> SavedJobOffers { get; set; }

    }
}
