import cv2
import numpy as np

img = cv2.imread('./Lena.jpg')
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

gray = np.float32(gray)
# Harris Corner Detector in OpenCV
dst = cv2.cornerHarris(gray, 2,3,0.2)
dst = cv2.dilate(dst, None)

img[dst>0.01*dst.max()] = [0,0,255]

cv2.imshow('dst', img)
if cv2.waitKey(0) & 0xFF == 27:
    cv2.destroyAllWindows()