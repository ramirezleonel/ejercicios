package javaapplication2;

public class Cajas {
    
    private Cola cola1;
    private Cola cola2;
    private Cola cola3;
    private int perSeFueron=0;
    private int clientesTotal=0;
    private int clientesEnLacola=0;

    public int getClientesEnLacola() {
        clientesEnLacola=cola1.getTamaño()+cola2.getTamaño()+cola3.getTamaño();
        return clientesEnLacola;
    }

   
    @Override
    public String toString() {
        return "Cajas" + "clientesAtendidos=" +"cola1: "+ cola1.getClientesAtendidos() + "cola2:"
                +cola2.getClientesAtendidos()+"cola3:"+cola3.getClientesAtendidos();
    }
   


    public int getClientesTotal() {
        return clientesTotal;
    }

    public void setClientesTotal(int clientesTotal) {
        this.clientesTotal = clientesTotal;
    }

    public int getPerSeFueron() {
        return perSeFueron;
    }

    public Cajas() {
        cola1=new Cola();
        cola2=new Cola();
        cola3=new Cola();
        this.cola1.setMinCajera(7);
        this.cola2.setMinCajera(9);
        this.cola3.setMinCajera(11);
        
    }
    
    public Cola getCola1() {
        return cola1;
    }

    public void setCola1(Cola cola1) {
        this.cola1 = cola1;
    }

    public Cola getCola2() {
        return cola2;
    }

    public void setCola2(Cola cola2) {
        this.cola2 = cola2;
    }

    public Cola getCola3() {
        return cola3;
    }

    public void setCola3(Cola cola3) {
        this.cola3 = cola3;
    }

    public void elegirCaja() {
        if (!cola1.sonMasDeSeis()&&!cola2.sonMasDeSeis()&&!cola3.sonMasDeSeis()) {
            if (cola1.getTamaño() <= cola2.getTamaño() && cola1.getTamaño() <= cola3.getTamaño()) {
                cola1.encolar();

            } else if (cola2.getTamaño() <= cola1.getTamaño() && cola2.getTamaño() <= cola3.getTamaño()) {
                cola2.encolar();
            } else if (cola3.getTamaño() <= cola1.getTamaño() && cola3.getTamaño() <= cola2.getTamaño()) {
                cola3.encolar();
            }
        }else{
        perSeFueron++;
        
        }
        clientesTotal++;
    }
}
