namespace Lab.MVC.Models
{
    public class PersonModel 
    {
        public string Name { get; set; }
        public string Mass { get; set; }
        public string Height { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string Gender { get; set; }
        public string Birth { get; set; }
        public string Homeworld { get; set; }
    }

    public class PlanetModel 
    {
        public string Name { get; set; }
        public int RotationPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Population { get; set; }
    }

    public class SpeciesModel 
    {
        public string Name { get; set; }
        public string Clasification { get; set; }
        public string Designation { get; set; }
        public string AvgHeight { get; set; }
        public string EyeColors { get; set; }
        public string AvgLifespan { get; set; }
        public string Language { get; set; }
    }

    public class ShipsModel
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Length { get; set; }
        public string Class { get; set; }
        public string Cost { get; set; }
        public string MaxSpeed { get; set; }
        public string Crew { get; set; }
    }
}