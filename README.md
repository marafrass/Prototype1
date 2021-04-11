# ITERATIVE PROTOTYPE - CHOCOLATE QUAKE


## To download builds directly, head on over to https://marafrass.itch.io/chocolate-quake and use the password "quake"! Both PC and Mac builds are provided!


For my final project, I decided to go with the shooter I did early on. 

A series of changes have been made to the game since I uploaded it first, among which are:

- The player now respawns in checkpoints, depending on their progress.
- A number of new weapons and weapon placements have been added, such as a flamethrower, hatchets, and a railgun.
- Enemies no longer exist in the level, and instead spawn in as you play and reach certain points in the level.
- Some progress is now halted by level interaction, i.e. pushing buttons to move obstacles, etc.
- Large parts of the level have been redesigned, and some have had completely new areas added to them.
- The game now has a start menu, with a series of legally distinct names, all of which are incredibly silly.
- There is now an end state of the game.
- Aerial control for the player has been massively improved.
- Changed music and added tons of sound effects.
- Added new secrets to the game
- Added new enemies to the game, such as long range demon and short-range projectile footsoldiers.
- Enemies and weapons have been balanced; the range of the shotgun is a lot shorter, and it is no longer possible to kill enemies with it from far away.
- Cake gun is in code, but no longer in the level.
- Added a short version of another level, but left that for later development.
- Enemy health drop rate has been reduced from .5 to .2.


In general, the game plays a lot smoother and faster than before. The game is challenging and demands quick movement, which I'm very happy with.

# ITERATIVE PLAYTEST RESULTS

There was a clear split in playtests of the game in regards to familiarity with the genre and pre-existing skills with fast-paced FPS's, which led me to consider the feedback carefully. There were a number of issues that were brought up that helped either side of the skill threshold, which I was very appreciative of.

Spawning enemies have no pre-fire timeout - they fire immediately. This was an issue brought up by all testers with pre-existing skill of this type of game, and is a fair point. If the enemies can appear anywhere and fire at the player directly, it can seem pretty unfair, even if the projectiles are slow enough to dodge. I'm going to have a look at this and attempt to find a good fix.

Players were unsure if they had interacted with the initial button correctly, and did not necessarily notice the statues moving. This needs to be telegraphed clearer, obviously, so I'm going to have a look at that.

Some mentioned wanting more weapons or weapon variety - there are a bunch of weapons in the level, but a lot of them are hidden and off the beaten path! Considering this is tricky - either I make them easier to find, or I add them in to the main path. At the same time, I'd like to reward curiosity and exploring the map, so some weapons should be hidden. Will consider this.

The pace and motion of the game was something I assumed of the player, and some players clearly came to the game with pre-existing genre savvy - but it seemed like that assumption might have caused me to overlook some of the design and immediately explain the necessary speed of the game. I'll try to make that a little clearer, either in instruction or by incentivizing it through enemy placement.

As for additions to the game, there were a few suggestions! Boss fights, spells, abilities - all stuff I'm interested in, but not sure where/how/if to implement. My main priority right now is making sure more players can get through the level - I still want to keep the difficulty and the speed of the game, but I would like it to be a little clearer and a little more fair!

# ITERATIVE PLAYTEST FINAL EDITS

I did more testing! This time with seasoned FPS player, none of which seemed to have much of an issue with the game after the final fixes. I found myself yet again at the difficult design decision of whether or not I wanted to offer a more casual experience or a challenging one. Eventually, I settled on the latter - this is my game, and I want it to be a certain way. That said, I did make a few more edits based on playtester feedback, that should make the game more manageable and fair to all players!

- Button to raise statue in room one is ten times clearer now, and inspecting the statues gives players a hint. Additionally, a platform has been added to the statues to make it as clear as possible.
- Mobs now spawn in fewer, more manageable numbers at the beginning areas.
- Added more secrets to the game. Rocket launcher and flame thrower are both in.
- Health drop rate is higher.
- Enemies now have a slight delay before they fire weapons when spawning.
- Minor balance changes.

The game is far better now, runs smoothly, and I'm really happy with it. Excited to present it during class.


## * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

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





All sound effects used are public domain or licensed under Creative Commons.

Lowpoly textures, except ones made by me, are either public domain or sourced from the 1994 game Heretic, developed by Raven Software and published by id Software.

Base game template (FPS Microgame) by Unity Technologies.

Soundtrack "The Only Thing They Fear is You" and "BFG Division" by Mick Gordon for DOOM 2016 and DOOM Eternal.

Pixelation camera effect and skeleton model sourced from the Unity asset store:
https://assetstore.unity.com/packages/vfx/shaders/fullscreen-camera-effects/pixelation-camera-65900
https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/toon-rts-units-undead-demo-95640

Short-range projectile footsoldier sprite sourced from DOOM II.
