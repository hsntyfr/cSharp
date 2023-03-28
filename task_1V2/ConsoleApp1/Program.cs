using System;

namespace ConsoleApp1
{
    static class Operations
    {
        private static int _selection = 0;
        public static int Start()
        {
            Console.WriteLine("Please select process you want");
            Console.WriteLine("To check intersection between point and rectangle press              1");
            Console.WriteLine("To check intersection between point and circle press                 2");
            Console.WriteLine("To check intersection between rectangle and rectangle press          3");
            Console.WriteLine("To check intersection between rectangle and circle press             4");
            Console.WriteLine("To check intersection between circle and circle press                5");
            Console.WriteLine("To check intersection between point and sphere press                 6");
            Console.WriteLine("To check intersection between point and quadrangular press           7");
            Console.WriteLine("To check intersection between point and cylinder press               8");
            Console.WriteLine("To check intersection between cylinder and cylinder press            9");
            Console.WriteLine("To check intersection between sphere and sphere press                10");
            Console.WriteLine("To check intersection between sphere and cylinder press              11");
            Console.WriteLine("To check intersection between surface and sphere press               12");
            Console.WriteLine("To check intersection between surface and quadrangular press         13");
            Console.WriteLine("To check intersection between surface and cylinder press             14");
            Console.WriteLine("To check intersection between sphere and quadrangular press          15");
            Console.WriteLine("To check intersection between quadrangular and quadrangular press    16");
            Console.WriteLine();
            do
            {
                if (_selection != 0)
                {
                    Console.WriteLine("Your selection is wrong. Number is have to between 1-16");
                    Console.WriteLine();
                }
                Console.Write("Selection is ");
                _selection = Convert.ToInt16(Console.ReadLine());
            } while (_selection > 16 || _selection < 0);

            return _selection;
        }

        public static int TakeValue(string kind, char axis, string order = "", string location = "")
        {
            int value = 0;
            if (location != "")
            {
                location += " corner of ";
            }
            if (order != "")
            {
                order += " ";
            }
            Console.WriteLine("Enter {0} for the {1}{2}{3}", axis, location, order, kind);
            Console.Write("{0}: ", axis);
            value = Convert.ToInt16(Console.ReadLine());
            return value;
        }
        /*public static int TakeX(string shape)
        {
            int x = 0;
            Console.WriteLine("Enter x coordinate for {0}", shape);
            x = Convert.ToInt16(Console.ReadLine());
            return x;
        }*/
        /*public static int TakeY(string shape)
        {
            int y = 0;
            Console.WriteLine("Enter y coordinate for {0}", shape);
            y = Convert.ToInt16(Console.ReadLine());
            return y;
        }*/
        /*public static int TakeZ(string shape)
        {
            int z = 0;
            Console.WriteLine("Enter z coordinate for {0}", shape);
            z = Convert.ToInt16(Console.ReadLine());
            return z;
        }*/
        public static int TakeR(string shape, string order = "")
        {
            int r = 0;
            if (order != "")
            {
                order += " ";
            }
            Console.WriteLine("Enter radius for the {0}{1}", order, shape);
            Console.Write("Radius: ");
            r = Convert.ToInt16(Console.ReadLine());
            return r;
        }
    }

