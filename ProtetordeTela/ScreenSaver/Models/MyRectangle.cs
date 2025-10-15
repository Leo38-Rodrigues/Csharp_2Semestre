using System.Security.Cryptography.X509Certificates;

namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    //ATRIBUTOS
    

    //CONSTRUTOR
    public MyRectangle(int x, int y, Color color, int width, int height) : base(x, y,color, width, height)
    {
    }

    //METODOS 
    public void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(ColorShape))
        {

            using var SolidBrush = new SolidBrush(ColorShape);
            g.FillRectangle(brush, X, Y, Width, Height);

        }
    }
   
}

