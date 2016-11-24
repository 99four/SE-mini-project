using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CCircle : CShape
    {
        protected int m_Radius { get; set; }

        override
        public void Draw(Graphics g, Pen p)
        {

        }

        override
        public void Save(XmlNode root)
        {

        }

        override
        public bool Load(XmlNode root)
        {
            return true;
        }

        override
        public void CreateFromPoints(CCoordinate point1, CCoordinate point2)
        {

        }

        public CCircle(CCoordinate center, int radius)
        {

        }

        public CCoordinate Center()
        {
            return m_Coordinate;
        }

        public int Radius()
        {
            return m_Radius;
        }
    }
}
