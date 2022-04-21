using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float daysPassedForOrbit;
    float degreesPerDay;

    // Start is called before the first frame update
    void Start()
    {
        degreesPerDay = 360f / daysPassedForOrbit;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localRotation.y >= 360) { transform.Rotate(new Vector3(0, 0, 0), Space.Self); }
        transform.Rotate(new Vector3(0, degreesPerDay, 0), Space.Self);
    }
}
