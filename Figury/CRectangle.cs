using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CRectangle : CShape
    {
        protected int m_Width { get; set; }
        protected int m_Height { get; set; }

        override
        public void Draw(Graphics g, Pen p)
        {
            g.DrawRectangle(p, m_Coordinate.X, m_Coordinate.Y, this.m_Width, this.m_Height);
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

        public CRectangle(CCoordinate corner, int width, int height)
        {
            this.m_Coordinate = corner;
            this.m_Width = width;
            this.m_Height = height;
        }

        public CCoordinate ULCoordinate()
        {
            return m_Coordinate;
        }

        public int Width()
        {
            return 1;
        }

        public int Height()
        {
            return 1;
        }
    }
}
