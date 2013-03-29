using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject terrain =  GameObject.Find("Terrain");
		TerrainToolkit script;
		float x = 0.5f;
		TerrainToolkit toolkit = terrain.GetComponent<TerrainToolkit>();
		toolkit.VoronoiGenerator(TerrainToolkit.FeatureType.Hills, 32, 0.9f, .5f, .5f);
		toolkit.SmoothTerrain(5, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
