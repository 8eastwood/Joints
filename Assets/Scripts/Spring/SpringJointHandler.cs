using UnityEngine;
using UnityEngine.SceneManagement;

public class SpringJointHandler : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Rigidbody _weight;

    private SpringJoint _springJoint;
    private float _initialSpring;
    private float _initialDamper;

    private void Awake()
    {
        _springJoint = _rigidbody.GetComponent<SpringJoint>();

        if (_springJoint == null)
        {
            Debug.LogError("No SpringJoint found on this GameObject");
        }
    }

    private void Update()
    {
        if (_inputReader.IsSpaceKeyDown)
        {
            DisableSpringJoint();
        }

        if (_inputReader.IsReloadKeyPressed)
        {
            ReloadTrebuchet();
        }
    }

    private void DisableSpringJoint()
    {
        if (_springJoint != null)
        {
            _springJoint.spring = 0f;
            _springJoint.damper = 0f;
            _weight.isKinematic = false;
        }
    }

    private void ReloadTrebuchet()
    {
        if (_springJoint == null) return;
        
        _springJoint.spring = 200f;
        _springJoint.damper = 20f;
    }
}