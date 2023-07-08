To run the simulation, downlaod the package and use unity. In Unity, Upload the project and in scenes, click on sample scenes and wait for it to load. In terminal, Now type the following 


roslaunch rosbridge_server rosbridge_websocket.launch

Make sure your IP address matches the one to that in Unity and If not do change it. If you're not using ROSTCP, you can install from the below link https://github.com/Unity-Technologies/ROS-TCP-Connector/tree/v0.6.0
Once that is done, install jackal package using the following command :
sudo apt-get install ros-noetic-jackal-simulator ros-noetic-jackal-desktop ros-noetic-jackal-navigation

Now launch the gazebo world 
roslaunch jackal_gazebo jackal_world.launch config:=front_laser
To launch the navigation demo, run:

roslaunch jackal_navigation odom_navigation_demo.launch

To visualize with the suggested rviz configuration launch:

roslaunch jackal_viz view_robot.launch config:=navigation