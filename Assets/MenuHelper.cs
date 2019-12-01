using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHelper : MonoBehaviour
{
    protected CanvasGroup _cg;
    public float _fadeRate = 2f;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        _cg = transform.GetComponent<CanvasGroup>();
    }

    public void ActivateMenu(bool active)
    {
        _cg.interactable = active;
        _cg.blocksRaycasts = active;
        StopAllCoroutines(); //not the best practice but it is entirely possible this will get entirely reworked
        if (active)
            StartCoroutine(FadeAlpha(1));
        else
            StartCoroutine(FadeAlpha(0));

        if (!active)
            BasicLook.LockCursor();
        else
            BasicLook.FreeCursor();
    }

    protected IEnumerator FadeAlpha(float alphaTarget)
    {
        if (alphaTarget == 1)
        {
            while (_cg.alpha < alphaTarget)
            {
                _cg.alpha += Time.deltaTime * _fadeRate;
                yield return null;
            }
        }
        else if(alphaTarget == 0)
        {
            while(_cg.alpha > alphaTarget)
            {
                _cg.alpha -= Time.deltaTime * _fadeRate;
                yield return null;
            }
        }
        else
        {
            Debug.LogError("FadeAlphaRoutine does not support non 0/1 alpha values");
        }
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
