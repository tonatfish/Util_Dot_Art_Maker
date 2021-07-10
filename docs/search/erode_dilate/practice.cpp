#include <opencv2/opencv.hpp>
#include<iostream>
using namespace std;
using namespace cv;


int main()
{
	Mat img = imread("image.jpg", 0);
	double scale = 0.2;
	// 圖片太大先縮小
	resize(img, img, Size(0, 0), scale, scale);
	blur(img, img, Size(7, 7));
	imshow("origin_img", img);

	Mat erode = Mat::zeros(img.rows, img.cols, CV_8UC1);
	Mat delite = Mat::zeros(img.rows, img.cols, CV_8UC1);

	// binary
	for (int i = 0; i < img.rows; i++) {
		for (int j = 0; j < img.cols; j++) {
			if (img.at<uchar>(i, j) < 40) {
				img.at<uchar>(i, j) = 255;
			}
			else {
				img.at<uchar>(i, j) = 0;
			}
		}
	}

	imshow("black_white_img", img);

	// erode
	for (int k = 0; k < 7; k++) {
		for (int i = 0; i < img.rows; i++) {
			for (int j = 0; j < img.cols; j++) {
				bool white = img.at<uchar>(i, j) == 255;
				for (int m = -15; m <= 15 && white; m++) {
					for (int n = -15; n <= 15 && white; n++) {
						if (i + m >= 0 && i + m < img.rows && j + n >= 0 && j + n < img.cols) {
							white = white && img.at<uchar>(i + m, j + n) == 255;
 						}
					}
				}
				if (white) {
					erode.at<uchar>(i, j) = 255;
				}
				else {
					erode.at<uchar>(i, j) = 0;
				}
			}
		}
	}

	imshow("erode_img", erode);

	// dilate
	for (int k = 0; k < 5; k++) {
		for (int i = 0; i < img.rows; i++) {
			for (int j = 0; j < img.cols; j++) {
				bool white = erode.at<uchar>(i, j) == 255;
				for (int m = -2; m <= 2 && white; m++) {
					for (int n = -2; n <= 2 && white; n++) {
						if (i + m >= 0 && i + m < img.rows && j + n >= 0 && j + n < img.cols) {
							white = white || erode.at<uchar>(i + m, j + n) == 255;
						}
					}
				}
				if (white) {
					delite.at<uchar>(i, j) = 255;
				}
				else {
					delite.at<uchar>(i, j) = 0;
				}
			}
		}
	}

	imshow("dilate_img", delite);

	Mat labels;
	int number_labels = connectedComponents(delite, labels);
	cout << "共有: " << number_labels - 1;

	imshow("end_img", delite);
	waitKey(0);
}