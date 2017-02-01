4GC3 - Sensory Perception, Cognition, and Human/Computer Interaction
Sahajmeet Bhutta

http://theremin.music.uiowa.edu/MISpiano.html
I used the A4 FF note only from this page.
Though I could have used a shorter- sounding note, the FF note was the loudest, so I chose it.

A demo of the application is uploaded to youtube and can be found at: https://youtu.be/_3USmGBr3Es

Approaches and Decisions:

I changed the pitch of the single note by calculating the relative pitch from A440.
I sourced parts of my code from the Unity3D docs and from Unity forums.

As I was trying to play a short melody, I kept making mistakes and got frustrated waiting for the 
notes to end.
Because of this, I added in the option to stop playback of all notes by pressing the spacebar.

I used the 3D cube in Unity to create the keys and tilted them in order to show both the key mappings 
and the notes on the keys themselves.
I was initally going to create a script for each note, but then realized I could create a single script
applicable to all notes.
A problem I encountered was, when hitting the keys, the note would begin playing multiple times as the key
press was longer than an individual frame. I was calling the note to play each frame as long as the key was pressed. 
To remedy this, I changed from Input.KeyCode(respective) to only play the note one time 
for each key press.