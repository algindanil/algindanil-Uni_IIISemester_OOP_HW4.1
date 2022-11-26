using System;
using System.Reflection.Metadata.Ecma335;

interface IGeographicalObject
{
    string GetInfo();
}

class River : IGeographicalObject
{
    private int x;
    public int X { get { return x; } set { x = value; } }
    
    private int y;
    public int Y { get { return y; } set { y = value; } }
    
    private string name = "";
    public string Name { get { return name; } set { name = value; } }
   
    private string description = "";
    public string Description { get { return description; } set { description = value; } }

    private int speedInMPS;
    public int SpeedInMPS { get { return speedInMPS; } set {speedInMPS = value; } }
    
    private int len;
    public int Len { get { return len; } set { len = value; } }

    public string GetInfo()
    {
        string output = String.Format("X: {0}, Y: {1}. Name: {2}, description: {3}. Speed in mps: {4}, length: {5}", x, y, name, description,
            speedInMPS, len);
        return output;

    }
}

class Mountain : IGeographicalObject
{
    private int x;
    public int X { get { return x; } set { x = value; } }

    private int y;
    public int Y { get { return y; } set { y = value; } }

    private string name = "";
    public string Name { get { return name; } set { name = value; } }

    private string description = "";
    public string Description { get { return description; } set { description = value; } }

    private int[] highestPoint = { 0, 0 };
    public int[] HighestPoint { get { return highestPoint; } set { highestPoint = value;} }

    public string GetInfo()
    {
        string output = String.Format("X: {0}, Y: {1}. Name: {2}, description: {3}. Highest point: {4}", x, y, name, description,
            highestPoint.ToString());
        return output;

    }
}


class Program
{
    static void Main()
    {
        
    }
}