The Puzzle System is designed to facilitate the creation of puzzle games within Unity with minimal coding. It allows developers to define conditions and triggers that interact to create complex puzzle mechanics.

## Main Components
**Conditions**
**[[Condition]]:** A basic unit that represents a true or false (boolean) state, with events that fire on state changes.
**Triggers**
- **[[ZoneTrigger]]**: Fires events when objects enter or exit a specific area.
- **[[TimeTrigger]]**: Fires events based on a specified time interval.
**[[Location]]**: Manages a list of transforms representing locations.
**Movement Providers**
- **[[MoveBetweenLocations]]**: Manages movement of game objects between predefined locations.

## Workflow and Interaction
1. **Define Conditions**: Use `Condition` to define the conditions required for a puzzle element.
2. **Set Up Triggers**: Use `ZoneTrigger`, `TimeTrigger`, to define how and when the puzzle conditions should be checked or triggered.
3. **Movement Logic**: Use `MoveBetweenLocations` and `MoveTo` to handle the movement of game objects as part of puzzle mechanics.
4. **Utility Management**: Use `Locations` to manage target positions.

## Example Usages
- Create a puzzle where a door opens when a key is put into a lock.
	- The key will have a name "Key 1"
	- The lock will have a `ZoneTrigger` which waits for an object with the name "Key 1" to trigger its `OnEnter`
	- The lock also has 
	- `MoveBetweenLocations` if the player collects a key and moves it inside a ZoneTrigger which acts on a `Condition`
- Create an elevator
	- Create a `Locations` game object with the various levels the elevator will move between.
	- Create an elevator game object with a `MoveBetweenLocations` script on it.
	- Create trigger volumes for each floor which look for the player's hands
		- On each button's `OnEnter` callback, set it to have the elevator's `MoveBetweenLocations` move to the button's floor
