using TesteWeb.Domain;

namespace TestesWeb.Data;
public class Mock
{
    public static List<Usuario> Usuarios()
    {
        return new List<Usuario>
        {
            new Usuario("Alberto Quintero"),
            new Usuario("Alicia Cardin"),
            new Usuario("Amandio Igrejas")
        };
    }
}

