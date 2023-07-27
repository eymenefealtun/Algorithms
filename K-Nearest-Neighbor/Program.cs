using System;
using System.Collections.Generic;

class Point
{

    public int val;
    public double x;
    public double y;
    public int? distance;
}

class KNN
{

    static void Main(string[] args)
    {

        Random random = new Random();


        var p = new Point()
        {
            x = random.Next(0, 1000),
            y = random.Next(0, 1000),
            val = 1,
            distance = null
        };

        List<Point> c1 = new List<Point>();


        for (int i = 0; i < 10; i++)
        {
            c1.Add(new Point()
            {
                x = random.Next(0, 1000),
                y = random.Next(0, 1000),
                val = 1,
                distance = null
            });
        }

        List<Point> c2 = new List<Point>();
        for (int i = 0; i < 10; i++)
        {
            c2.Add(new Point()
            {
                x = random.Next(0, 1000),
                y = random.Next(0, 1000),
                val = 2,
                distance = null
            });
        }


        int k = 3;
        ClassifyPoint(p, c1, c2, k);

        Console.ReadLine();

    }

    static void ClassifyPoint(Point testingPoint, List<Point> category1, List<Point> category2, int k)
    {
        int numberOfPoints = category1.Count + category2.Count;

        Point[] allDistances = new Point[numberOfPoints];

        int j = 0;
        for (int i = 0; i < category1.Count; i++)
            allDistances[i] = category1[i];
        for (int i = numberOfPoints - category1.Count; i < numberOfPoints; i++)
        {
            allDistances[i] = category2[j];
            j++;
        }

        for (int i = 0; i < numberOfPoints; i++)
            allDistances[i].distance = (int)Math.Sqrt(Math.Pow(testingPoint.x - allDistances[i].x, 2) + Math.Pow(testingPoint.y - allDistances[i].y, 2));

        var a = 2;
        SortDistance(allDistances);

        Point[] closestDistances = new Point[k];

        for (int i = 0; i < k; i++)
            closestDistances[i] = allDistances[i];

        int isInCategory1 = 0;
        int isInCategory2 = 0;

        for (int i = 0; i < closestDistances.Length; i++)
        {
            if (closestDistances[i].val == 1)
                isInCategory1++;
            else
                isInCategory2++;
        }


        Console.WriteLine($"Testing point: {testingPoint.x},{testingPoint.y}");

        if (isInCategory1 > isInCategory2)
            Console.WriteLine($"The value classified as an unknown point is {1}.");
        else
            Console.WriteLine($"The value classified as an unknown point is {2}.");

        for (int i = 0; i < closestDistances.Length; i++)
            Console.WriteLine("value: " + closestDistances[i].val + "    point: " + closestDistances[i].x + "," + closestDistances[i].y + "    distance: " + closestDistances[i].distance);

    }


    static void SortDistance(Point[] distanceArray)  //Selection Sort
    {
        for (int i = 0; i < distanceArray.Length - 1; i++)
        {
            int minimumIndex = i;

            for (int j = i + 1; j < distanceArray.Length; j++)
                if (distanceArray[minimumIndex].distance > distanceArray[j].distance)
                    minimumIndex = j;


            Point currentNumber = distanceArray[i];

            distanceArray[i] = distanceArray[minimumIndex];
            distanceArray[minimumIndex] = currentNumber;

        }
    }


}