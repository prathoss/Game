using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityStandardAssets.Characters.ThirdPerson;

namespace Assets.Scripts
{
    class ClickMovement : MonoBehaviour
    {
        [SerializeField] float _stopRadius = 0.2f;
        CameraRaycaster _cameraRaycaster;
        ThirdPersonCharacter _player;
        Vector3 _currentClickTargert;

        void Start()
        {
            _cameraRaycaster = Camera.main.GetComponent(typeof(CameraRaycaster)) as CameraRaycaster;
            _player = GetComponent(typeof(ThirdPersonCharacter)) as ThirdPersonCharacter;
            _currentClickTargert = transform.position;
        }

        void Update()
        {
            if (Input.GetMouseButton((int)MouseButton.LeftMouse))
            {
                if(_cameraRaycaster.layerHit == Layers.Walkable) _currentClickTargert = _cameraRaycaster.hit.point;
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
}
