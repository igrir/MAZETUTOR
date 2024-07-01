using UnityEngine;

public class LabyrinthController:MonoBehaviour
{
    private void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, 20f) * Time.deltaTime);
    }
}