using Assets.Scripts;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityStandardAssets.Characters.ThirdPerson;

public class ClickMovement : MonoBehaviour {

    [SerializeField] float _stopRadius = 0.2f;
    CameraRaycaster _cameraRaycaster;
    ThirdPersonCharacter _player;
    Vector3 _currentClickTargert;

    // Use this for initialization
    void Start () {
        _cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        _player = GetComponent<ThirdPersonCharacter>();
        _currentClickTargert = transform.position;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButton((int)MouseButton.RightMouse))
        {
            if (_cameraRaycaster.layerHit == Layers.Walkable) _currentClickTargert = _cameraRaycaster.hit.point;
        }
        var pathToGo = _currentClickTargert - transform.position;
        if (pathToGo.magnitude > _stopRadius)
        {
            _player.Move(pathToGo, false, false);
        }
        else
        {
            _player.Move(Vector3.zero, false, false);
        }
    }
}
