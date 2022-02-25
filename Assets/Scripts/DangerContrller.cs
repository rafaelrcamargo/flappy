using UnityEngine;

public class DangerContrller : MonoBehaviour
{
    public Rigidbody rb;
    public Camera cam;

    public Material dangerMat;
    public Material transMat;

    public GameObject topIndicator;
    public GameObject bottomIndicator;

    void Start()
    {
        topIndicator.GetComponent<MeshRenderer>().material = transMat;
        bottomIndicator.GetComponent<MeshRenderer>().material = transMat;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(rb.position);

        float dangerX = (float)viewPos.x;
        float dangerY = (float)viewPos.y;

        if (viewPos.y < 0.2)
        {
            bottomIndicator.GetComponent<MeshRenderer>().material = dangerMat;
        }
        else
        {
            bottomIndicator.GetComponent<MeshRenderer>().material = transMat;
        }

        if (viewPos.y > 0.8)
        {
            topIndicator.GetComponent<MeshRenderer>().material = dangerMat;
        }
        else
        {
            topIndicator.GetComponent<MeshRenderer>().material = transMat;
        }
    }
}
