using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

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

        }

        public bool Load(string filename)
        {
            return true;
        }

    }
}
