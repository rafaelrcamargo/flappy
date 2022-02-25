using UnityEngine;
using UnityEngine.UI;

public class Danger : MonoBehaviour
{
    public Rigidbody rb;
    public Camera cam;

    public Text dangerText;

    void Update()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(rb.position);

        float dangerX = (float)viewPos.x;
        float dangerY = (float)viewPos.y;

        if (viewPos.x < 0.2 || viewPos.x > 0.8)
        {
            dangerX = 1;
        }
        else
        {
            dangerX = 0;
        }

        if (viewPos.y < 0.2 || viewPos.y > 0.8)
        {
            dangerY = 1;
        }
        else
        {
            dangerY = 0;
        }

        if (dangerX + dangerY == 0)
        {
            dangerText.color = new Color(100, 100, 100, 0.6f);
            dangerText.text = "...";
        }
        if (dangerX + dangerY == 1)
        {
            dangerText.color = new Color(100, 80, 0, 0.8f);
            dangerText.text = "Cuidado!";
        }
        if (dangerX + dangerY == 2)
        {
            dangerText.color = new Color(100, 0, 0, 0.9f);
            dangerText.text = "MUITO CUIDADO!";
        }
    }
}
