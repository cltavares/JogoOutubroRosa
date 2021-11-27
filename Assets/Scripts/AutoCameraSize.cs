using UnityEngine;
using System.Collections;

public class AutoCameraSize : MonoBehaviour {

    [SerializeField]
    private Camera thisCamera;

	void Start () {

        if (thisCamera.orthographic)
        {
            thisCamera.orthographicSize = 9.6f * Screen.height / Screen.width;
        }
	}

}
