# First Person Camera
Someone was having problems getting the First Person controller from Unity's standard assets to work with her assignment after updating to a newer version of Unity. She asked for my help, so I decided to make a simple version of the first person camera controller functionality wise, but overengineer it as practice.

The only requirement for the controller was that you could move it around so it can be used to show different things in the scene. I used the project as some practice to learn more about delegates.

---

### InputProvider
A base class monobehaviour that contains a bunch of public delegates and protected functions that call the different delegates.

### UserInput
A class that inherits from InputProvider. This class in Update checks if certain buttons are pressed or if the mouse is being moved. Depending on what the user does it calls the corresponding function from InputProvider.

### Controllable
A monobehaviour that moves the transform of the GameObject in a certain direction depending on which function is called.

### CameraMovement
The monobehaviour that connects an InputProvider with a Controllable. On Start it makes the cursor invisble and locks it, then it connects the movement functions from the Controllable to the delegates inside the InputProvider.
