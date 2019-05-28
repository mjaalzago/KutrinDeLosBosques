using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoDeDialogoDeLaEspada : MonoBehaviour {

    [SerializeField] float distancia = 2;
    [SerializeField] CharacterController prota;
    //cartel
	
	void Update () {
	   if (Vector3.Distance(prota.transform.position, this.transform.position) < distancia)
        {
            Debug.Log("cerca");
        }
	}
}
