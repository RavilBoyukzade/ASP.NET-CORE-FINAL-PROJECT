using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class CaseStudSpec:BaseEntity
    {
        public int CaseStudyId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public CaseStud CaseStudy { get; set; }
    }
}
