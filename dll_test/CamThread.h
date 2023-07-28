#pragma once
#include "ofThread.h"
#include "Cam.h"

class CamThread :
    public ofThread
{
public:
    void setup(int dNum, int w, int h, std::string path);

    void threadedFunction() override;

private:
    int dNum = 0;
    int w = 0;
    int h = 0;
    std::string path = "";
};

