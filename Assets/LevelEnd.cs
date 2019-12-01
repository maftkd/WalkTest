using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    private MenuHelper _endMenu;
    private bool _levelOver;
    // Start is called before the first frame update
    void Start()
    {
        _endMenu = GameObject.Find("EndMenu").GetComponent<MenuHelper>() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!_levelOver)
        {
            _endMenu.ActivateMenu(true);
            _levelOver = true;
        }
    }
}
