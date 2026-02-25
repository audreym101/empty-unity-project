using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        IShape trapezium = new Trapezium(5f, 7f, 4f, 3f, 3f);
        IShape circle = new Circle(5f);
        IShape nonagon = new Nonagon(6f);

        Debug.Log("Trapezium Area: " + trapezium.CalculateArea());
        Debug.Log("Trapezium Perimeter: " + trapezium.CalculatePerimeter());

        Debug.Log("Circle Area: " + circle.CalculateArea());
        Debug.Log("Circle Perimeter: " + circle.CalculatePerimeter());

        Debug.Log("Nonagon Area: " + nonagon.CalculateArea());
        Debug.Log("Nonagon Perimeter: " + nonagon.CalculatePerimeter());
    }
}