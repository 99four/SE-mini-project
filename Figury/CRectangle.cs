using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CRectangle : CShape
    {
        private int m_Width;
        private int m_Height;

        override
        public void Draw(Graphics g, Pen p)
        {
            g.DrawRectangle(p, m_Coordinate.X, m_Coordinate.Y, this.m_Width, this.m_Height);
        }

        override
        public void Save(XmlNode root)
        {
            XmlDocument doc = root.OwnerDocument;
            XmlElement shapeNode = doc.CreateElement("Rectangle");
            shapeNode.SetAttribute("X", ULCoordinate().X.ToString());
            shapeNode.SetAttribute("Y", ULCoordinate().Y.ToString());
            shapeNode.SetAttribute("Width", Width().ToString());
            shapeNode.SetAttribute("Height", Height().ToString());

            root.AppendChild(shapeNode);
        }

        override
        public bool Load(XmlNode root)
        {
            this.m_Coordinate.X = int.Parse(root.Attributes["X"].Value);
            this.m_Coordinate.Y = int.Parse(root.Attributes["Y"].Value);
            this.m_Width = int.Parse(root.Attributes["Width"].Value);
            this.m_Height = int.Parse(root.Attributes["Height"].Value);
            return true;
        }

        override
        public void CreateFromPoints(CCoordinate point1, CCoordinate point2)
        {
            this.m_Coordinate = new CCoordinate();

            if (point1.X < point2.X && point1.Y > point2.Y)
            {
                this.m_Coordinate.X = point1.X;
                this.m_Coordinate.Y = point2.Y;
            }
            else if (point2.X < point1.X && point1.Y > point2.Y)
            {
                this.m_Coordinate = point2;
            }
            else if (point2.X < point1.X && point1.Y < point2.Y)
            {
                this.m_Coordinate.X = point2.X;
                this.m_Coordinate.Y = point1.Y;
            }
            else
            {
                this.m_Coordinate = point1;
            }
            this.m_Width = Math.Abs(point2.X - point1.X);
            this.m_Height = Math.Abs(point2.Y - point1.Y);
        }

        public CRectangle(CCoordinate corner, int width, int height)
        {
            this.m_Coordinate = corner;
            this.m_Width = width;
            this.m_Height = height;
        }

        public CRectangle()
        {

        }


        public CCoordinate ULCoordinate()
        {
            return this.m_Coordinate;
        }

        public int Width()
        {
            return this.m_Width;
        }

        public int Height()
        {
            return this.m_Height;
        }
    }
}
