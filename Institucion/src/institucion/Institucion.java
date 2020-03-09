/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package institucion;

/**
 *
 * @author CBN
 */
public class Institucion {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Alumnos alum=new Alumnos("CC", "1148701554", "RIOS PEREZ", "LUIS MIGUEL", 24, true, "2019A1214", "TIC", "DSAM", 3);
        Planta docPlan = new Planta("CC", "57424125", "ROSALES", "MARTIN", 57, true, "Ingeniero", "POO II", "2020/01/02", 3);
        
        System.out.println(alum.mostrar());
        System.out.println("");
        System.out.println(docPlan.mostrar());
    }
    
}
