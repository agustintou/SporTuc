﻿using ST.Service.Base.DTOs;

namespace ST.IService.Complex.DTOs
{
    public class ServiceDto : DtoBase
    {
        public int Code { get; set; }

        public string Description { get; set; }

        public bool Delete { get; set; }
    }
}
