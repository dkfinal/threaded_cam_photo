#include "CamThread.h"

void CamThread::setup(int dNum, int w, int h, std::string path) {
	this->dNum = dNum;
	this->w = w;
	this->h = h;
	this->path = path;
}

void CamThread::threadedFunction() {
	Cam cam(dNum, w, h, path);
	cam.takeShot();
}

