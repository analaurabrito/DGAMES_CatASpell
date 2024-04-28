using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 1f;

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}