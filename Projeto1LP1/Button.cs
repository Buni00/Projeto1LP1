using System;
using System.Collections.Generic;
public class Button
{
    private List<Bulb> bulbs;

    /// <summary>
    /// Creates a new Button  associated with specified bulbs
    /// </summary>
    /// <param name="bulbs">The bulbs associated with the button</param>
    public Button(List<Bulb> bulbs)
    {
        this.bulbs = bulbs;
    }

    /// <summary>
    /// Triggers the Switch method for all associated bulbs
    /// </summary>
    public void Press()
    {
        foreach (Bulb bulb in bulbs)
        {
            bulb.Switch();
        }
    }
}