namespace BlazorWasm.Zodiac.Models
{
    public class ZodiacSignModel
    {
        public string Name { get; set; }
        public string Dates { get; set; }
        public string Element { get; set; }
        public List<TraitModel> Traits { get; set; }
    }
}
