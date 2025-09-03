using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int MouseLeftButton = 0;
    
    public Vector3 MousePosition => Input.mousePosition;
    public bool IsMouseLeftButtonDown => Input.GetMouseButton(MouseLeftButton);
    public bool IsSpaceKeyDown => Input.GetKeyDown(KeyCode.Space);
    public bool IsReloadKeyPressed => Input.GetKeyDown(KeyCode.R);
    public bool IsSpawnKeyPressed => Input.GetKeyDown(KeyCode.S);
}
