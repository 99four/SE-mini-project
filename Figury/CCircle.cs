using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CCircle : CShape
    {
        protected double m_Radius { get; set; }
        private CRectangle rectangle;

        override
        public void Draw(Graphics g, Pen p)
        {
            g.DrawEllipse(p, this.rectangle.ULCoordinate().X, this.rectangle.ULCoordinate().Y, this.rectangle.Width(), this.rectangle.Height());
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
            rectangle = new CRectangle();
            rectangle.CreateFromPoints(point1, point2);
            this.m_Radius = Math.Sqrt(Math.Pow(point1.Y - point2.Y, 2) + Math.Pow(point2.X - point1.X, 2));
        }

        public CCircle(CCoordinate center, int radius)
        {

        }

        public CCircle()
        {

        }

        public CCoordinate Center()
        {
            return m_Coordinate;
        }

        public double Radius()
        {
            return m_Radius;
        }
    }
}
