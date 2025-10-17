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
    public Color ColorShape { get; protected set; }
    protected Random Rand = new Random();


    //CONSTRUTOR
    public Shape(int screenWidth, int screenHeight, int size) //QUADRADO E CIRCULO - LADOS IGUAIS
    {
        
        SpeedX = Rand.Next(1, 10);
        SpeedY = Rand.Next(1, 10);
        Width = size;
        Height = size;
        X = Rand.Next(0, screenWidth-Width);
        Y = Rand.Next(0, screenHeight-Height);
        ColorShape = ColorGenerate();
    }

    public Shape(int screenWidth, int screenHeight) // ELLIPSE E RETANGULO - LADOS DIFERENTES
    {
        
        do
        {
            SpeedX = Rand.Next(-10, 10);
        } while (SpeedX == 0);
        do
        {
            SpeedY = Rand.Next(-10, 10);
        } while (SpeedY == 0);
        Width = Rand.Next(50, 250); // Largura
        do
        {
             Height = Rand.Next(50, 250);// Altura
        }while (Height == Width);
        X = Rand.Next(0, screenWidth-Width);
        Y = Rand.Next(0, screenHeight-Height);
        ColorShape = ColorGenerate();
    }

    //METODOS

    public void Move(int xlimit, int ylimit)
    {
        
        X += SpeedX;
        Y += SpeedY;

        if (X <= 0 || X >= xlimit - Width)
        {
            SpeedX = -SpeedX;
            ColorShape = ColorGenerate();
            // inverte direção
        }
        //Verifica limites verticais
        if (Y <= 0 || Y >= ylimit - Height)
        {
            SpeedY = -SpeedY; // inverte direção
            ColorShape = ColorGenerate();
        }
    }
    
   private Color ColorGenerate()
    {
        int red = Rand.Next(0, 255);   // .next define que o numero aleatorio sera inteiro
        int green = Rand.Next(0, 255);
        int blue = Rand.Next(0, 255);

        return Color.FromArgb(red, green, blue);
    }

    //TO STRING
    public override string ToString()
    {
        return $"X: {X}, \nY: {Y}, \nColorShape: {ColorShape}";
    }
}