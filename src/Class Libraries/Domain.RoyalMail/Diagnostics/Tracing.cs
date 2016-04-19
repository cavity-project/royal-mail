﻿namespace Cavity.Diagnostics
{
    using System.Diagnostics;

    internal static class Tracing
    {
        internal static TraceSwitch Is
        {
            get
            {
                return new TraceSwitch("Cavity.Domain.RoyalMail", string.Empty);
            }
        }
    }
}