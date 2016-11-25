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
            XmlDocument doc = root.OwnerDocument;
            XmlElement shapeNode = doc.CreateElement("Line");
            shapeNode.SetAttribute("StartX", Start().X.ToString());
            shapeNode.SetAttribute("StartY", Start().Y.ToString());
            shapeNode.SetAttribute("EndX", End().X.ToString());
            shapeNode.SetAttribute("EndY", End().Y.ToString());

            root.AppendChild(shapeNode);
        }

        override
        public bool Load(XmlNode root)
        {
            this.m_Coordinate.X = int.Parse(root.Attributes["StartX"].Value);
            this.m_Coordinate.Y = int.Parse(root.Attributes["StartY"].Value);
            this.m_End.X = int.Parse(root.Attributes["EndX"].Value);
            this.m_End.Y = int.Parse(root.Attributes["EndY"].Value);
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
