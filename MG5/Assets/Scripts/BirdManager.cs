using UnityEngine;

public class BirdManager : MonoBehaviour
{
    [SerializeField] private float _interactDistance;
    [SerializeField] private Transform _player;
    [SerializeField] private Bird[] _birds;

    private void Update()
    {
        // STEP 7 -------------------------------------------------------------
        // This loop is supposed to visit EVERY entry in the _birds array
        //      and not create any errors when the game runs.
        // Uncomment and fix it.
        // You'll only need to fix the for loop () statement itself (line 16).
        // Feature 4 should work after you fix this and add birds to your game.

        for (int i = 0; i < 3; i++)
            //i < 4 = "index out of bounds" error
            //indexes always start at 0, i had to be one more than the
            //index number of the last bird (3 birds, last bird had index [2], so i
            //had to be 3 for it to move)
            // for statement looping through Bird[] array, accesses each bird's index 
        {
            Bird bird = _birds[i];
            if (Vector3.Distance(bird.transform.position, _player.position) <= _interactDistance)
                //if the distance between the birds and the player is less than or
                //equal to the value of var interact distance (determined in inspector)
                //then the run away method is called for the birds to avoid the player
            {
                bird.RunAway(_player.position);
                //calls run away method. makes the birds run away from the player
                //as they move toward them
            }
            }
            // STEP 7 -------------------------------------------------------------
        }
    }