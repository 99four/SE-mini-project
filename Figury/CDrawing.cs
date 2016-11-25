using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    class CDrawing
    {
        protected List<CShape> m_Shapes = new List<CShape>();

        public CDrawing()
        {
        }

        public void Draw(Graphics g, Pen p)
        {
            foreach(CShape shape in m_Shapes)
            {
                shape.Draw(g, p);
            }
        }

        public void AddShape(CShape shape)
        {
            m_Shapes.Add(shape);
        }

        public void Save(string filename)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "", "yes");
            doc.PrependChild(dec);
            XmlElement rootNode = doc.CreateElement("Drawing");
            doc.AppendChild(rootNode);

            foreach(CShape shape in m_Shapes)
            {
                shape.Save(rootNode);
            }

            doc.Save(filename);
        }

        public bool Load(string filename)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode rootNode;
            doc.Load(filename);
            rootNode = doc.ChildNodes[1];

            if (rootNode.Name != "Drawing")
                return false;

            foreach (XmlNode shape in rootNode.ChildNodes)
            {
                if (shape.Name == "Line")
                {
                    CLine linia = new CLine();
                    linia.CreateFromPoints(new CCoordinate(), new CCoordinate());
                    linia.Load(shape);
                    this.m_Shapes.Add(linia);
                }
            }

            return true;
        }

    }
}
