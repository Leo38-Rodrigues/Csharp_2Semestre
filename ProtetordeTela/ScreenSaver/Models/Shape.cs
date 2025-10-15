namespace Models.BaseShapes;
using System;
public class Shape
{

    //ATRIBUTOS
    public int X;
    public int Y;
    public int SpeedX;
    public int SpeedY;
    public int Width; // Largura
    public int Height; // Altura
    public Color ColorShape;
    private Random rand = new Random();

    //CONSTRUTOR
    public Shape(int x, int y, Color color, int width, int height)
    {
        X = x;
        Y = y;
        SpeedX = 2;
        SpeedY = 2;
        Width = width;
        Height = height;
        ColorShape = color;
    }

    //METODOS

    public void Move(int xlimit, int ylimit)
    {
        
        X += SpeedX;
       
        Y += SpeedY;
       
       if (X <= 0 || X >= xlimit - Width)
        {
            SpeedX = -SpeedX;
            // inverte direção
        }
        //Verifica limites verticais
        if (Y <= 0 || Y >= ylimit - Height)
        {
            SpeedY = -SpeedY; // inverte direção
        }

    }

    //TO STRING
    public override string ToString()
    {
        return $"X: {X}, \nY: {Y}, \nColorShape: {ColorShape}";
    }



}