using StatePattern;

AmphibiousVehicle amphibiousVehicle = new AmphibiousVehicle();

amphibiousVehicle.Accelerate();
amphibiousVehicle.SlowDown();

Console.WriteLine();

amphibiousVehicle.PrepareForWater();
amphibiousVehicle.Accelerate();
amphibiousVehicle.SlowDown();

Console.ReadKey();


