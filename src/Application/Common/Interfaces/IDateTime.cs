using System;

namespace Portfolio.Application.Common.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get; }
        int CurrentDay { get; }
        int CurrentMonth { get; }
        int CurrentYear { get; }
    }
}