using R3;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Camera))]
public class PlayerCamera : MonoBehaviour
{
    public Camera Camera => _camera ??= Camera.main;
    private Camera _camera;

    private InputAction _press;
    private InputAction _point;
    private CompositeDisposable _disposables = new();

    private bool isDrag;
    private Vector2 _startPressPoint;
    private Vector2 PointToWorld => Camera.ScreenToWorldPoint(_point.ReadValue<Vector2>());


    public void SetInput(InputAction press, InputAction point)
    {
        _press = press;
        _point = point;
        Observable.FromEvent<InputAction.CallbackContext>(
            h => _press.started += h,
            h => press.started -= h).Subscribe(OnPressStarted).AddTo(_disposables);

        Observable.FromEvent<InputAction.CallbackContext>(
            h => _press.canceled += h,
            h => press.canceled -= h).Subscribe(OnPressCanceled).AddTo(_disposables);
    }

    private void Update()
    {
        if (isDrag)
        {
            OnDrag();
        }
    }
    private void OnPressStarted(InputAction.CallbackContext context)
    {
        _startPressPoint = PointToWorld;
        isDrag = true;
    }
    private void OnPressCanceled(InputAction.CallbackContext context)
    {
        isDrag = false;
    }
    private void OnDrag()
    {
        Move(_startPressPoint - PointToWorld);
    }
    private void ResetInput()
    {
        if (!_disposables.IsDisposed)
        {
            _disposables.Dispose();
        }
    }
    private void Move(Vector2 input)
    {
        transform.position += new Vector3(input.x, input.y, 0);
    }

    private void OnDisable()
    {
        ResetInput();
    }
}


