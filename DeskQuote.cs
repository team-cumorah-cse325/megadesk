﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megaDesk
{
    internal class DeskQuote
    {
        public double _quote { get; }
        public string _customerName { get; }
        public string _productionTime { get; }
        public DateTime _quoteDate { get; }
        public int[,] _rushOrderOptions;
        public Desk _desk { get; }
     
        private Dictionary<Desk.Material, int> materialPrices = new()
        {
            [Desk.Material.Pine] = 50,
            [Desk.Material.Laminate] = 100,
            [Desk.Material.Veneer] = 125,
            [Desk.Material.Oak] = 200,
            [Desk.Material.Rosewood] = 300
        };

        public DeskQuote(string customerName, Desk desk, string productionTime, DateTime quoteDate)
        {
            _customerName = customerName;
            _desk = desk;
            _productionTime = productionTime;
            _quoteDate = quoteDate;
            _rushOrderOptions = getRushOrder();
            _quote = calculateQuote();
        }

        public int[,] getRushOrder()
        {
            int[,] options = new int[3, 3];
            string[] lines = System.IO.File.ReadAllLines("../../../rushOrderDocument.txt");
            int count = (int)Math.Sqrt(lines.Length);
            int lineCount = 0;
            
            for (int i=0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    options[i, j] = Int32.Parse(lines[lineCount]);
                    lineCount++;
                }
            }
            Debug.WriteLine(options[0,0]);
            return options;
        }

        int calculateQuote()
        {
            int quote = 200;
            int optionX = -1;
            int optionY = -1;

            quote += materialPrices[_desk._material];
            quote += _desk._drawerCount * 50;

            if (_desk._size > 1000)
            {
                quote += _desk._size - 1000;
            }

            if (_desk._size < 1000)
            {
                optionX = 0;
            }
            else if (_desk._size <= 2000)
            {
                optionX = 1;
            }
            else
            {
                optionX = 2;
            }

            if (_productionTime == "3 Day")
            {
                optionY = 0;
            }
            else if (_productionTime == "5 Day")
            {
                optionY = 1;
            }
            else if (_productionTime == "7 Day")
            {
                optionY = 2;
            }

            if (optionY >= 0)
            {
                quote += _rushOrderOptions[optionY, optionX];
            }

            return quote;
        }
    }
}
