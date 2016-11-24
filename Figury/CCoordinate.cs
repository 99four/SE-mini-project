using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class CCoordinate
    {
        private int m_X;
        private int m_Y;

        public CCoordinate(int x, int y)
        {
            this.m_X = x;
            this.m_Y = y;
        }

        public int X
        {
            get
            {
                return m_X;
            }
            set
            {
               m_X = value;
            }
        }

        public int Y
        {
            get
            {
                return m_Y;
            }
            set
            {
                m_Y = value;
            }
        }
    }
}
