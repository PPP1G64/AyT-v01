using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public float velocidad = 2;
	public GameObject col;
	public Renderer fondo;
	public List<GameObject> cols;
    // Start is called before the first frame update
    void Start()
    {
    	//crear mapa
        for(int i=0; i<21; i++)
        {
        	cols.Add(Instantiate(col, new Vector2(-10 + i, -3), Quaternion.identity));
        	
        }
    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.015f, 0) * Time.deltaTime;

        //mover mapa
         for(int i=0; i<cols.Count; i++)
        {
      		cols[i].transform.position = cols[i].transform.position + new Vector3(-1,0,0) * Time.deltaTime * velocidad;
        	
        }

    }
}
