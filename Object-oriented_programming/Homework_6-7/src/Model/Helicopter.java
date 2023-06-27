package Model;

public class Helicopter extends Vehicles {
    protected String fuselage;
    protected int finalHeight;
    protected int diameterMainScrew;
    protected int tailRotorDiameter;

    public Helicopter(String model, int maxSpeed, String fuselage, int finalHeight) {
        super(model, maxSpeed);
        this.fuselage = fuselage;
        this.finalHeight = finalHeight;
    }

    @Override
    public String toString() {
        return "Helicopter{" +
                "model='" + model + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", fuselage='" + fuselage + '\'' +
                ", finalHeight=" + finalHeight +
                '}';
    }

    @Override
    public int getMaxSpeed() {
        return maxSpeed;
    }

    @Override
    public String getEnvironment() {
        return "Helicopter{" +
                "model='" + model + '\'' +
                ", registrationNumber='" + registrationNumber + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", engineCylinders='" + engineCylinders + '\'' +
                ", fuselage='" + fuselage + '\'' +
                ", finalHeight=" + finalHeight +
                ", diameterMainScrew=" + diameterMainScrew +
                ", tailRotorDiameter=" + tailRotorDiameter +
                ", gasTank=" + gasTank +
                ", fuel='" + fuel + '\'' +
                ", loadCapacity=" + loadCapacity +
                ", weight=" + weight +
                '}';
    }
}
