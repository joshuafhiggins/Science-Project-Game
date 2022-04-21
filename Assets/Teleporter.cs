using UnityEngine;
using TMPro;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public TMP_Dropdown dropdown;

    public void Teleport()
    {
        string name = "Sun";
        if(dropdown.value == 0)
        {
            name = "Sun";
        }
        if (dropdown.value == 1)
        {
            name = "Mercury";
        }
        if (dropdown.value == 2)
        {
            name = "Venus";
        }
        if (dropdown.value == 3)
        {
            name = "Earth";
        }
        if (dropdown.value == 4)
        {
            name = "Mars";
        }
        if (dropdown.value == 5)
        {
            name = "Jupiter";
        }
        if (dropdown.value == 6)
        {
            name = "Saturn";
        }
        if (dropdown.value == 7)
        {
            name = "Uranus";
        }
        if (dropdown.value == 8)
        {
            name = "Neptune";
        }
        player.transform.position = GameObject.Find(name).transform.position;
    }
}
