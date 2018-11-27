namespace SporTucMobile.Models
{
    public class Parameter
    {
        public long Id { get; set; }

        public string URLBase { get; set; }

        public override int GetHashCode()
        {
            return (int)Id;
        }
    }
}
