#include <opencv2/opencv.hpp>
#include<iostream>
using namespace std;
using namespace cv;

int Sobel_X[3][3] = { 
	{-1, 0, 1 }, 
	{-2, 0, 2}, 
	{-1, 0, 1} };
int Sobel_Y[3][3] = { 
	{ -1, -2, -1 },
	{ 0, 0, 0 },
	{ 1, 2, 1 } };

int main()
{
	Mat img = imread("pikachu.png");

	Mat gray;
	cvtColor(img, gray, cv::COLOR_BGR2GRAY); //Âà¦Ç¶¥
	blur(gray, gray, Size(3, 3));
	Mat edge_img = Mat::zeros(img.rows, img.cols, CV_8UC1);
	int T = 150; // ªùÂe­È

	for (int i = 0; i < img.rows; i++) {
		for (int j = 0; j < img.cols; j++) {
			int pixelx = 0, pixely = 0;
			for (int m = 0; m < 3; m++) {
				for (int n = 0; n < 3; n++) {
					if (i - 1 + m >= 0 && i - 1 + m < img.rows && j - 1 + n >= 0 && j - 1 + n < img.cols) {
						pixelx += Sobel_X[m][n] * gray.at<uchar>(i - 1 + m, j - 1 + n);
						pixely += Sobel_Y[m][n] * gray.at<uchar>(i - 1 + m, j - 1 + n);
					}
				}
			}
			if (abs(pixelx) + abs(pixely) >= T) {
				edge_img.at<uchar>(i, j) = 255;
			}
			else {
				edge_img.at<uchar>(i, j) = 0;
			}
		}
	}

	imshow("origin_img", img);
	imshow("gray_img", gray);
	imshow("edge_img", edge_img);
	waitKey(0);	
}