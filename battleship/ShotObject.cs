﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    public class ShotObject
    {
        private Square target;  //Square that is being attacked

        /// <summary>
        /// Default constructor, Unlikely to ever be used
        /// </summary>
        public ShotObject()
        {
            target = new Square();
        }
        public ShotObject(Square square)
        {
            target = square;
        }
        public Square getTarget()
        {
            return target;
        }
        public void setTarget(Square square)
        {
            target = square;
        }
    }
}
