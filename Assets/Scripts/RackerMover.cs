using UnityEngine;

public class RackerMover : MonoBehaviour
{
    [SerializeField] private float _xMin, _xMax;
    private Vector3 _offcet;
    private const float _cameraDistance = 32f;
    private Camera _camera;
    
    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            CalculateOffcet();

        if (Input.GetMouseButton(0))
            Move();
    }

    private void CalculateOffcet()
    {
        var pos = transform.position;
        _offcet = pos - GetMouseWorldPosition();
    }
    
    private void Move()
    {
        var tmpPos = transform.position;
        tmpPos.x = GetMouseWorldPosition().x + _offcet.x;
        tmpPos.x = Mathf.Clamp(tmpPos.x, _xMin, _xMax);
        transform.position = tmpPos;
    }

    private Vector3 GetMouseWorldPosition()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = _cameraDistance;
        return _camera.ScreenToWorldPoint(mousePos);
    }
}
