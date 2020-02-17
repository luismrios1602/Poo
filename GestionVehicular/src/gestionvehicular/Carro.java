package gestionvehicular;

public class Carro extends Vehiculo {

    private String tipoCarro;

    private String tipoTransmision;

    public Carro(String placa, String marca, double kilometraje, String color, int puertas, int llantas, int motor, int modelo, int cantPasajeros, String tipoCarro, String tipoTransmision) {
        super(placa, marca, kilometraje, color, puertas, llantas, motor, modelo, cantPasajeros);
        this.tipoCarro = tipoCarro;
        this.tipoTransmision = tipoTransmision;
    }

    public String getInfoCarro() {
        return (super.getInfo()+"\t"+tipoCarro+"\t"+tipoTransmision);
    }
}