    static class CheckIntersection
    {
        public static void PointSquare() //case1
        {
            int pointX = Operations.TakeValue("point", 'x');
            int pointY = Operations.TakeValue("point", 'y');
            int squareXLeftTop = Operations.TakeValue("square", 'x', "left top");
            int squareYLeftTop = Operations.TakeValue("square", 'y', "left top");
            int squareXLeftBottom = Operations.TakeValue("square", 'x', "left bottom");
            int squareYLeftBottom = Operations.TakeValue("square", 'y', "left bottom");
            int squareXRightTop = Operations.TakeValue("square", 'x', "right top");
            int squareYRightTop = Operations.TakeValue("square", 'y', "right top");
            int squareXRightBottom = Operations.TakeValue("square", 'x', "right bottom");
            int squareYRightBottom = Operations.TakeValue("square", 'y', "right bottom");
            
        }
        public static void PointCircle() //case2
        {
            float distance = 0;
            int pointX = Operations.TakeValue("point", 'x');
            int pointY = Operations.TakeValue("point", 'y');
            int circleX = Operations.TakeValue("circle", 'x');
            int circleY = Operations.TakeValue("circle", 'y');
            int circleR = Operations.TakeR("circle");
            distance = Convert.ToSingle(Math.Sqrt(Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2)));
            if (distance < circleR)
            {
                Console.WriteLine("bu duzeltilecek");
            }
        }
        public static void RectangleRectangle() //case3
        {
            int firstRectangleLeftX = Operations.TakeValue("rectangle", 'x', "first", "left");
            int firstRectangleLeftY = Operations.TakeValue("rectangle", 'y', "first", "left");
            int firstRectangleRightX = Operations.TakeValue("rectangle", 'x', "first", "right");
            int firstRectangleRightY = Operations.TakeValue("rectangle", 'y', "first", "right");
            int secondRectangleLeftX = Operations.TakeValue("rectangle", 'x', "second", "left");
            int secondRectangleLeftY = Operations.TakeValue("rectangle", 'y', "second", "left");
            int secondRectangleRightX = Operations.TakeValue("rectangle", 'x', "second", "right");
            int secondRectangleRightY = Operations.TakeValue("rectangle", 'y', "second", "right");
            float firstRectangleCenterX;
            // bottom eklenecek
        }
        public static void RectangleCircle() //case4
        {
            int rectangleLeftX = Operations.TakeValue("rectangle", 'x', location: "left");
            int rectangleLeftY = Operations.TakeValue("rectangle", 'y', location: "left");
            int rectangleRightX = Operations.TakeValue("rectangle", 'x', location: "right");
            int rectangleRightY = Operations.TakeValue("rectangle", 'y', location: "right");
            int circleX = Operations.TakeValue("circle", 'x');
            int circleY = Operations.TakeValue("circle", 'y');
            int circleR = Operations.TakeR("circle");
            
        }
        public static void CircleCircle() //case5
        {
            int firstCircleX = Operations.TakeValue("circle", 'x', "first");
            int firstCircleY = Operations.TakeValue("circle", 'y', "first");
            int firstCircleR = Operations.TakeR("circle", "first");
            int secondCircleX = Operations.TakeValue("circle", 'x', "second");
            int secondCircleY = Operations.TakeValue("circle", 'y', "second");
            int secondCircleR = Operations.TakeR("circle", "second");
        }
        public static void PointSphere() //case6
        {
            int pointX = Operations.TakeValue("point", 'x');
            int pointY = Operations.TakeValue("point", 'y');
            int pointZ = Operations.TakeValue("point", 'z');
            int sphereX = Operations.TakeValue("sphere", 'x');
            int sphereY = Operations.TakeValue("sphere", 'y');
            int sphereZ = Operations.TakeValue("sphere", 'z');
            int sphereR = Operations.TakeR("sphere");
            float distance = Convert.ToSingle(Math.Sqrt(Math.Pow((pointX - sphereX), 2) + Math.Pow((pointY - sphereY), 2) + Math.Pow((pointZ - sphereZ), 2)));
            if (distance < sphereR)
            {
                /////
            }
        }
        public static void PointQuadrangular() //case7
        {
            int pointX = Operations.TakeValue("point", 'x');
            int pointY = Operations.TakeValue("point", 'y');
            int quadrangularLeftX = Operations.TakeValue("quadrangular", 'x', location: "left");
            int quadrangularLeftY = Operations.TakeValue("quadrangular", 'y', location: "left");
            int quadrangularRightX = Operations.TakeValue("quadrangular", 'y', location: "right");
            int quadrangularRightY = Operations.TakeValue("quadrangular", 'y', location: "right");
            int quadrangularZ = Operations.TakeValue("quadrangular", 'z');
        }
        public static void PointCylinder() //case8
        {
            int pointX = Operations.TakeValue("point", 'x');
            int pointY = Operations.TakeValue("point", 'y');
        }
        public static void CylinderCylinder() //case9
        {
            
        }
        public static void SphereSphere() //case10
        {
            int firstSphereX = Operations.TakeValue("sphere", 'x', "first");
            int firstSphereY = Operations.TakeValue("sphere", 'y', "first");
            int firstSphereZ = Operations.TakeR("sphere", "first");
            int secondSphereX = Operations.TakeValue("sphere", 'x', "second");
            int secondSphereY = Operations.TakeValue("sphere", 'y', "second");
            int secondSphereZ = Operations.TakeR("sphere", "second");
        }
        public static void SphereCylinder() //case11
        {
            int sphereX = Operations.TakeValue("sphere", 'x');
            int sphereY = Operations.TakeValue("sphere", 'y');
            int sphereZ = Operations.TakeR("sphere");

        }
        public static void SurfaceSphere() //case12
        {
            ////////
            int sphereX = Operations.TakeValue("sphere", 'x');
            int sphereY = Operations.TakeValue("sphere", 'y');
            int sphereZ = Operations.TakeR("sphere");
        }
        public static void SurfaceQuadrangular() //case13
        {
            /////////
            int quadrangularLeftX = Operations.TakeValue("quadrangular", 'x', location: "left");
            int quadrangularLeftY = Operations.TakeValue("quadrangular", 'y', location: "left");
            int quadrangularRightX = Operations.TakeValue("quadrangular", 'y', location: "right");
            int quadrangularRightY = Operations.TakeValue("quadrangular", 'y', location: "right");
            int quadrangularZ = Operations.TakeValue("quadrangular", 'z');
        }
        public static void SurfaceCylinder() //case14
        {
            
        }
        public static void SphereQuadrangular() //case15
        {
            int sphereX = Operations.TakeValue("sphere", 'x');
            int sphereY = Operations.TakeValue("sphere", 'y');
            int sphereZ = Operations.TakeR("sphere");
            int quadrangularLeftX = Operations.TakeValue("quadrangular", 'x', location: "left");
            int quadrangularLeftY = Operations.TakeValue("quadrangular", 'y', location: "left");
            int quadrangularRightX = Operations.TakeValue("quadrangular", 'y', location: "right");
            int quadrangularRightY = Operations.TakeValue("quadrangular", 'y', location: "right");
            int quadrangularZ = Operations.TakeValue("quadrangular", 'z');
        }
        public static void QuadrangularQuadrangular() //case16
        {
            int firstQuadrangularLeftX = Operations.TakeValue("quadrangular", 'x', "first", "left");
            int firstQuadrangularLeftY = Operations.TakeValue("quadrangular", 'y', "first", "left");
            int firstQuadrangularRightX = Operations.TakeValue("quadrangular", 'x', "first", "right");
            int firstQuadrangularRightY = Operations.TakeValue("quadrangular", 'y', "first", "right");
            int firstQuadrangularZ = Operations.TakeValue("quadrangular", 'z', order: "first");
            int secondQuadrangularLeftX = Operations.TakeValue("quadrangular", 'x', "second", "left");
            int secondQuadrangularLeftY = Operations.TakeValue("quadrangular", 'y', "second", "left");
            int secondQuadrangularRightX = Operations.TakeValue("quadrangular", 'x', "second", "right");
            int secondQuadrangularRightY = Operations.TakeValue("quadrangular", 'y', "second", "right");
            int secondQuadrangularZ = Operations.TakeValue("quadrangular", 'z', order: "second");
        }
    }
    class Program
    {
        static void Main()
        {
            int selection = Operations.Start();
            switch (selection)
            {
                case 1: //point and square
                    CheckIntersection.PointSquare();
                    break;
                
                case 2: //point and circle
                    CheckIntersection.PointCircle();
                    break;
                
                case 3: //rectangle and rectangle 
                    CheckIntersection.RectangleRectangle();
                    break;
                
                case 4: //rectangle and circle
                    CheckIntersection.RectangleCircle();
                    break;
                
                case 5: //circle and circle 
                    CheckIntersection.CircleCircle();
                    break;
                
                case 6: //point and sphere 
                    CheckIntersection.PointSphere();
                    break;
                
                case 7: //point and quadrangular 
                    CheckIntersection.PointQuadrangular();
                    break;
                
                case 8: //point and cylinder 
                    CheckIntersection.PointCylinder();
                    break;
                
                case 9: //cylinder and cylinder 
                    CheckIntersection.CylinderCylinder();
                    break;
                
                case 10: //sphere and sphere 
                    CheckIntersection.SphereSphere();
                    break;
                
                case 11: //sphere and cylinder 
                    CheckIntersection.SphereCylinder();
                    break;
                
                case 12: //surface and sphere 
                    CheckIntersection.SurfaceSphere();
                    break;
                
                case 13: //surface and quadrangular 
                    CheckIntersection.SurfaceQuadrangular();
                    break;
                
                case 14: //surface and cylinder 
                    CheckIntersection.SurfaceCylinder();
                    break;
                
                case 15: //sphere and quadrangular 
                    CheckIntersection.SphereQuadrangular();
                    break;
                
                case 16: //quadrangular and quadrangular 
                    CheckIntersection.QuadrangularQuadrangular();
                    break;
            }
        }
    }
}