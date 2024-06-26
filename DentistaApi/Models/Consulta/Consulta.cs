using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DentistaApi.Models;

public class Consulta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string Observacao { get; set; } = "";
    public string? Procedimentos { get; set; }
    public DateTime DataConsulta { get; set; }
    public DateTime? DataConsultaReserva { get; set; }
    public int TempoPrevisto { get; set; }
    public DateTime? DataHoraInicioAtendimento { get; set; }
    public DateTime? DataHoraFimAtendimento { get; set; }
    public bool Ausente { get; set; } = false;
    public int? PacienteId { get; set; }
    public Paciente? Paciente { get; set; }
    public string? NomePaciente { get; set; } 
    public string? Telefone { get; set; }
    public int? DentistaId { get; set; }
    public Dentista Dentista { get; set; }
    public int? PagamentoId { get; set; }
    public Pagamento Pagamento { get; set; }
    public string CorDentista { get; set; }
    public int? ConsultaEspecialidadeId { get; set; }
    public ConsultaEspecialidade ConsultaEspecialidade { get; set; }


    public void setIniciarConsulta()
    {
        if (DataHoraInicioAtendimento == null)
        {
            DataHoraInicioAtendimento = DateTime.Now;
        }
    }

    public void setFinalizarConsulta()
    {
        if (DataHoraFimAtendimento == null)
        {
            DataHoraFimAtendimento = DateTime.Now;
        }
    }

    public void setTempoPrevisto(int obj)
    {
        var data = DataConsulta;

        switch (obj)
        {
            case 1: { DataConsultaReserva = data.AddMinutes(15); break; }
            case 2: { DataConsultaReserva = data.AddMinutes(30); break; }
            case 3: { DataConsultaReserva = data.AddMinutes(45); break; }
            case 4: { DataConsultaReserva = data.AddMinutes(60); break; }
        }

    }

    public void setAusentarPaciente()
    {
        Ausente = true;
    }

    public void setPresencaPaciente()
    {
        Ausente = false;
    }
}