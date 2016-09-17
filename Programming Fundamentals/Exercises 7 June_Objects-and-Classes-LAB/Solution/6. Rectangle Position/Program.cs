using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle
{
    public int Left { get; set; }

    public int Top { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public bool IsInside(Rectangle rect)
    {
        bool isInside =
            rect.Left <= this.Left && (this.Left + this.Width) <= (rect.Left + rect.Width) &&
            rect.Top <= this.Top && (this.Top + this.Height) <= (rect.Top + rect.Height);

        return isInside;
    }
}

/*
 * Write program to read two rectangles {left, top, width, height} and 
 * print whether the first is inside the second
 */
public class RectanglePosition
{
    private static void Main()
    {
        Rectangle firstRect = ReadRectangle();
        Rectangle secondRect = ReadRectangle();

        Console.WriteLine(firstRect.IsInside(secondRect) ? "Inside" : "Not inside");
    }

    private static Rectangle ReadRectangle()
    {
        int[] rectData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Rectangle rect = new Rectangle() { Left = rectData[0], Top = rectData[1], Width = rectData[2], Height = rectData[3] };

        return rect;
    }
}