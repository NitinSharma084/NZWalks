namespace NZWalks.API.Models.DTOs
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Lengthinkm { get; set; }
        public string WalkImageUrl { get; set; }
    }
}
