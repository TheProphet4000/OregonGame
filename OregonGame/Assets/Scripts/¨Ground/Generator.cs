﻿using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	
	#pragma warning disable 78 //fjerner adversels kode 78
	
	public GameObject Stone; 
	public GameObject Dirt;
	
	public int minX = -10;   //variable på længte og bredte
	public int maxX = 10;
	public int minY = -10;
	public int maxY = 10;
    public float BlockSpace;
	
	PerlinNoise noise;
	
	void Start () {
		noise = new PerlinNoise(Random.Range(1000000,10000000)); //vi bruger en random funktion der kaldes perlin noise
		Regenerate();
	}
	
	private void Regenerate(){ //laver terran
		
		float width = Dirt.transform.lossyScale.x;  //sætter to variabler up
		float height = Stone.transform.lossyScale.y;
		
		for (int i = minX; i < maxX; i++){//columns (x values)
			int columnHeight = 2 + noise.getNoise(i - minX, maxY - minY - 2);

			for(int j = minY; j < minY + columnHeight; j++){//rows (y values)

				GameObject block = (j == minY + columnHeight - 1)?Dirt:Stone; //fortæller hvilke block den skal spawne på hvilke lag
				Instantiate(block, new Vector2(i * width / BlockSpace, j * height / BlockSpace), Quaternion.identity); //spawner blocke
			}
		}
        
	}
}
