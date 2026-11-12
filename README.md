# MG5
## Devlog


1. I think it's more useful to use a NavMesh rather than scripting in games that utilize a lot of enemy NPCs that need to move on their own. An example of this would be Pokemon, where the pokemon in the wild move toward the player automatically once they come within a certain distance. Using a NavMesh system here would be more simple than trying to script every pokemon's movements. In contrast, games with less enemy NPCs that don't have to be as autonomous might benefit more from scripting. This could be realized in fighting games like Tekken, where the player often faces off against one opponent. This opponent, while needing to move toward and away from the player to attack, doesn't need as much freedom to move around due to a smaller stage size. In addition, they often have more complex animations, which is where scripting would be a better choice than a NavMesh.  

2. The first line of the for loop is looping through the bird array, as long as the index (i) is less than 3. The first line of the body of the for loop calls the RunAway method if the distance between the birds and the player is less than or equal to the value of the _interactDistance variable. This allows the birds to avoid the player. In this line, the call to Vector3.Distance is essentially calculating the distance between its two arguments which, in this case, are the bird's position and the player's position. The last line in the for loop runs the RunAway method. Based on the if statement all of the birds will run away from the player, given they are close enough to them. 


## Open-Source Assets
- [Quirky animal 3D models](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235)
- [Mountain fantasy environment models](https://www.fab.com/listings/60487a72-3f20-4bb2-aa78-247ed1582656)