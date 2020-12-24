# Assignment-1-GE
Repository for Assignment 1 of the Module Games Engines 1

Name: Ciaran McHale

Student Number: C16486904

Class Group: DT228/4


For my Assignment I have decided to attempt to code procedurally generated terrain. I will attempt to complete this by using pseudorandom noise to generate a height map and then choose terrain types according the the height. 

For my references I looked at previous projects and saw one that had to do with procedurally generated terrain as well. 
I also viewed the procedural generation forum on reddit(1)

1. Procedural Generation Forum Reddit - Internet [Available: https://www.reddit.com/r/Unity3D/comments/8myoiw/procedural_unity3d_terrain/]

# **Description of the project:**

My project was suppose to be a procedurally generated alien terrain which would go on infinitely. I started by generating a grid of Noise map values which I then rendered to a screen. Once this was complete I needed to be able to have better contorl over the noise. I added in different parameters which would give me better contorl such as amplitude, frequency and Octave whcih gave me contorl of the intervals between the noise. I also added the ability to change the color of certain regions of the terrain which in a sense is mapping terrain types to our noise. After finsing this I then created a mesh object which would go over the noise. After this I then generated the map mesh with the ability to change the height of the mesh and the level of detail. Once this was all complete I had created my terrain so to speak. The next step was to create infinite terrain that generated forever. This part was suppose to be able to create endless terrain so that it would never end. I ran into problems with this part and couldnt get it to work. I attempted to create a script which would update the visible chunks of the map depending on where the viewer object was, in this case a cube. This would make it look like the map never ended and that the terrain was infinite however I couldnt get it to work. 

# **Development:**

For this assignment I had been using what we learned from class in terms of vertices and vectors and the experince of utilising unity from labs. This included creating objects, materials etc. However I did look into generating noise and in particular meshes and how to store vertices in 1-D arrays. I took alot of what I learned from labs and applied it here with some help from tutorials as well. These tutorials helped me to better understand how meshes worked and how to go about creating a terrain landscape. I cretaed the look of the landscape myself as well as adding addtional options for editing the landscape. I also worked through creating the approiate mesh and intergrating it with the map generator and noise script. I went through the different ways I could attempt to achieve the endless terrain but couldnt achieve one I was happy with. I also went through how I could make the terrain more seamless.

# **What I am Most Proud of:**

I am most proud of how the project shaped up in the end. I was slighlty worried about generating a terrain that looked nice and was pleasing while also making it procedurally generate as well. Although I didnt quite get it to work I felt I put in a good effort and attempted to push myself. However the finish product was not how I ultimately envisoned it and overall felt I could have done better. 

# **Links:**

[![YouTube](https://i9.ytimg.com/vi/ZMA89F9vDUM/mq2.jpg?sqp=CMDZj_8F&rs=AOn4CLBEjRjZ5I5CQQQO4uQCZ5Iw-eZ1cQ)](https://www.youtube.com/watch?v=ZMA89F9vDUM)

[![YouTube](https://i9.ytimg.com/vi/WduY4PgFiaQ/mq1.jpg?sqp=CJjej_8F&rs=AOn4CLBS_l-3BBUI1glulFou4buRdqrymg)](https://www.youtube.com/watch?v=WduY4PgFiaQ)






