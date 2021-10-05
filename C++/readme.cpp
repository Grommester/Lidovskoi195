#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
#include  "opencv2/highgui/highgui.hpp"
#include  "opencv2/imgproc/imgproc.hpp"
#include <iostream>
#include <stdio.h>
#include <stdlib.h> 
using namespace cv;
using namespace std;
Mat img;
int main()
{
	// setlocale(LC_ALL, "Russian");
	//char filename[80];//road.jpg
	//cout << "Vvedite imya faila, v kotoriy hotite nesti izmeneniya, i najmite Энтер" << endl;
	//cin.getline(filename, 80);
	//cout << "Otkroy file";
	//cout << filename << endl;

	//Mat img = imread("road.jpg", 1);

	int height = 520;
	int width = 840;
	Mat img(height, width, CV_8UC3);
	Point textOrg(100, img.rows / 2);
	int fontFace = FONT_HERSHEY_SCRIPT_SIMPLEX;
	double fontScale = 2;
	Scalar color(200, 100, 50);
	putText(img, "OpenCV Step By Step", textOrg, fontFace, fontScale, color);
	namedWindow("Hello world",0);
	imshow("Hello world", img);
	waitKey(0);
	return 0;
}
