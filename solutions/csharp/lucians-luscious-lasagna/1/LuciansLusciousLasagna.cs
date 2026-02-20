class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int tiempoPasado) =>                                                 ExpectedMinutesInOven()-tiempoPasado;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int capas)=> capas * 2;
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int capas, int tiempoHorno)=>                                 PreparationTimeInMinutes(capas)+tiempoHorno;
}
