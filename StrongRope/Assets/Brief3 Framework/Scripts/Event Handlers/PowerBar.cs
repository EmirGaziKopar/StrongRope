using UnityEngine;

using UnityEngine.UI; // << This 'namespace' allows us to access all the builtin Unity UI controls (Eg sliders, buttons etc)

/*
    Script: PowerBar
    Author: Gareth Lockett
    Version: 1.0
    Description: Event listener. Call this scripts PowerUp() and PowerDown() methods from some event (Eg PlayerInputEvents KeyPressedEvent() and KeyNotPressedEvent())
*/

[RequireComponent( typeof( Slider ) ) ] // << This REQUIRES whichever GameObject you put this script on to have a Slider component. If it doesn't have one, it will try to auto add one.
public class PowerBar : MonoBehaviour
{
    // Properties
    public float powerIncreaseSpeed = 0.1f; // Speed at which the power bar will increase at (Eg a value of 1 will increase from 0 to 1 if the key is held down for 1 second)

    private Slider powerBar;                // Reference to the slider (Get this in Start())

    // Methods
    private void Start()
    {
        // It is often a good idea to grab a reference to a component at Start() instead of constantly called this.gameObject.GetComponent<Slider>()
        this.powerBar = this.gameObject.GetComponent<Slider>();

        // Probably want the power bar to start at zero at the start of the game.
        this.powerBar.value = 0f;
    }

    public void PowerUp()
    {
        // Whenever this method is called, increase the value of the power bar.
        this.powerBar.value += Time.deltaTime * this.powerIncreaseSpeed;
    }

    public void PowerDown()
    {
        // Whenever this method is called, decrease the value of the power bar.
        this.powerBar.value -= Time.deltaTime * this.powerIncreaseSpeed;
    }
}
