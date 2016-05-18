﻿using NUnit.Common;
using NUnitLite;
using System;
using System.Reflection;

namespace NUnitWithDotNetCoreRC2.Test
{
    public class Program
    {
        public static int Main(string[] args)
        {
            return new AutoRun(typeof(Program).GetTypeInfo().Assembly)
                .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
        }
    }
}