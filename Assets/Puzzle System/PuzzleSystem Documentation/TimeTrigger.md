Fires events based on a specified time interval.
- **TriggerEnabled:** is a boolean (true or false) value that turns the trigger on or off.
- **SecondsBetweenTriggers:** is how many seconds the trigger will wait until it triggers again.
- **OnTriggered:** is invoked when the amount of time since the last trigger surpasses `SecondsBetweenTriggers`. 
- **OnTimerStarted:** is invoked when the timer is started.
- **OnTimerStopped:** is invoked when the timer is stopped.
