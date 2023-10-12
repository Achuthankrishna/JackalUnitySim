## Simulation of Jackal Path Planning using Unity and Nvidia Isaac Sim

A simple simulation project to simulate clearpath jackal and implement a navigation algorithm using a custom movebase in complex simulation environments such as Unity and Nvidia Isaac Sim. 

## Steps fo Unity Simulation

* Clone the package , and make sure you have Unity3d installed.

* To run the simulation, download the package and use unity. In Unity, Upload the project and in scenes, click on sample scenes and wait for it to load. In terminal, Now type the following 

`roslaunch rosbridge_server rosbridge_websocket.launch`

* Make sure your IP address matches the one to that in Unity and If not do change it. If you're not using ROSTCP, you can install from the below link https://github.com/Unity-Technologies/ROS-TCP-Connector/tree/v0.6.0

* Once that is done, install jackal package using the following command :

`sudo apt-get install ros-noetic-jackal-simulator ros-noetic-jackal-desktop ros-noetic-jackal-navigation`

* Now launch the gazebo world with the front laser attached

`roslaunch jackal_gazebo jackal_world.launch config:=front_laser` 

* To launch the navigation demo, run:

`roslaunch jackal_navigation odom_navigation_demo.launch`

* To visualize with the suggested rviz configuration launch:

`roslaunch jackal_viz view_robot.launch config:=navigation`

## Loading Scenes in Unity 3D

* The simulation scenes are given in Assets/Scenes. The sample scene is an outdoor environment and the spawn.cs will load the jackal robot at the base position.

*