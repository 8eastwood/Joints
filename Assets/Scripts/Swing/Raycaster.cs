using UnityEngine;

public class Raycaster : MonoBehaviour
{
    private float _maxDistance = 1000f;
    
    public bool TryHitSwing(Vector3 screenPosition, Camera camera, LayerMask mask )
    {
        Ray ray = camera.ScreenPointToRay(screenPosition);

        if (Physics.Raycast(ray, _maxDistance, mask))
        {
            return true;
        }

        return false;
    }
}
