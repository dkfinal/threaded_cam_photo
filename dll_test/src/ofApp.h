#pragma once

#include "ofMain.h"
#include "CamThread.h"

class ofApp : public ofBaseApp{

	public:
		void setup();
		void update();
		void draw();

		//Path params
		std::string mainPath = "";
		std::string fullPath = "";

		//Path funcs
		void setDirectory(std::string path);
		void pathLocator();

		//Camera default params
		int camWidth = 1920;
		int camHeight = 1080;
		int dNum = 0;

		//Camera threads
		std::vector<CamThread*> ct;

		//Listing devices
		std::vector<ofVideoDevice> dList;

		//Camera interaction
		
		void cameraSettings(int dNum, int camW, int camH);
		void doShot();
		
		void setDeviceNum(int deviceNum);
		void setCamRes(int camW, int camH);


		//Import-Export funcs
		//Listing for gui
		int deviceAmount();
		std::string deviceName(int deviceNum);

		//Fps export to gui
		int getFPS();
		//OnClose
		void closeAll();
};
