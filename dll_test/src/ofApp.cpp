#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup(){

}

//--------------------------------------------------------------
void ofApp::update(){
	if (ct.size() != 0) {
		for (int i = 0; i < ct.size(); i++) {
			if (!ct[i]->isThreadRunning())
			{
				delete ct[i];
				ct.erase(ct.begin() + i);
			}
		}
	}
}

//--------------------------------------------------------------
void ofApp::draw(){

}

int ofApp::deviceAmount() {
	dList.clear();
	ofVideoGrabber lister;

	dList = lister.listDevices();
	return dList.size();
}

void ofApp::pathLocator() {
	auto currDate = std::time(nullptr);
	auto currDateStruct = *std::localtime(&currDate);

	std::string datePath = ofToString(currDateStruct.tm_mday) + "." +
		ofToString(currDateStruct.tm_mon + 1) + "." +
		ofToString(currDateStruct.tm_year + 1900) + "\\" +
		ofToString(currDateStruct.tm_hour) + "-" +
		ofToString(currDateStruct.tm_min) + "\\";

	fullPath = mainPath + datePath;
}

void ofApp::setDirectory(std::string path) {
	mainPath = path + "\\";
}

void ofApp::cameraSettings(int dNum, int camW, int camH) {
	setCamRes(camW, camH);
	setDeviceNum(dNum);
}

void ofApp::doShot() {
	pathLocator();
	ct.push_back(std::move(new CamThread));
	ct.back()->setup(dNum, camWidth, camHeight, fullPath);
	ct.back()->startThread();
}

std::string ofApp::deviceName(int deviceNum) {
	if (deviceNum < dList.size())
		return ofToString(dList[deviceNum].deviceName);
}

void ofApp::setDeviceNum(int deviceNum) {
	if (deviceNum < dList.size()) {
		if (dList[deviceNum].bAvailable) {
			this->dNum = deviceNum;
		}
	}
}

void ofApp::setCamRes(int camW, int camH) {
	if (camW > 0 && camH > 0) {
		camWidth = camW;
		camHeight = camH;
	}
}

int ofApp::getFPS() {
	return ofGetFrameRate();
}

void ofApp::closeAll() {
	for (auto& var : ct) {
		var->stopThread();
		delete var;
	}
}
