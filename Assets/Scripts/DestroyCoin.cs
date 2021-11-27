using UnityEngine;
using System.Collections;

public class DestroyCoin : MonoBehaviour {

	// Destrói a moeda 3 segundos após ela ter sido gerada.
	void Start () {
        Destroy(gameObject, 3);
    }
}
