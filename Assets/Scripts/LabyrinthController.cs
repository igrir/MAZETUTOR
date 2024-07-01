using UnityEngine;

public class LabyrinthController:MonoBehaviour
{
    Vector3 targetRotation = Vector3.zero;

    public float RotationVal = 20;
    
    public void RotateLeft()
    {
        targetRotation.z = RotationVal;
    }

    public void RotateRight()
    {
        targetRotation.z = -RotationVal;
    }

    public void ResetRotation()
    {
        targetRotation.z = 0;
    }

    void Update()
    {
        if (targetRotation.z != 0)
        {
            this.transform.Rotate(targetRotation  * Time.deltaTime);
        }
    }

}