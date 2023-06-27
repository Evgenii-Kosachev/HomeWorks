import Model.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Program {
    public static void main(String[] args) {
        List<Vehicles> garage = new ArrayList<>(Arrays.asList(
                new Bike("BMW G 310 R", 145, "трубчатая, стальная", 6, "дисковые"),
                new QuadBike("RM 800 DUO", 100, "трубчатая, стальная", 3, "Дисковый гидравлический"),
                new Car("Ford Fiesta", 135, "McPherson", 6, "Дисковые вентилируемые", 4, "есть"),
                new Hydrocycle("SEA-DOO PERFORMANCE RXP-X 300", 80, "Стекловолокно", "Технология Advanced Combustion Efficiency", 2),
                new Helicopter("GEN H-4", 125, "отсутствует", 3000)));

        garage.add(new Bike("KAWASAKI NINJA 400", 183, "Птичья клетка", 6, "лепестковый диск"));
        garage.add(new Bike("SUZUKI SV650 ABS (SV650A)", 203, "алюминиевая трубчатая", 6, "дисковые"));
        garage.add(new Bike("YAMAHA XJ6", 180, "трубчатая, стальная", 6, "дисковые"));
        garage.add(new Bike("BMW F 800 GT", 223, "алюминиевая трубчатая", 6, "дисковые"));
        garage.add(new Bike("HARLEY-DAVIDSON SUPERLOW", 170, "трубчатая, стальная", 5, "дисковые"));

        garage.add(new QuadBike("Stels ATV 650 Guepard ST", 90, "трубчатая, стальная", 0, "Дисковый гидравлический"));
        garage.add(new QuadBike("Yamaha YFZ450R SE", 82, "алюминиевая трубчатая", 3, "Дисковый гидравлический"));
        garage.add(new QuadBike("CFMOTO CFORCE 600 S EPS", 86, "трубчатая, стальная", 4, "Дисковый гидравлический"));
        garage.add(new QuadBike("Polaris Sportsman 570", 76, "трубчатая, стальная", 0, "Дисковый гидравлический"));

        garage.add(new Car("Kia Picanto", 160, "McPherson", 4, "Дисковые вентилируемые", 4, "нет"));
        garage.add(new Car("Infiniti QX60", 190, "независимая, пружинная", 0, "дисковые вентилируемые", 4, "есть"));
        garage.add(new Car("Nissan Juke", 145, "McPherson", 4, "дисковые вентилируемые", 4, "нет"));
        garage.add(new Car("Audi А3", 220, "независимая, пружинная", 8, "дисковые вентилируемые", 4, "есть"));
        garage.add(new Car("Lexus ES 200", 200, "независимая, пружинная", 6, "дисковые вентилируемые", 4, "есть"));
        garage.add(new Car("Honda Talon 1000X", 140, "Независимая", 6, "Dual Гидравлические", 2, "нет"));

        garage.add(new Hydrocycle("YAMAHA FX CRUISER SVHO", 90, "NanoXcel", "WaveRunner FX Cruiser SVHO", 2));
        garage.add(new Hydrocycle("SEA-DOO SPARK TRIXX 3UP", 85, "Polytec™", "900 ACE™- 90", 2));

        garage.add(new Helicopter("Air Scooter 2", 110, "нет", 2100));
        garage.add(new Helicopter("Dynali H2S", 165, "есть", 3600));
        garage.add(new Helicopter("DF Helicopters DF334", 148, "есть", 3800));

        for (Vehicles v : garage) {
            System.out.println(v.getMaxSpeed());
            System.out.println(v.toString());
            System.out.println(v.getEnvironment() + "\n");
        }
    }
}
