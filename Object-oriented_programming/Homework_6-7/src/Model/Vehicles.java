package Model;

public abstract class Vehicles implements GetInfo {
    protected String model;
    protected String registrationNumber;

    protected String engineCylinders;
    protected int gasTank;
    protected String fuel;

    protected int loadCapacity;
    protected int maxSpeed;
    protected int weight;

    public Vehicles(String model, int maxSpeed) {
        this.model = model;
        this.maxSpeed = maxSpeed;
    }
}
