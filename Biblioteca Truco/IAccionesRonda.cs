using Biblioteca_Truco;
public interface IAccionesRonda
{
    public void Aceptar(Jugador jugadorUno, Jugador jugadorDos);
    public void Rechazar(Jugador jugadorRechazante);
    public void CierreDeRonda();
}