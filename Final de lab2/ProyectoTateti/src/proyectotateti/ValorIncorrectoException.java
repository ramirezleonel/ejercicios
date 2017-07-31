package proyectotateti;

public class ValorIncorrectoException extends Exception {
    
    public ValorIncorrectoException(String error){
    super(error);
        System.out.println("Valor ingresado Incorrecto");
        
    }
    public ValorIncorrectoException(){
    super();
        System.out.println("Valor ingresado Incorrecto");
        
    }
}
