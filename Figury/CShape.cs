using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace Figury
{
    abstract class CShape
    {
        protected CCoordinate m_Coordinate { get; set; }

        public CShape()
        {

        }

        public virtual void Draw(Graphics g, Pen p)
        {

        }

        public virtual void Save(XmlNode root)
        {

        }

        public virtual bool Load(XmlNode root)
        {
            return true;
        }

        public virtual void CreateFromPoints(CCoordinate point1, CCoordinate point2)
        {

        }
    }
}
