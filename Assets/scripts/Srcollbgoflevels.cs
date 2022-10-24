using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Srcollbgoflevels : MonoBehaviour
{
    public float scrolling_background_speed = 0.2f;
    private MeshRenderer mesh_Renderer;
    private float y_scroll;
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
        y_scroll = Time.time * scrolling_background_speed;

        Vector2 offset = new Vector2(0f,y_scroll);
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

    }
}
