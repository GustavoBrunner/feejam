using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _instance;

    public static GameController Instance { get => _instance; }

    public EventsController Events { get; private set; }
    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            DestroyImmediate(this.gameObject);

        Events = GetComponent<EventsController>();
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Events.StartFloor();
        }
    }
    public void TestEvent()
    {
        Debug.Log("Jogo iniciado");
    }
}
