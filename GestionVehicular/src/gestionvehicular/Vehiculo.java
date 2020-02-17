package gestionvehicular;

public class Vehiculo {

    protected String placa;

    protected String marca;

    protected double kilometraje;

    protected String color;

    protected int puertas;

    protected int llantas;

    protected int motor; 

    protected int modelo;

    protected int cantPasajeros;

    public Vehiculo(String placa, String marca, double kilometraje, String color, int puertas, int llantas, int motor, int modelo, int cantPasajeros) {
        
        this.placa = placa;
        this.marca = marca;
        this.kilometraje = kilometraje;
        this.color = color;
        this.puertas = puertas;
        this.llantas = llantas;
        this.motor = motor;
        this.modelo = modelo;
        this.cantPasajeros = cantPasajeros;
    }

    public String getInfo() {
        return (placa+"\t"+marca+"\t"+kilometraje+"\t"+color+"\t"+puertas+"\t"+llantas+"\t"+motor+"\t"+modelo+"\t"+cantPasajeros);
    }

    public void actKilometraje(double kilometraje) {
        this.kilometraje = kilometraje;
        
        System.out.println("Kilometraje actualizado!");
    }
}
