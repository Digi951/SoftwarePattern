using StatePattern;
using StatePattern.Context;

AmphibiousVehicle amphibiousVehicle = new ();

amphibiousVehicle.Accelerate();
amphibiousVehicle.SlowDown();

Console.WriteLine();

amphibiousVehicle.PrepareForWater();
amphibiousVehicle.Accelerate();
amphibiousVehicle.SlowDown();

Console.ReadKey();


