using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject _player;

	// Use this for initialization
	void Start () {
        _player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = _player.transform.position;
	}
}
