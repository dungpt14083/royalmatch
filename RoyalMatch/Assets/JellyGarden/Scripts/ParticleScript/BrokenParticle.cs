using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenParticle : MonoBehaviour
{
  [SerializeField] private SpriteRenderer _texture2D;

  [SerializeField] private Renderer _particleSystem;

  private void Awake()
  {
    _GetMaterial();
  }

  void _GetMaterial()
  {
    Material _material = new Material(_particleSystem.material);

    _material.SetTexture("_MainTex",_texture2D.sprite.texture);
    _particleSystem.material = _material;
    
  }
}
