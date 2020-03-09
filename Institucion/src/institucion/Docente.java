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
public class Docente extends Personal{
    protected String profesion;
    protected String asginatura;

    public Docente(String tipoDocumento, String documento, String Apellidos, String Nombres, int edad, boolean activo, String profesion, String asignatura) {
        super(tipoDocumento, documento, Apellidos, Nombres, edad, activo);
        
        this.profesion = profesion;
        this.asginatura = asignatura;
        
    }
    
       
    public void setAsignatura(String asignatura){
        
        this.asginatura = asignatura;
    
    }
}
