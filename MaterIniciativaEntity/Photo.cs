namespace MaterIniciativaEntity
{
    public class Photo
    {
        public int IdPhoto { get; set; }
        public int IdPlant { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Path { get; set; }
    }
}
