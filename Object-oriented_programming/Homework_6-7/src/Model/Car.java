package Model;

public class Car extends Bike {
    protected String body;
    protected int seatBelts;
    protected String airConditioner;

    public Car(String model, int maxSpeed, String frame, int transmission, String brakeSystem, int seatBelts, String airConditioner) {
        super(model, maxSpeed, frame, transmission, brakeSystem);
        this.seatBelts = seatBelts;
        this.airConditioner = airConditioner;
    }

    @Override
    public String toString() {
        return "Car{" +
                "model='" + model + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", frame='" + frame + '\'' +
                ", transmission=" + transmission +
                ", brakeSystem='" + brakeSystem + '\'' +
                ", seatBelts=" + seatBelts +
                ", airConditioner='" + airConditioner + '\'' +
                '}';
    }

    @Override
    public String getEnvironment() {
        return "Car{" +
                "model='" + model + '\'' +
                ", registrationNumber='" + registrationNumber + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", frame='" + frame + '\'' +
                ", body='" + body + '\'' +
                ", engineCylinders='" + engineCylinders + '\'' +
                ", transmission=" + transmission +
                ", brakeSystem='" + brakeSystem + '\'' +
                ", suspension='" + suspension + '\'' +
                ", gasTank=" + gasTank +
                ", fuel='" + fuel + '\'' +
                ", seatBelts=" + seatBelts +
                ", airConditioner='" + airConditioner + '\'' +
                ", loadCapacity=" + loadCapacity +
                ", weight=" + weight +
                '}';
    }
}
