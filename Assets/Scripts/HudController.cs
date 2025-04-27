using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HudController : MonoBehaviour
{
    public UnityEvent StartEvent;

    private bool rulesOpened;
    private bool taskUiOpen;

    [SerializeField]
    private GameObject rulesGo;
    [SerializeField]
    private GameObject taskGo;
    public void ShowRules()
    {
        rulesGo.SetActive(true);
        rulesOpened = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        taskGo.SetActive(false);
        rulesOpened = true;
        rulesGo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (rulesOpened)
            {
                CloseUi();
                
                return;
            }
            if (taskUiOpen)
                CloseUi();
            else
                OpenUi();
        }
    }

    private void OpenUi()
    {
        taskGo.SetActive(true);
    }

    private void CloseUi()
    {
        if (taskUiOpen)
        {
            taskGo.SetActive(false);
            taskUiOpen = false;
        }
        if (rulesOpened)
        {
            rulesGo.SetActive(false);
            rulesOpened = false;
            StartEvent?.Invoke();
        }
    }
}
