using System;

public class Bulb
{
    private int number;
    private bool isOn;

    public Bulb(int number)
    {
        this.number = number;
        this.isOn = false;
    }

    public int Number
    {
        get { return number; }
    }

    public bool IsOn
    {
        get { return isOn; }
        set { isOn = value; }
    }


    /// <summary>
    /// Switches the bulb between on and off
    /// </summary>
    public void Switch()
    {
        isOn = !isOn;
    }

    /// <summary>
    /// Shows the state of the bulb when it's on and when it's off with unicode
    /// </summary>
    /// <returns>if true \U0001F315 if false \u25EF </returns>
    public override string ToString()
    {
        return $"Bulb {number}: {(isOn ? "\U0001F315" : "\u25EF")}";
    }
}