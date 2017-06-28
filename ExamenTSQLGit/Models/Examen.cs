using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenTSQLGit.Models
{
    public class Examen
    {
        public string NombreEvaluado { get; set; }
        public List<Preguntas> Preguntas { get; set; }
    }
}
