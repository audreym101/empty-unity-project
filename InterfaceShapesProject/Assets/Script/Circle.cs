using UnityEngine;

public class Circle : IShape
{
    private float radius;

    public Circle(float r)
    {
        radius = r;
    }

    public float CalculateArea()
    {
        return Mathf.PI * radius * radius;
    }

    public float CalculatePerimeter()
    {
        return 2 * Mathf.PI * radius;
    }
}