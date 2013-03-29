using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject terrain =  GameObject.Find("Terrain");
		TerrainToolkit script;
		float x = 0.5f;
		TerrainToolkit toolkit = terrain.GetComponent<TerrainToolkit>();
		toolkit.VoronoiGenerator(TerrainToolkit.FeatureType.Mountains, 3, 0.9f, .1f, .5f);
		toolkit.SmoothTerrain(5, 1);
		toolkit.NormaliseTerrain(0f, 0.5f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
