package Model;

public class QuadBike extends Bike {
    public QuadBike(String model, int maxSpeed, String frame, int transmission, String brakeSystem) {
        super(model, maxSpeed, frame, transmission, brakeSystem);
    }

    @Override
    public String toString() {
        return "QuadBike{" +
                "model='" + model + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", frame='" + frame + '\'' +
                ", transmission=" + transmission +
                ", brakeSystem='" + brakeSystem + '\'' +
                '}';
    }

    @Override
    public String getEnvironment() {
        return "QuadBike{" +
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
