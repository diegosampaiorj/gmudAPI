using System;
using System.Collections.Generic;
using System.Text;

namespace Gmud.API.Domain.Entities
{
    public class Candidacy
    {
        public int ID { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataGMUD { get; set; }
        public int testId { get; set; }
    }
}
