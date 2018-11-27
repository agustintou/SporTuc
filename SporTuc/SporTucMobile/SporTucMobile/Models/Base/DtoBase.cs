using SQLite;

namespace SporTucMobile.Models.Base
{
    public class DtoBase
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
