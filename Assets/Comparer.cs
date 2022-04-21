using UnityEngine;
using TMPro;

public class Comparer : MonoBehaviour
{
    public TMP_Text textDistance;
    public TMP_Dropdown selection1;
    public TMP_Dropdown selection2;

    public LineController lc;

    GameObject gc1;
    GameObject gc2;

    // Start is called before the first frame update
    void Start()
    {
        gc1 = GameObject.Find("Sun");
        gc2 = GameObject.Find("Sun");
    }

    // Update is called once per frame
    void Update()
    {
        lc.UpdatePostition(0, gc1.transform.position);
        lc.UpdatePostition(1, gc2.transform.position);
    }

    public void Compare()
    {
        string selected1 = "Sun";
        if(selection1.value == 0)
        {
            selected1 = "Sun";
        }
        if (selection1.value == 1)
        {
            selected1 = "Mercury";
        }
        if (selection1.value == 2)
        {
            selected1 = "Venus";
        }
        if (selection1.value == 3)
        {
            selected1 = "Earth";
        }
        if (selection1.value == 4)
        {
            selected1 = "Mars";
        }
        if (selection1.value == 5)
        {
            selected1 = "Jupiter";
        }
        if (selection1.value == 6)
        {
            selected1 = "Saturn";
        }
        if (selection1.value == 7)
        {
            selected1 = "Uranus";
        }
        if (selection1.value == 8)
        {
            selected1 = "Neptune";
        }

        string selected2 = "Sun";
        if (selection2.value == 0)
        {
            selected2 = "Sun";
        }
        if (selection2.value == 1)
        {
            selected2 = "Mercury";
        }
        if (selection2.value == 2)
        {
            selected2 = "Venus";
        }
        if (selection2.value == 3)
        {
            selected2 = "Earth";
        }
        if (selection2.value == 4)
        {
            selected2 = "Mars";
        }
        if (selection2.value == 5)
        {
            selected2 = "Jupiter";
        }
        if (selection2.value == 6)
        {
            selected2 = "Saturn";
        }
        if (selection2.value == 7)
        {
            selected2 = "Uranus";
        }
        if (selection2.value == 8)
        {
            selected2 = "Neptune";
        }

        gc1 = GameObject.Find(selected1);
        gc2 = GameObject.Find(selected2);
        Vector3 pos1 = gc1.transform.position;
        Vector3 pos2 = gc2.transform.position;

        float distance = Vector3.Distance(pos1, pos2) * 20;
        distance = Mathf.Abs(distance);
        distance = distance * 2;

        textDistance.text = "Distance: " + distance.ToString() + " Billion Meters";
    }
}
