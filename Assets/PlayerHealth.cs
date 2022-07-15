using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    public float maxHealth;
    public float changeHealth;

    private float currentHealth;
    private int noHealth = 0;
    
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Current health is " + currentHealth);
    }
    
    
    public void healthChange()
    {
        if(currentHealth != noHealth){
            currentHealth = currentHealth + changeHealth;
            Debug.Log("Health is currently " + currentHealth);

        } else {
            dead();
        }
          
    }
    
    void dead()
    {
        Debug.Log("No more health left." + currentHealth);
    }

}