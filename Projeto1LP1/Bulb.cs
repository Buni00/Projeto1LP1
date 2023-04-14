using System;

public class Bulb
{
    private int number;
    private bool isOn;

    /// <summary>
    /// Creates a Bulb  with number and state
    /// </summary>
    /// <param name="number">Number of the bulb</param>
    public Bulb(int number)
    {
        this.number = number;
        this.isOn = false;
    }

    /// <summary>
    /// Gets the number of the bulb
    /// </summary>
    /// <value></value>
    public int Number
    {
        get { return number; }
    }

    /// <summary>
    /// Gets or sets the bulb to on or off
    /// </summary>
    /// <value></value>
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