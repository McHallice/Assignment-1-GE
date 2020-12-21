using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour {

	[SerializeField]
	NoiseMapGeneration noiseMapGeneration;

	[SerializeField]
	private MeshRenderer tileRenderer;

	[SerializeField]
	private MeshFilter meshFilter;

	[SerializeField]
	private MeshCollider meshCollider;

	[SerializeField]
	private float mapScale;

	void Start() {
		GenerateTile ();
	}

