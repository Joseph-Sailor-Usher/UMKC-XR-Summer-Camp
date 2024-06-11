Moves an object between [[location]].
- **UpdateFrequency:** the amount of time between updates to the object's position.
- **Preemption:** whether or not an object may begin moving toward a new location before reaching a current target location.
- **Speed:** the speed in meters per second at which the object will move.
- **Locations:** a reference to the location game object which the object will move between.
- **CurrentLocationIndex:** the index of the location the object is either currently at or moving toward.
- **OnStartedMoving:** is invoked when the object begins moving.
- **OnChangedTarget:** is invoked when the object begins moving toward a new target location.
- **OnReachedLocation:** is invoked when the object reaches its target location.