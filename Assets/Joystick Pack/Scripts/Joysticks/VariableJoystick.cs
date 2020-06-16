using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VariableJoystick : Joystick
{

    float x = 0;
    bool ButtonJumpState=false;
    bool ButtonAttackState=false;
    public float MoveThreshold { get { return moveThreshold; } set { moveThreshold = Mathf.Abs(value); } }

    [SerializeField] private float moveThreshold = 1;
    [SerializeField] private JoystickType joystickType = JoystickType.Fixed;

    private Vector2 fixedPosition = Vector2.zero;

    public void SetMode(JoystickType joystickType)
    {
        this.joystickType = joystickType;
        if(joystickType == JoystickType.Fixed)
        {
            background.anchoredPosition = fixedPosition;
            background.gameObject.SetActive(true);
        }
        else
            background.gameObject.SetActive(false);
    }

    protected override void Start()
    {
        base.Start();
        fixedPosition = background.anchoredPosition;
        SetMode(joystickType);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        if(joystickType != JoystickType.Fixed)
        {
            background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
            background.gameObject.SetActive(true);
        }
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if(joystickType != JoystickType.Fixed)
            background.gameObject.SetActive(false);

        base.OnPointerUp(eventData);
    }

    protected override void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam)
    {
        if (joystickType == JoystickType.Dynamic && magnitude > moveThreshold)
        {
            Vector2 difference = normalised * (magnitude - moveThreshold) * radius;
            background.anchoredPosition += difference;
        }
        base.HandleInput(magnitude, normalised, radius, cam);
    }

   public float GetAxisRaw(string dir)
    {
        float HorizentalAxisRaw = 0f;
        float VerticalAxisRaw = 0f;
        if (Horizontal > 0f)
        {
            HorizentalAxisRaw = 1f;
        }
        else if (Horizontal < 0f)
        {
            HorizentalAxisRaw = -1f;
        }

        if (Vertical > 0f)
        {
            VerticalAxisRaw = 1f;
        }
        else if (Vertical < 0f)
        {
            VerticalAxisRaw = -1f;
        }

        if (dir=="Horizontal")
        {

            return HorizentalAxisRaw;

        }else if(dir == "Vertical")
        {
            return VerticalAxisRaw;

        }
        else
        {
            return 0f;
        }
    }



    public bool GetButtonDown(string type)
    {
        if(type=="Attack")
        {
            return ButtonAttackState;

        }else if(type == "Jump")
        {
            return ButtonJumpState;
        }

        return false;
    }


    public void SetButtonAttackClicked()
    {
        ButtonAttackState = true;
    }

    public void SetButtonAttackReleased()
    {
        ButtonAttackState = false;
    }

    public void SetButtonJumpClicked()
    {
        x++;
        if(x==1)
        ButtonJumpState = true;
      }
    public void SetButtonJumpReleased()
    {
        x = 0;

        ButtonJumpState = false;
        
    }

    public float GetAxis(string dir)
    {
        if (dir == "Horizontal")
        {

            return Horizontal;

        }
        else if (dir == "Vertical")
        {

            return Vertical;

        }
        else
        {
            return 0f;
        }
    }


    private void Update()
    {

        Debug.Log(ButtonJumpState);
    }

    private void LateUpdate()
    {
        ButtonJumpState = false;
    }
}

public enum JoystickType { Fixed, Floating, Dynamic }