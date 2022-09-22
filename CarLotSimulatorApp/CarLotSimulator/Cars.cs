using System;
namespace CarLotSimulator
{
    public class Cars
    {
        public Cars()
        {
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDrivable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

        //public void PrintCarInfo()
        //{
        //    Console.WriteLine($"Year: {Year}");
        //    Console.WriteLine($"Make: {Make}");
        //    Console.WriteLine($"Model: {Model}");
        //    Console.WriteLine($"Engine Noise: {EngineNoise}");
        //    Console.WriteLine($"Honk Noise: {HonkNoise}");
        //    Console.WriteLine($"Is it Drivable?: {isDrivable}");
        //}
    }
}

