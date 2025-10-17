using System.Security.Cryptography.X509Certificates;
namespace Models.BaseShapes;

public class MySquare : Shape
{
    //ATRIBUTOS


    //CONSTRUTOR
    public MySquare(int screenWidth, int screenHeight, int size) : base(screenWidth, screenHeight, size)
    {
    }
    public MySquare(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {
        Width = Height;
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