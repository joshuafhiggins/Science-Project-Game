using UnityEngine;

public class LineController : MonoBehaviour
{
    LineRenderer lr;

    void Start()
    {
        lr = gameObject.GetComponent<LineRenderer>();
    }

    public void UpdatePostition(int index, Vector3 position)
    {
        lr.SetPosition(index, position);
    }
}
