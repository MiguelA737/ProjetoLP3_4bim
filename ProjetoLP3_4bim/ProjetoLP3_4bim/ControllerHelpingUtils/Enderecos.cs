using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLP3_4bim.ControllerHelpingUtils
{
    public class Enderecos
    {
        public Enderecos(string local, int id)
        {
            this.Id = id;
            this.Local = local;
        }

        [Column("Id")]
        public int Id { get; set; }

        [Column("Local")]
        public string Local { get; set; }
    }
}
