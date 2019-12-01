using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{

    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = transform.GetComponent<Text>();
        StartCoroutine(UpdateFrameRate());
    }

    private IEnumerator UpdateFrameRate()
    {
        while (true)
        {
            _text.text = "FPS: " + Mathf.RoundToInt(1f / Time.deltaTime);
            yield return new WaitForSeconds(1f);
        }
    }
}
