using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicLook : MonoBehaviour
{
    public float _sensitivity;
    public bool _cursorLocked;
    private MenuHelper _escapeMenu;
    // Start is called before the first frame update
    void Start()
    {
        LockCursor();
        _escapeMenu = GameObject.Find("EscapeMenu").GetComponent<MenuHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Cursor.visible)
        {
            float xSlide = Input.GetAxis("Mouse X");
            float ySlide = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up, xSlide * _sensitivity);
            if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.Escape))
            {
                _escapeMenu.ActivateMenu(true);
            }
        }
        else
        {
        }
    }

    public void OnSensitivitySliderChange(Slider s)
    {
        _sensitivity = s.value;
    }

    public static void FreeCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public static void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
