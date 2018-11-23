using ST.Service.Base.DTOs;

namespace ST.IService.Complex.DTOs
{
    public class FieldDto : DtoBase
    {
        public int Quantity { get; set; }

        public long SportId { get; set; }

        public long ComplexId { get; set; }

    }
}
