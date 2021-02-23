# DESIGN JOURNAL CART 310

# NOTE FOR TESTERS: If you're playing on PC, you can alternatively download a build of the game from this link: https://marafrass.itch.io/chocolate-quake using the password "quake". The file size is about a tenth of the project and will run directly instead of through the Unity editor.

## Prototype 1 - Chocolate Quake

I usually set out to make comedic/narrative games, so for this project, I wanted to go in a complete opposite direction.



## What are the barebones mechanics needed to make a simple first person shooter engaging in both play and feedback?



In order to quickly work out the prototype, I opted to rework and mod one of the Unity template projects - the "FPS Microgame", which features a first-person character controller, base enemy templates and projectile systems. Beyond these core systems, there were a slew of minor features - a HUD compass, ammunition, objective trackers, and so on - and these were the first to go. The intent was to scale down as much as possible and remove everything that wasn't essential to the core experience of the shooter.

On that note, I had to figure out what exactly the core experience of the shooter was - as such, I went back to play the classics. DOOM, Hexen, Blood, etc - these games were to be my main source of inspiration, even if the goal of my prototype was even simpler. Point, run and shoot - and never stop. The question posed at the start of this journal states "engaging in both play and feedback," which I will go on to explain below:

1. #### A core tenet of the shooter is skill-based action. The game should continuously provide tense tests of skill in the player, to facilitate a feeling of being tested, and of being in danger, with outplaying the enemy the only solution.

2. #### The game itself should feel impactful. Firing a gun should feel powerful, both in sound and visual feedback. Moving around should feel fast and fluid - no matter if you hit a key or a mouse button, the impact should feel direct and powerful.

3. #### The "Game Feel" should be the type that makes you swing around in your chair, your whole body bobbing and weaving around the enemies.



### Questions for Playtesters:

1. Do you play a lot of first person shooters? Do you consider yourself a skilled player?
2. How did you feel about the speed of the game? The enemies and the player character?
3. Were the guns satisfying to fire? Did they feel impactful?
4. Did you feel challenged? How did you feel about the game difficulty?
5. Did you move in your chair as you played? Did the game at any point get your adrenaline pumping?
6. Was there something you wanted to do in game, but couldn't?
7. Were there weapons or abilities you expected/wanted from the game?
8. Did the game hold your attention?
9. Anything else you want to add?

# PLAYTEST RESPONSES

First thing I noticed from playtests was that players were exploiting the range on the standard weapon—the shotgun—rather than engaging in a more direct and aggressive playstyle. The projectiles could be spammed from a distance, and since they had a 5sec lifespan and no dropoff in damage, they were easy to exploit. Similarly, players were able to lure in single enemies into their range, using the weapons, instead of being charged by an entire group.

​	This was eye-opening, and a wonderful realization, as it marked how important it was to differentiate weapons. The shotgun had to become more short-ranged, and the possibility of a railgun or a rifle would help bridge the gap between the aforementioned weapon and the rocket launcher. All in all, weapon variety should take a backseat to situational weaponry - few weapons with distinct uses is better than twenty that overlap. Other than that, everyone mentioned loving how the guns felt to use - impactful and powerful, which was encouraging to hear.

​	The speed of the game was received well - some weren't sure about the amount of enemies, while others claimed that was the chief source of difficulty. A few did end up getting ganged up on by a number of enemies, and one asked for better visual feedback for when they were getting hit. I think in upcoming level design, encounters will be grouped up differently and in more manageable chunks - possibly balanced by fewer health drops.

​	Not everyone found a way out of the first room - the platforming might have been unclear. Considering making this clearer by adding a light source above the two statues you need to jump on. On that note, the jumping needs more aerial control, as a few thought it felt sluggish or difficult to platform with.

​	For the next playtests, Im hoping to have more experienced players test it out - a lot of really interesting feedback came out of these tests, and I think they really help solidify the foundational designs. Definitely want to add a dash to the game, as well as some new and more interesting enemies. And levels, too, but we'll see...


# PLAYTEST RESPONSES

First thing I noticed from playtests was that players were exploiting the range on the standard weapon—the shotgun—rather than engaging in a more direct and aggressive playstyle. The projectiles could be spammed from a distance, and since they had a 5sec lifespan and no dropoff in damage, they were easy to exploit. Similarly, players were able to lure in single enemies into their range, using the weapons, instead of being charged by an entire group.

​	This was eye-opening, and a wonderful realization, as it marked how important it was to differentiate weapons. The shotgun had to become more short-ranged, and the possibility of a railgun or a rifle would help bridge the gap between the aforementioned weapon and the rocket launcher. All in all, weapon variety should take a backseat to situational weaponry - few weapons with distinct uses is better than twenty that overlap. Other than that, everyone mentioned loving how the guns felt to use - impactful and powerful, which was encouraging to hear.

​	The speed of the game was received well - some weren't sure about the amount of enemies, while others claimed that was the chief source of difficulty. A few did end up getting ganged up on by a number of enemies, and one asked for better visual feedback for when they were getting hit. I think in upcoming level design, encounters will be grouped up differently and in more manageable chunks - possibly balanced by fewer health drops.

​	Not everyone found a way out of the first room - the platforming might have been unclear. Considering making this clearer by adding a light source above the two statues you need to jump on. On that note, the jumping needs more aerial control, as a few thought it felt sluggish or difficult to platform with.

​	For the next playtests, Im hoping to have more experienced players test it out - a lot of really interesting feedback came out of these tests, and I think they really help solidify the foundational designs. Definitely want to add a dash to the game, as well as some new and more interesting enemies. And levels, too, but we'll see...





All sound effects used are public domain or licensed under Creative Commons.

Lowpoly textures, except ones made by me, are either public domain or sourced from the 1994 game Heretic, developed by Raven Software and published by id Software.

Base game template (FPS Microgame) by Unity Technologies.

Soundtrack "The Only Thing They Fear is You" by Mick Gordon for DOOM Eternal.

Pixelation camera effect and skeleton model sourced from the Unity asset store:
https://assetstore.unity.com/packages/vfx/shaders/fullscreen-camera-effects/pixelation-camera-65900
https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/toon-rts-units-undead-demo-95640

Cacodemon low poly model sourced from this site: https://sketchfab.com/3d-models/cacodemon-low-poly-7228d01592ad4e369f9e21069a6e8cb9#download
