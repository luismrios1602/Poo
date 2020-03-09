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
public class Planta extends Docente{
    String fechaContrato;
    int cantProyectos;

    public Planta(String tipoDocumento, String documento, String Apellidos, String Nombres, int edad, boolean activo, String profesion, String asignatura, String fechaContrato, int cantProtectos) {
        super(tipoDocumento, documento, Apellidos, Nombres, edad, activo, profesion, asignatura);
        
        this.fechaContrato = fechaContrato;
        this.cantProyectos = cantProtectos;
    }


    
    
    public String mostrar(){
        return mostrarInfo()+("\nProfesión: "+this.profesion
                            +"\nAsignatura: "+this.asginatura
                            +"\nFecha Contrato: "+this.fechaContrato
                            +"\nCantidad de Proyectos: "+this.cantProyectos);
    }
    
    public void setCantProyectos(int cantProyectos){
        
        this.cantProyectos = cantProyectos;
    }
    
}
