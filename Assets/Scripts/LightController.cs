using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> lightsFirstFloor = new();
    private List<GameObject> lightsSecondFloor = new();
    private List<GameObject> lightsThirdFloor = new();


    public void TurnOffFirstFloorLights()
    {
        foreach(GameObject light in lightsFirstFloor)
        {
            light.SetActive(false);
        }
    }
    public void TurnOnFirstFloorLights()
    {
        foreach (GameObject light in lightsFirstFloor)
        {
            light.SetActive(true);
        }
    }
}
