# Route-Finding-for-the-Reconstructed-3D-model-of-Building-in-HKU
3D Reconstruction, Walkable Area, Path Finding, SLAM. 

3D Reconstruction: KinectFusion, BundleFusion, Dot3D, 

(Downsampling, Simplification: Quadric-mesh-simplification, Merge: ICP, Export to mesh+texture)

Localization：VINS-Mobile(based on ORB-SLAM), OpenVSLAM

Walkable area & Path finding: Navmesh, A*

Web-based: webGL

![showwebGL](img/webGL_version.gif)
![showModel](img/wholeModel.png)
![showPart](img/partModel.png)

The reconModel0 is made by BundleFusion, dataset from its official website.
![showroute](img/show_route.PNG)
