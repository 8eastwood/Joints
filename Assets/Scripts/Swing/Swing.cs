using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [Header("Ссылки")] 
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Raycaster _raycaster;
    [SerializeField] private Camera _mainCamera;

    [Header("Настройки")] 
    [SerializeField] private LayerMask _swingLayer;
    [SerializeField] private float _forceMultiplier = 10f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        if (_rigidbody == null)
        {
            Debug.LogError("Rigidbody не найден на объекте");
        }
    }

    private void Update()
    {
        if (_inputReader.IsMouseLeftButtonDown)
        {
            if (_raycaster.TryHitSwing(_inputReader.MousePosition, _mainCamera, _swingLayer))
            {
                ApplySwingForce();
            }
        }
    }

    private void ApplySwingForce()
    {
        if (_rigidbody == null) return;

        Vector3 direction;

        Vector3 normalizeDirection = Vector3.forward.normalized;
        direction = transform.TransformDirection(normalizeDirection);

        _rigidbody.AddForce(direction * _forceMultiplier, ForceMode.Impulse);
    }
}