using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise7 : MonoBehaviour
{
    public Slider Alphaslider;
    public Material sphereMat;

    private void Start()
    {
        // The cylinder absorbs the indicated material
        sphereMat = GetComponent<Renderer>().material;
    }

    //Transparency varies according to the slider
    public void ChangeSphereAlpha()
    {
        sphereMat.color = new Vector4 (0,0,0, Alphaslider.value);
    }
}