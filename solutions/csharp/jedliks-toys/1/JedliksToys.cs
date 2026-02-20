class RemoteControlCar
{
    private int distanceDisplay;
    private int bateria = 100; // batería empieza al 100%
    private int distanciaRecorrida=20;
    public static RemoteControlCar Buy()
    {
       return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this.distanceDisplay} meters";
    }

    public string BatteryDisplay()
    {
       if (this.bateria > 0) 
           return $"Battery at {this.bateria}%";
       else 
           return "Battery empty";
    }
    public void Drive()
    {      
      if (this.bateria > 0){
        this.bateria-=1;
        this.distanceDisplay+=distanciaRecorrida;  
      }        
    }
}
