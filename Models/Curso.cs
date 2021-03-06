namespace HolaMundoMVC.Models;

public class Curso : ObjetoEscuelaBase
{
    public override string Nombre { get; set; }
    public TiposJornada Jornada { get; set; }
    public List<Asignatura>? Asignaturas { get; set; }
    public List<Alumno>? Alumnos { get; set; }
    public string Direccion { get; set; }
    public string? EscuelaId { get; set; }
    public Escuela? Escuela { get; set; }
}
