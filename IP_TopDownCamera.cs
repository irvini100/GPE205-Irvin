using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IP_TopDownCamera : MonoBehaviour
{

public Transform m_Target;

[SerializeField]
private float m_Height = 10f;

[SerializeField]
private float m_Distance = 20f;

[SerializeField]
private float m_Angle = 45f;

[SerializeField]
private float m_SmoothSpeed = 0.5f;

private Vector3 refVelocity;
    // Start is called before the first frame update
    void Start()
    {
        HandleCamera();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamera();
    }

    protected virtual void HandleCamera()
    {
    if(!m_Target)
    {
        return;
    }
    //Build WorldPosition vector.
    Vector3 worldPosition = (Vector3.forward * m_Distance) + (Vector3.up * m_Height);
    //Debug.DrawLine(m_Target.position, worldPosition, Color.red);

    //Build our rotated vector.
    Vector3 rotatedVector = Quaternion.AngleAxis(m_Angle, Vector3.up) * worldPosition;
   // Debug.DrawLine(m_Target.position, rotatedVector, Color.green);

    //Move our position.
    Vector3 flatTargetPosition = m_Target.position;
    flatTargetPosition.y = 0f;
    Vector3 finalPostion = flatTargetPosition + rotatedVector;
    //Debug.DrawLine(m_Target.position, finalPostion, Color.blue);

    transform.position = Vector3.SmoothDamp(transform.position, finalPostion, ref refVelocity, m_SmoothSpeed);
    transform.position = finalPostion;
    transform.LookAt(flatTargetPosition);
     
    }

    void OnDrawGizmos()
    {

     Gizmos.color = new Color(0f, 1f, 0f, 0.25f);
        if (m_Target)
        {
         Gizmos.DrawLine(transform.position, m_Target.position);
            Gizmos.DrawSphere(m_Target.position, 1.5f);
        }
        Gizmos.DrawSphere(transform.position, 1.5f);
    }
}
