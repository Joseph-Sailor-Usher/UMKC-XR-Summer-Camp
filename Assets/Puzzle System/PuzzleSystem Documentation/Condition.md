A basic unit that represents a true or false (boolean) state, with events that fire on state changes.
- **IsMet:** a boolean value that represents whether the condition is presently satisfied.
- **OnBecomesTrue:** invoked when the condition is updated to be true and it was previously false.
- **OnStaysTrue:** invoked when the condition is updated to be true but it was already true.
- **OnBecomesFalse:** invoked when the condition is updated to be false and it was previously false
- **OnStaysFalse:** invoked when the condition is updated to be false but it was already false.
- **OnUpdate:** invoked when the condition is updated.
