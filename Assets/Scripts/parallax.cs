using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public float ScrollSpeed;
    private float Offset;
    private Material _material;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Offset += Time.deltaTime * ScrollSpeed;
        _material.mainTextureOffset = new Vector2(Offset, 0.01f);
    }
}
