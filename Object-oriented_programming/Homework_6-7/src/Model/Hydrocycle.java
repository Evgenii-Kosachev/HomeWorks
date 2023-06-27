package Model;

public class Hydrocycle extends Vehicles {
    protected String boatHull;
    protected String waterCannon;
    protected int lifeJackets;

    public Hydrocycle(String model, int maxSpeed, String boatHull, String waterCannon, int lifeJackets) {
        super(model, maxSpeed);
        this.boatHull = boatHull;
        this.waterCannon = waterCannon;
        this.lifeJackets = lifeJackets;
    }

    @Override
    public String toString() {
        return "Hydrocycle{" +
                "model='" + model + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", boatHull='" + boatHull + '\'' +
                ", waterCannon='" + waterCannon + '\'' +
                ", lifeJackets=" + lifeJackets +
                '}';
    }

    @Override
    public int getMaxSpeed() {
        return maxSpeed;
    }

    @Override
    public String getEnvironment() {
        return "Hydrocycle{" +
                "model='" + model + '\'' +
                ", registrationNumber='" + registrationNumber + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", engineCylinders='" + engineCylinders + '\'' +
                ", boatHull='" + boatHull + '\'' +
                ", waterCannon='" + waterCannon + '\'' +
                ", lifeJackets=" + lifeJackets +
                ", gasTank=" + gasTank +
                ", fuel='" + fuel + '\'' +
                ", loadCapacity=" + loadCapacity +
                ", weight=" + weight +
                '}';
    }
}
