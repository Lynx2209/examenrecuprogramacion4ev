using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenrecuprogramacion4ev.Dtos
{
    internal class Dto
    {
        double id;
        string dni;
        DateTime fchCompra;
        string matricula;
        string esHistorico;

        public Dto(double id, string dni, DateTime fchCompra, string matricula, string esHistorico)
        {
            this.id = id;
            this.dni = dni;
            this.fchCompra = fchCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
        }

        public double Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string EsHistorico { get => esHistorico; set => esHistorico = value; }

    }
}
