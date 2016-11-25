using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CLine : CShape
    {
        protected CCoordinate m_End { get; set; }

        public CLine() { }

        public CLine(CCoordinate point1, CCoordinate point2)
        {
            this.m_Coordinate = point1;
            this.m_End = point2;
        }

        override
        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, m_Coordinate.X, m_Coordinate.Y, m_End.X, m_End.Y);
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
            this.m_Coordinate = point1;
            this.m_End = point2;
        }
        
        public CCoordinate Start()
        {
            return m_Coordinate;
        }

        public CCoordinate End()
        {
            return m_End;
        }
    }
}
