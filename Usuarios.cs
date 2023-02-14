namespace Parte1;

public class Usuarios
{
    public List<Alumnos> alumnos = new List<Alumnos>()
    {
        new Alumnos
        {
            Id = 1,
            Name = "alan",
            Password = "1234"
        },
        new Alumnos
        {
            Id = 2,
            Name = "marcos",
            Password = "12"
        }
    };
}

public class Alumnos
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
}
