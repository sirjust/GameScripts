﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float scroll_Speed = 0.3f;
    private readonly string main_Texture = "_MainTex";

    private MeshRenderer mesh_Renderer;

    // Start is called before the first frame update
    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(main_Texture);
        offset.y += Time.deltaTime * scroll_Speed;
        
        mesh_Renderer.sharedMaterial.SetTextureOffset(main_Texture, offset);
    }
}
