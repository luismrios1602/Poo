package gestionvehicular;

public class Camioneta extends Vehiculo {

    private boolean plafon; 

    private double carga;

    private String trenDeTransmision;

    public Camioneta(String placa, String marca, double kilometraje, String color, int puertas, int llantas, int motor, int modelo, int cantPasajeros, boolean plafon, double carga, String trenDeTransmision ) {
        super(placa, marca, kilometraje, color, puertas, llantas, motor, modelo, cantPasajeros);
        this.plafon = plafon;
        this.carga = carga;
        this.trenDeTransmision = trenDeTransmision;
    }

    public String getInfoCamioneta() {
        return (super.getInfo()+"\t"+plafon+"\t"+carga+"\t"+trenDeTransmision+"\t");
    }
}
