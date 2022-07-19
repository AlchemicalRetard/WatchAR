using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color[] color; // variable color to store array of colors
    public Renderer[] ren;//A renderer is what makes an object appear on the screen. Here Iam using this as a watch have multiple material on it, so everything is included in this array.
   
    public void Red()
    {
        for(int i = 0; i < ren.Length; i++)
        {
            ren[i].material.color = color[0];
        }
    }
    public void Black()
    {
        for (int i = 0; i < ren.Length; i++)
        {
            ren[i].material.color = color[1];
        }
    }
    public void Blue()
    {
        for (int i = 0; i < ren.Length; i++)
        {
            ren[i].material.color = color[2];
        }
    }
    public void Green()
    {
        for (int i = 0; i < ren.Length; i++)
        {
            ren[i].material.color = color[3];
        }
    }







}
