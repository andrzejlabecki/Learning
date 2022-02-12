// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

class Solution
{
public:
    static double angleClock(int hour, int minutes)
    {
        //double hourAnglePerMin = 360 / (12 * 60); // 0.5 degree
        //double minAnglePerMin = 360 / (60); // 6 degrees

        //double hourAngle = 0.5 * (hour * 60 + minutes);
        //double minuteAngle = 6 * (minutes);

        // Just a thought process
        double angle = 0.5 * (hour * 60 + minutes) - 6 * (minutes);
        angle = 30 * hour + 0.5 * minutes - 6 * minutes;
        angle = 30 * hour - 5.5 * minutes;
        angle = 5 * (6 * hour - 1.1 * minutes);
        angle = abs(5 * (6 * hour - 1.1 * minutes));
        //angle = (angle > 180) ? angle - 180 : angle;
        angle = (angle > 180) ? 360 - angle : angle;

        return angle;
    }

    static double alignmentClock(int hour)
    {
        //double hourAngle = 0.5 * (hour * 60 + minutes);
        //double minuteAngle = 6 * (minutes);

        // Just a thought process
        //0.5 * (hour * 60 + minutes) = 6 * (minutes)
        //30 * hour + 0.5 * minutes = 6 * minutes
        //30 * hour = 5.5 * minutes 

        double minutes = (30 * hour)/5.5;

        return minutes;
    }
};


int main()
{
    double angle = 0;
    double angleMin = 180;
    double angleMax = 0;
    int hourMin = 0;
    int minuteMin = 0;
    int hourMax = 0;
    int minuteMax = 0;
    double alignmentMin = 0;

    for (int i = 0; i < 12; i++)
    {
        for (int j = 0; j < 60; j++)
        {
            angle = Solution::angleClock(i, j);

            if (angle > 0 && angle < angleMin)
            {
                angleMin = angle;
                hourMin = i;
                minuteMin = j;
            }

            if (angle > angleMax)
            {
                angleMax = angle;
                hourMax = i;
                minuteMax = j;
            }
        }
    }

    std::cout << "Min angle:\n";
    std::cout << angleMin;
    std::cout << "\nHour:Minute\n";
    std::cout << hourMin << ":" << minuteMin;

    std::cout << "\nMax angle:\n";
    std::cout << angleMax;
    std::cout << "\nHour:Minute\n";
    std::cout << hourMax << ":" << minuteMax;
    std::cout << "\n\n";

    for (int i = 1; i < 12; i++)
    {
        alignmentMin = Solution::alignmentClock(i);
        std::cout << "\nHour:Minute\n";
        std::cout << i << ":" << alignmentMin;
    }

    std::cout << "\nEnd\n";
}
