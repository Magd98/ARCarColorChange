using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorChange : MonoBehaviour
{
    public Color[] colors;
    public Material[] Materials;
    
    
   
     void Start()

    {
        for (int x = 0; x < Materials.Length; x++)
        {
            Materials[x] = Resources.Load($"Materials/Ford Mustang GT/Ford Mustang GT{x}") as Material;
        }


    }



    public void Red()
    {

       for (int i = 0; i < Materials.Length; i++)
        { 
    
            Materials[i].SetColor("_Color",colors[0]);
       
        }
        
    }
    public void Black()

   {
        
         for (int i = 0; i < Materials.Length; i++)
            Materials[i].SetColor("_Color", colors[1]);
    }

    public void Blue()
    {
        for (int i = 0; i < Materials.Length; i++)
            Materials[i].SetColor("_Color", colors[2]);
    }

    public void Yellow()
   {

        for (int i = 0; i < Materials.Length; i++)
            Materials[i].SetColor("_Color", colors[3]);
    }
}
