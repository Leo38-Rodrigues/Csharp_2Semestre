namespace Models.BaseShapes;
using System;
using System.Drawing;

public abstract class Shape
{

    //ATRIBUTOS
    protected int X;
    protected int Y;
    protected int SpeedX;
    protected int SpeedY;
    protected int Width; // Largura
    protected int Height; // Altura
    public Color ColorShape{get; protected set;}
   

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
    
    private int ColorGenerate()
    {
        int red
    }

    //TO STRING
    public override string ToString()
    {
        return $"X: {X}, \nY: {Y}, \nColorShape: {ColorShape}";
    }

    Color.FromArgb(red, green, blue);
   



}