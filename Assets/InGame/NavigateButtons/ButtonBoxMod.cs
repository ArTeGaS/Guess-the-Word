using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBoxMod : MonoBehaviour
{
    public float alphaThreshold = 0.1f;
    void Awake()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
    }
}
