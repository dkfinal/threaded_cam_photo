#pragma once
#include "ofVideoGrabber.h"
#include "ofImage.h"

class Cam
{
public:
	Cam(int dNum, int w, int h, std::string path);
	~Cam();

	void takeShot();

private:
	ofVideoGrabber cam;
	int shootCounter = 10;
	std::string path = "";
	std::vector<ofImage> pics;
};

