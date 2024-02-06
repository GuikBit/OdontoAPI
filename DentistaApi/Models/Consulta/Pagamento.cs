using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DentistaApi.Models { 

    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public double ValorTotal { get; set; }
        public string? FormaDePagamento { get; set; } 
        public bool Pago { get; set; }
        public double Desconto { get; set; }
        public double Acrecimo { get; set; }
        public DateTime? DataDoPagamento { get; set; } 

    }
}