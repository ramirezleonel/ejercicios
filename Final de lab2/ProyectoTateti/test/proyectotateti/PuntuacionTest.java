package proyectotateti;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Usuario
 */
public class PuntuacionTest {

     Player jugador1;

    Tablero tablero1, tablero2;

    public PuntuacionTest() {
    }

    @Before
    public void setUp() {

        jugador1 = new Player(Ficha.X, "Roberto");

        tablero1 = new Tablero();
        tablero2 = new Tablero();

        String dibujoFicha = "X";
        //PRUEBA DIAGONAL DE IZQUIERDA A DERECHA TABLERO1
        tablero1.figura1.getCeldas()[0][0].setMarcado(true, dibujoFicha);
        tablero1.figura1.getCeldas()[1][1].setMarcado(true, dibujoFicha);
        tablero1.figura1.getCeldas()[2][2].setMarcado(true, dibujoFicha);

        //PRUEBA DIAGONAL DE IZQUIERDA A DERECHA TABLERO2
        tablero2.figura2.getCeldas()[0][0].setMarcado(true, dibujoFicha);
        tablero2.figura2.getCeldas()[1][1].setMarcado(true, dibujoFicha);
        tablero2.figura2.getCeldas()[2][2].setMarcado(true, dibujoFicha);

        //PRUEBA DIAGONAL DE DERECHA A IZQUIERDA
        tablero1.figura2.getCeldas()[0][2].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[1][1].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[2][0].setMarcado(true, dibujoFicha);

        //PRUEBA HORIZONTAL DESDE EL MEDIO
        tablero1.figura2.getCeldas()[1][0].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[1][1].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[1][2].setMarcado(true, dibujoFicha);

        //PRUEBA VERTICAL 
        tablero1.figura2.getCeldas()[0][0].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[1][0].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[2][0].setMarcado(true, dibujoFicha);

        //PRUEBA TRES FIGURA
        tablero1.figura1.getCeldas()[0][0].setMarcado(true, dibujoFicha);
        tablero1.figura2.getCeldas()[0][0].setMarcado(true, dibujoFicha);
        tablero1.figura3.getCeldas()[0][0].setMarcado(true, dibujoFicha);
    }

    @After
    public void tearDown() {
    }

    @Test
    public void testPatron1() {
        System.out.println("patron1 En tres figuras");

        int expResult = 1;
        int result = Puntuacion.patron1(tablero1, jugador1);
        assertEquals(expResult, result);

    }

    @Test
    public void testPatron2() {
        System.out.println("patron2 Horizontal");

        int expResult1 = 1;
        int expResult2 = 0;

        int result1 = Puntuacion.patron2(tablero1, jugador1);
        int result2 = Puntuacion.patron2(tablero2, jugador1);

        assertEquals(expResult1, result1);
        assertEquals(expResult2, result2);

    }

    @Test
    public void testPatron3() {
        System.out.println("patron3 vertical");

        int expResult = 1;
        int result = Puntuacion.patron3(tablero1, jugador1);
        assertEquals(expResult, result);

    }

    @Test
    public void testPatron4() {
        System.out.println("patron4 Diagonal der a izq");

        int expResult1 = 1;
        int expResult2 = 0;

        int result1 = Puntuacion.patron4(tablero1, jugador1);
        int result2 = Puntuacion.patron4(tablero2, jugador1);

        assertEquals(expResult1, result1);
        assertEquals(expResult2, result2);

    }
    @Test
    public void testPatron5() {
        System.out.println("patron5 Diagonal Izq a Der");

        int expResult1 = 1;
        int expResult2 = 1;
        int result1 = Puntuacion.patron5(tablero1, jugador1);
        int result2 = Puntuacion.patron5(tablero2, jugador1);
        assertEquals(expResult1, result1);
        assertEquals(expResult2, result2);

    }

}
