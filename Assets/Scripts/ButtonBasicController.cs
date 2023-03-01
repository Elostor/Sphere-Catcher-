using UnityEngine;
using UnityEngine.EventSystems;

// A basic button checker, using the unity event system, checking if a button is pressed or unpressed.
public class ButtonBasicController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    
    [HideInInspector]
    public bool _buttonDown = false;
    
    public void OnPointerUp (PointerEventData eventData)
    {
        _buttonDown = false;
    }
    public void OnPointerDown (PointerEventData eventData)
    {
        _buttonDown = true;
    }
}
