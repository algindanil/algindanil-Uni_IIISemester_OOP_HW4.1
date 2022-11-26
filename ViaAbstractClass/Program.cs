using System.Xml.Linq;

abstract class GeographicalObject
{
    protected int x { get; set; }

    protected int y { get; set; }

    protected string name = "";
    public string Name { get { return name; } set { name = value; } }

    protected string description = "";
    public string Description { get { return description; } set { description = value; } }
    virtual public string GetInfo()
    {
        string output = String.Format("X: {0}, Y: {1}. Name: {2}, description: {3}", x, y, name, description);
        return output;
    }

}

class River : GeographicalObject
{
    private int speedInMPS { get; set; }
    private int len { get; set; }
    public override string GetInfo()
    {
        string output = String.Format("X: {0}, Y: {1}. Name: {2}, description: {3}. Speed in mps: {4}, length: {5}", x, y, name, description,
            speedInMPS, len);
        return output;
    }
}

class Mountain : GeographicalObject
{
    private int[] highestPoint = { 0, 0 };
    public int[] HighestPoint { get { return highestPoint; } set { highestPoint = value; } }
    public override string GetInfo()
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