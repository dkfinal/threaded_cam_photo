#include "Cam.h"

Cam::Cam(int dNum, int w, int h, std::string path) {
	cam.setDeviceID(dNum);
	cam.setup(w, h);
	this->path = path;
}

Cam::~Cam() {
	if (cam.isInitialized()) {
		cam.close();
	}
}

void Cam::takeShot() {
	if (cam.isInitialized()) {
		auto breakCounterMilliseconds = 30000; //Extra break
		auto timeStable = clock();

		while (shootCounter > 0) {
			//Extra break if camera does not throw new frames
			auto timeTemp = clock();
			if (timeTemp - timeStable > breakCounterMilliseconds) {
				break;
			}

			//Pushing every(?) new frame to the vector of frames
			cam.update();
			if (cam.isFrameNew()) {
				pics.push_back(cam.getPixels());
				shootCounter--;
			}
		}

		for (int i = 0; i < pics.size(); i++) {
			//MERGE PNG HERE WITH FBO AND SAVE

			int counter = 0;
			ofFile file;
			while (file.doesFileExist(path + ofToString(counter) + ".png")) {
				counter++;
			}
			std::string filePath = path + ofToString(counter) + ".png";
			pics[i].save(filePath, OF_IMAGE_QUALITY_BEST);
		}
		cam.close();
	}
}
