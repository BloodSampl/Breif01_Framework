using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = Random.Range(0, 11);
        agility = Random.Range(0, 11);
        intelligence = Random.Range(0, 11);

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log(strength);
        Debug.Log(agility);
        Debug.Log(intelligence);

        // let's create some float temporary variables to hold our multiplier values.

        // create an agility multiplier should be set to 0.5
        float agilityMulti = 0.5f;
        // create a strength multiplier should be set to 1
        float strengthMulti = 1f;
        // create an intelligence multiplier should be set to 2.
        float inteligenceMulti = 2f;
        // Debug out our current multiplier values.
        Debug.Log(agilityMulti);
        Debug.Log(strengthMulti);
        Debug.Log(inteligenceMulti);
        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = 1;
        float styleF = (float)style; // I changed it to float so i can multiply it by the multiplier.
        styleF *= strengthMulti;
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = 1;
        float luckF = (float)luck;
        luckF *= inteligenceMulti;
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5 .
        rhythm = 1;
        float rhythmF = (float)rhythm;
        rhythmF *= agilityMulti;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log(styleF);
        Debug.Log(luckF);
        Debug.Log(rhythmF);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;

        // Debug out our new physical stat values

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        
        // Debug out our new dancing stat values
    }
}
