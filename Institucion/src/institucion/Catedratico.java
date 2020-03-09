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
public class Catedratico extends Docente{
    
    String fechaInicio;
    String fechaFin;

    public Catedratico(String tipoDocumento, String documento, String Apellidos, String Nombres, int edad, boolean activo, String profesion, String asignatura, String fechaInicio, String fechaFin) {
        super(tipoDocumento, documento, Apellidos, Nombres, edad, activo, profesion, asignatura);
        
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
    }

    
    public String mostrar(){
                
        return mostrarInfo()+("\nProfesión: "+this.profesion
                            +"\nAsignatura: "+this.asginatura
                            +"\nFecha Inicio: "+this.fechaInicio
                            +"Fecha Fin: "+this.fechaFin);
        
    }
    
    
}
