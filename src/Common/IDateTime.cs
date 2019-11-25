using System;

namespace Portfolio.Common
{
    public interface IDateTime
    {
        DateTime Now { get; }
        int CurrentDay { get; }
        int CurrentMonth { get; }
        int CurrentYear { get; }
    }
}