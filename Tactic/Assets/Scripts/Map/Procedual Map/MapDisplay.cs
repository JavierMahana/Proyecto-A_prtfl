﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapDisplay : MonoBehaviour {

    
    public Renderer textureRenderer;


    public void DrawNoiseMap(float[,]noiseMap)
    {
        int width = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        Texture2D mapTexture = new Texture2D(width, height);
        Color[] colorMap = new Color[width * height];

        for (int y = 0, i = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++ , i++)
            {
                colorMap[i] = Color.Lerp(Color.black, Color.white, noiseMap[x, y]);
            }
        }

        mapTexture.SetPixels(colorMap);
        mapTexture.Apply();

        textureRenderer.sharedMaterial.mainTexture = mapTexture;
        textureRenderer.transform.localScale = new Vector3(width, 1, height);
    }


}
