using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TranslationAxe
{
    X_AXE,Y_AXE,Z_AXE
}
public class ElevatorController : MonoBehaviour
{
    public float IntervalTranslationMax;
    public float CntTranslation;
    public TranslationAxe TranslationDirection;
    float x=0f;
    float y=0f;
    float z=0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    private void FixedUpdate()
    {
        switch(TranslationDirection)
        {
            case TranslationAxe.X_AXE:
            {

                    x += CntTranslation;

                    if (x > IntervalTranslationMax)
                    {

                        x = -IntervalTranslationMax;

                    }

                    transform.Translate(Vector3.right * x * 0.2f * Time.deltaTime);


                    break;
            }
            case TranslationAxe.Y_AXE:
                {
                    y += CntTranslation;

                    if (y > IntervalTranslationMax)
                    {

                        y = -IntervalTranslationMax;

                    }
                   
                    transform.Translate(Vector3.up * y * 0.2f * Time.deltaTime);

  
                    break;
                }

            case TranslationAxe.Z_AXE:
                {

                    z += CntTranslation;

                    if (z > IntervalTranslationMax)
                    {

                        z = -IntervalTranslationMax;

                    }

                    transform.Translate(Vector3.forward * z * 0.2f * Time.deltaTime);


                    break;
                }
        }
        
        
   
       
      



    }
}
