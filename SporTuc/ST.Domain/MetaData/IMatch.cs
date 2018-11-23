using System;

namespace ST.Domain.MetaData
{
    public interface IMatch
    {
        int NroMatch { get; set; }

        DateTime Date { get; set; }
    }
}
