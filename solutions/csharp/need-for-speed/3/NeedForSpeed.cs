public class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery < batteryDrain;
    
    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()=> new RemoteControlCar(50, 4);
    
}

public class RaceTrack
{
    private int distance;

    public RaceTrack(int distance) =>this.distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
            if (car.DistanceDriven() >= distance)
                return true;
        }

        return false;
    }
}
