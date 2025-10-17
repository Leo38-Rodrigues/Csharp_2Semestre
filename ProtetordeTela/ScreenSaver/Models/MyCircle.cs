using System.Security.Cryptography.X509Certificates;

namespace Models.BaseShapes;

public class MyCircle : Shape
{
    //ATRIBUTOS


    //CONSTRUTOR
    public MyCircle(int screenWidth, int screenHeight, int size) : base(screenWidth, screenHeight, size)
    {
    }
    public MyCircle(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {
        Width = Height;
    }
    
    //METODOS 
    public void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(ColorShape))
        {

            using var SolidBrush = new SolidBrush(ColorShape);
            g.FillEllipse(brush, X, Y, Width, Height);

        }
    }
   
}

