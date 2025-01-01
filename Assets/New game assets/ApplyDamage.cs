using UnityEngine;

public class ApplyDamage: MonoBehaviour
{
    public float damage = 10f;  

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet")) 
        {
            Planet_Health planetHealth = other.GetComponent<Planet_Health>();
            if (planetHealth != null)
            {
                planetHealth.TakeDamage(damage);  
               
            }
        }

        // Optionally destroy the asteroid after the collision
        Destroy(gameObject);
    }
}
