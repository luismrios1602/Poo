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
public class Personal {
    protected String tipoDocumento;
    protected String documento;
    protected String Apellidos;
    protected String Nombres;
    protected int edad;
    protected boolean activo;
    

    public Personal(String tipoDocumento, String documento, String Apellidos, String Nombres, int edad, boolean activo){
        
        this.tipoDocumento = tipoDocumento;
        this.documento = documento;
        this.Apellidos = Apellidos;
        this.Nombres = Nombres;
        this.edad = edad;
        this.activo = activo;
    
    }
    
    public String mostrarInfo(){
        return ("Tipo de documento: "+this.tipoDocumento
                +"\nDocumento: "+this.documento
                +"\nApellidos: "+this.Apellidos
                +"\nNombres"+this.Nombres
                +"\nEdad: "+this.edad
                +"\nActivo: "+this.activo);
        
    }
    
    public void setEdad(int edad){
        this.edad = edad;
    }
    
    public void setActivo(boolean activo){
        this.activo = activo;

    }
    
    
}
