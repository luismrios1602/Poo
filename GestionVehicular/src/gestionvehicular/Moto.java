package gestionvehicular;

public class Moto extends Vehiculo {

    private String tipoMoto;

    public Moto(String placa, String marca, double kilometraje, String color, int puertas, int llantas, int motor, int modelo, int cantPasajeros, String tipoMoto) {
        super(placa, marca, kilometraje, color, puertas, llantas, motor, modelo, cantPasajeros);
        this.tipoMoto = tipoMoto;
    }

    public String getInfoMoto() {
        return (super.getInfo()+"\t"+tipoMoto);
    }
}
