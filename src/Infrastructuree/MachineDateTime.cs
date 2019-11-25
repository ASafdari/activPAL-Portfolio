using System;
using Portfolio.Application.Common.Interfaces;

namespace Portfolio.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;
        public int CurrentDay => Now.Day;
        public int CurrentMonth => Now.Month;
        public int CurrentYear => Now.Year;
    }
}