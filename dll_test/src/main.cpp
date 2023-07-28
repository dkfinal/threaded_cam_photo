#include "ofMain.h"
#include "ofApp.h"

static shared_ptr<ofApp> app(new ofApp);
static shared_ptr<ofAppBaseWindow> mainWnd = nullptr;

#ifndef OF_EXPORT
#define OF_EXPORT

#define EX __declspec(dllexport)

extern "C" {
	EX void createWnd();
	EX int dAmount();
	EX char* dName(int dNum);
	EX void freeP(char* p);
	EX void initCam(int dNum, int camW, int camH);
	EX void setDir(const char* path);
	EX void saveCam();
	EX int fps();
	EX void closeOnLeaving();
}
#endif

EX void createWnd() {
	ofGLFWWindowSettings settings;
	settings.setSize(100, 100);
	settings.visible = false;
	settings.setPosition(glm::vec2(300, 10));
	settings.decorated = false;
	settings.windowMode = OF_WINDOW;
	mainWnd = ofCreateWindow(settings);

	ofRunApp(mainWnd, app);
	ofRunMainLoop();
}

EX int dAmount() {
	return app->deviceAmount();
}

EX char* dName(int dNum) {
	std::string str = app->deviceName(dNum);
	char* CSStr = new char[str.length() + 1];
	strcpy_s(CSStr, str.length() + 1, str.c_str());

	return CSStr;
}

EX void freeP(char* p) {
	delete[] p;
}

EX void initCam(int dNum, int camW, int camH) {
	app->cameraSettings(dNum, camW, camH);
}

EX void setDir(const char* path) {
	app->setDirectory(path);
}

EX void saveCam()
{
	app->doShot();
}

EX int fps() {
	return app->getFPS();
}

EX void closeOnLeaving() {
	app->closeAll();

	if (mainWnd != nullptr) {
		mainWnd->setWindowShouldClose();
		mainWnd.reset();
		mainWnd = nullptr;
	}
}