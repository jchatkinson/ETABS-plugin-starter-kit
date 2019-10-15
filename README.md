# ETABS-plugin-starter-kit

This repo is intended to be a starting point for creating an ETABS plugin in C#. 
It includes a small amount of boiler plate so that the plugin can compile and load into ETABS.

A more thorough overview of the repo can be read at the following webiste: https://kinson.io/post/etabs-plugin-quickstart/

Note that this plugin was built using Version 17 of the ETABS oAPI. Starting in ETABS 2018, a new api has been released and will provide backward compatibility for future releases, so it is recommended to update this reference. This new API is contained in the library file `ETABSv1.dll` and should be imported instead of the older `ETABSv17.dll`. 
