using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenederer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenederer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
