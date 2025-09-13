using R3;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;

public class VirtualJoystick : MonoBehaviour,IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private ReactiveProperty<Vector2> _value = new ReactiveProperty<Vector2>();
    public Observable<Vector2> OnValueChange => _value;
    public Vector2 Value => _value.Value;

    [SerializeField] private RectTransform joystickBackground; 
    [SerializeField] private RectTransform joystickHandle;


    [SerializeField] private Vector2 value;

    private float _halfWidth;
    private float _halfHeight;

    public void Awake()
    {

        OnValueChange.Subscribe(_ => Debug.Log($"Joystick Value Changed: {_}"));
    }
    public void Init()
    {
        _halfWidth = joystickBackground.rect.width / 2;
        _halfHeight = joystickBackground.rect.height / 2;
    }
    public void OnPointerDown(PointerEventData eventData) => OnDrag(eventData);

    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joystickBackground,
            eventData.position,
            eventData.pressEventCamera,
            out Vector2 localPoint
        );

        Vector2 clampedPosition = ClampToBackground(localPoint);

        if (joystickHandle.anchoredPosition != clampedPosition)
        {
            joystickHandle.anchoredPosition = clampedPosition;
        }

        _value.Value = new Vector2(
            clampedPosition.x / _halfWidth,
            clampedPosition.y / _halfHeight
        );
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        joystickHandle.anchoredPosition = Vector2.zero;
        _value.Value = Vector2.zero;
    }

    private Vector2 ClampToBackground(Vector2 position)
    {
        float clampedX = Mathf.Clamp(position.x, -_halfWidth, _halfWidth);
        float clampedY = Mathf.Clamp(position.y, -_halfHeight, _halfHeight);
        return new Vector2(clampedX, clampedY);
    }
}
