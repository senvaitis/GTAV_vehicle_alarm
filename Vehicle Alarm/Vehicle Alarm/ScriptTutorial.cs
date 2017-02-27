using GTA;
using System;
using System.Windows.Forms;

public class ScriptTutorial : Script
{
    public ScriptTutorial()
    {
        Tick += OnTick;
        KeyDown += OnKeyDown;
        KeyUp += OnKeyUp;

        Interval = 10; // ms
    }

    void OnTick(object sender, EventArgs e)
    {

    }

    void OnKeyDown(object sender, KeyEventArgs e)
    {

    }
    void OnKeyUp(object sender, KeyEventArgs e)
    {

    }
}
