﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFader : MenuHelper
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        StartCoroutine(FadeAlpha(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
