using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public CanvasGroup Logo;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void Show()
    {
        gameObject.SetActive(true);
        Logo.alpha = 1;
    }

    public void Hide() =>
        StartCoroutine(FadeIn());

    private IEnumerator FadeIn()
    {
        while (Logo.alpha > 0)
        {
            Logo.alpha -= 0.03f;
            yield return new WaitForSeconds(0.03f);
        }
        
        gameObject.SetActive(false);
    }
}
