using UnityEngine;

namespace Assets.Scripts
{
    class CameraRaycaster : MonoBehaviour
    {
        Layers[] _layers =
        {
            Layers.Enemy,
            Layers.Walkable
        };

        public float DistanceToBackgroud = 100f;

        Camera viewCamera;

        RaycastHit m_hit;
        public RaycastHit hit
        {
            get { return m_hit; }
        }

        Layers m_layerHit;
        public Layers layerHit
        {
            get { return m_layerHit; }
        }

        void Start()
        {
            viewCamera = Camera.main;
        }

        void Update()
        {
            foreach (Layers layer in _layers)
            {
                var hit = RaycastForLayers(layer);
                if (hit.HasValue)
                {
                    m_hit = hit.Value;
                    m_layerHit = layer;
                    return;
                } 
            }
        }

        RaycastHit? RaycastForLayers(Layers layer)
        {
            int layerMask = 1 << (int)layer;
            Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool hasHit = Physics.Raycast(ray, out hit, DistanceToBackgroud, layerMask);
            if (hasHit) return hit;
            return null;
        }
    }
}
