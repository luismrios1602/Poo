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
public class Administrativo extends Personal{
    
    private String cargo;
    private String fechaContrato;

    public Administrativo(String tipoDocumento, String documento, String Apellidos, String Nombres, int edad, boolean activo, String cargo, String fechaContrato) {
        super(tipoDocumento, documento, Apellidos, Nombres, edad, activo);
        
        this.cargo = cargo;
        this.fechaContrato = fechaContrato;
    }
    
    
    
    
    public String mostrar(){
        return mostrarInfo()+("\nCargo: "+this.cargo
                            +"\nFecha Contrato: "+this.fechaContrato);
    }
    
    public void setCargo(String cargo){
        
        this.cargo = cargo;
    
    }
    
}
