using UnityEngine;

public class Nonagon : IShape
{
    private float sideLength;

    public Nonagon(float side)
    {
        sideLength = side;
    }

    public float CalculateArea()
    {
        return (9f / 4f) * sideLength * sideLength * (1 / Mathf.Tan(Mathf.PI / 9f));
    }

    public float CalculatePerimeter()
    {
        return 9 * sideLength;
    }
}