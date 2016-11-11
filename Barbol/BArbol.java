package aplicacion.arbol.Barbol;

public class BArbol {

    private Nodo primero;
    private static int num = 0;



    public boolean esHoja() {
        if (this.primero.getIzq() == null && this.primero.getDer() == null) {
            return true;
        } else {
            return false;
        }
    }

    public int getNumElemento() {
        return num++;
    }

    public Nodo getPrimero() {
        return primero;
    }

    public void setPrimero(Nodo primero) {
        this.primero = primero;
    }

   

}
