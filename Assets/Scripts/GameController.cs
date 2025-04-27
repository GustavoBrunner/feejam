using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _instance;

    public static GameController Instance { get => _instance; }

    private MovementController _movementController;

    public HudController HudControl { get; private set; }

    public EventsController Events { get; private set; }

    public GamePhase GamePhase { get; set; } = GamePhase.first;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            DestroyImmediate(this.gameObject);

        Events = GetComponent<EventsController>();
        _movementController = FindObjectOfType<MovementController>();
        HudControl = FindObjectOfType<HudController>();

        HudControl.ShowRules();
    }
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Events.StartFloor();
        }
    }
    public void ChangePlayerWalkStatus(bool status = false)
    {
        _movementController.SetCanRun(status);
    }



}

public enum GamePhase
{
    first,
    second,
    third
}
