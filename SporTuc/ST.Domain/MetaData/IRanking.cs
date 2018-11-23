using System;

namespace ST.Domain.MetaData
{
    public interface IRanking
    {
        int Score { get; set; }

        DateTime Date { get; set; }
    }
}
