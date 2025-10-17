namespace Models.Screens;

using Models.BaseShapes;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

public class ScreenSaver : Form
{
    // ******* Declare suas formas geométricas aqui (escopo global) *******

    MyRectangle r, r1;
    MyCircle c;
    MySquare s;


    // ********************************************************************
    private Timer ControlTimer;

    public ScreenSaver()
    {
        this.DoubleBuffered = true;                     // evita flickering
        this.WindowState = FormWindowState.Maximized;   // Maximiza a janela
        // Define a cor de background
        this.BackColor = Color.Black;                   
        // Inicializa o temporizador de controle
        ControlTimer = new Timer();
        ControlTimer.Interval = 16;                     // 16 ms = ~60 fps
        // Controle da animação
        ControlTimer.Tick += (s, e) =>
        {
            // ****** Mova suas formas geométricas aqui ******
            r.Move(ClientSize.Width, ClientSize.Height);
            r1.Move(ClientSize.Width, ClientSize.Height);
            c.Move(ClientSize.Width, ClientSize.Height);
            s.Move(ClientSize.Width, ClientSize.Height);
            // ***********************************************
            Invalidate(); // Foça a tela a ser redesenhada.
        }; // Função anônima disparada pelo ControlTimer a cada Interval (ms)
        ControlTimer.Start();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        r = new MyRectangle(ClientSize.Width, ClientSize.Height);
        r1 = new MyRectangle(ClientSize.Width, ClientSize.Height);
        c = new MyCircle(ClientSize.Width, ClientSize.Height);
        s = new MySquare(ClientSize.Width, ClientSize.Height);

        // ****************************************************
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        r.Draw(e.Graphics);
        r1.Draw(e.Graphics);
        c.Draw(e.Graphics);
        s.Draw(e.Graphics);
        // ***************************************************

    }
}