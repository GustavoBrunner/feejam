using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject Floor1, Floor2, Floor3;

    public void GoToFirstFloor()
    {
        Floor3.SetActive(false);
        Floor1.SetActive(true);
    }
    public void GoToSecondFloor()
    {
        Floor1.SetActive(false);
        Floor2.SetActive(true);
    }
    public void GoToThirdFloor()
    {
        Floor2.SetActive(false);
        Floor3.SetActive(true);
    }
}
