package Model;

public class Bike extends Vehicles {
    protected String frame;
    protected int transmission;
    protected String brakeSystem;
    protected String suspension;

    public Bike(String model, int maxSpeed, String frame, int transmission, String brakeSystem) {
        super(model, maxSpeed);
        this.frame = frame;
        this.transmission = transmission;
        this.brakeSystem = brakeSystem;
    }

    @Override
    public String toString() {
        return "Bike{" +
                "model='" + model + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", frame='" + frame + '\'' +
                ", transmission=" + transmission +
                ", brakeSystem='" + brakeSystem + '\'' +
                '}';
    }

    @Override
    public int getMaxSpeed() {
        return maxSpeed;
    }

    @Override
    public String getEnvironment() {
        return "Bike{" +
                "model='" + model + '\'' +
                ", registrationNumber='" + registrationNumber + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", frame='" + frame + '\'' +
                ", engineCylinders='" + engineCylinders + '\'' +
                ", transmission=" + transmission +
                ", brakeSystem='" + brakeSystem + '\'' +
                ", suspension='" + suspension + '\'' +
                ", gasTank=" + gasTank +
                ", fuel='" + fuel + '\'' +
                ", loadCapacity=" + loadCapacity +
                ", weight=" + weight +
                '}';
    }
}
