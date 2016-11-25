using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CCircle : CShape
    {
        protected float m_Radius;

        override
        public void Draw(Graphics g, Pen p)
        {
            g.DrawEllipse(p, this.m_Coordinate.X - this.m_Radius, this.m_Coordinate.Y - this.m_Radius, 2 * this.m_Radius, 2 * this.m_Radius);
        }

        override
        public void Save(XmlNode root)
        {
            XmlDocument doc = root.OwnerDocument;
            XmlElement shapeNode = doc.CreateElement("Circle");
            shapeNode.SetAttribute("CenterX", Center().X.ToString());
            shapeNode.SetAttribute("CenterY", Center().Y.ToString());
            shapeNode.SetAttribute("Radius", Radius().ToString());

            root.AppendChild(shapeNode);
        }

        override
        public bool Load(XmlNode root)
        {
            this.m_Coordinate.X = int.Parse(root.Attributes["CenterX"].Value);
            this.m_Coordinate.Y = int.Parse(root.Attributes["CenterY"].Value);
            this.m_Radius = float.Parse(root.Attributes["Radius"].Value);
            return true;
        }

        override
        public void CreateFromPoints(CCoordinate point1, CCoordinate point2)
        {
            this.m_Coordinate = point1;
            this.m_Radius = (float)Math.Sqrt(Math.Pow(point1.Y - point2.Y, 2) + Math.Pow(point2.X - point1.X, 2));
        }

        public CCircle(CCoordinate center, int radius)
        {
            this.m_Coordinate = center;
            this.m_Radius = radius;
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
