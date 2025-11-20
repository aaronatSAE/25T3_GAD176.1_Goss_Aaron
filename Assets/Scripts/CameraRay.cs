using UnityEngine;

public class CameraRay : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private bool isDetectingPlayer = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        isDetectingPlayer = false;

        // do a raycast forward
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Player") == true)
            {
                // we did NOT hit the player object!
                Debug.Log("HIIIIIIIIIIIIII");
                isDetectingPlayer = true;
            }
        }
    }

    private void OnDrawGizmos()
    {
        if(isDetectingPlayer == true)
        {
            Gizmos.color = Color.cyan;
        }
        else
        {
            Gizmos.color = Color.yellow;
        }
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * 10f);
    }
}
