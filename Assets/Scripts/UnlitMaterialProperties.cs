﻿using UnityEngine;


[RequireComponent(typeof(Renderer))]
public class UnlitMaterialProperties : MonoBehaviour {
	
	static int baseColorId = Shader.PropertyToID("_BaseColor");
	static MaterialPropertyBlock block;
	
	[SerializeField]
	Color baseColor = Color.white;

	void Awake () {
		OnValidate();
	}

	void OnValidate () {
		if (block == null) {
			block = new MaterialPropertyBlock();
		}
		block.SetColor(baseColorId, baseColor);
		GetComponent<Renderer>().SetPropertyBlock(block);
	}
}