class Forecast
{
    Air[] airDataPerMonth;
    Water[] waterDataPerMonth;
}

class Air
{
    double windSpeed;
    double airTemperature;
}

class Water
{
    double amount;
    double intensity;
    double avgAmountPerLastMonth;
}
