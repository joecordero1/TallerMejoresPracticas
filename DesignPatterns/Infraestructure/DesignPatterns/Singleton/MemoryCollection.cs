using DesignPatterns.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.DesignPatterns.Singleton
{
    public class MemoryCollection
    {
        private static MemoryCollection _instance;

        public ICollection<Vehicle> Vehicles { get; set; }

        private MemoryCollection()
        {
            Vehicles = new List<Vehicle>();
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
