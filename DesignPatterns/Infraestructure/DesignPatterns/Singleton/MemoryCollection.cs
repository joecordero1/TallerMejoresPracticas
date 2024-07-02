using DesignPatterns.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Infrastructure.Singleton
{
    public class MemoryCollection
    {
        private static MemoryCollection _instance;
        public VehicleCollection VehicleCollection { get; private set; }

        private MemoryCollection()
        {
            VehicleCollection = new VehicleCollection();
        }

        public static MemoryCollection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemoryCollection();
                }
                return _instance;
            }
        }
    }
}
