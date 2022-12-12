namespace net1
{
public class Caja {

// variables de la clase
    public int ancho;
    public int alto;
    public int profundo;

    public Caja(int ancho, int alto, int profundo) {

        this.ancho=ancho;
        this.alto=alto;
        this.profundo=profundo;

    }

    public double Volumen() {

        return ancho*alto*profundo;
    }
}
}