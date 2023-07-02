/******************************************************************************      SAKARYA ÜNİVERSİTESİ BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ NESNEYE DAYALI PROGRAMLAMA DERSİ
**      ÖDEV NUMARASI......: 1
**      ÖĞRENCİ ADI...............: Hasan Tayfur
**      ÖĞRENCİ NUMARASI.: B211210055
**      DERS GRUBU............: C
**      YOUTUBE LİNKİ... ...: https://youtu.be/b4G-gor8AN0
**
**
****************************************************************************/
namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Operations.PrintIntersection(CheckIntersection.PointRectangle(5, 9, 12, 44, 10, 20), "Point", "rectangle");
            Operations.PrintIntersection(CheckIntersection.PointRectangle(5, 9, 2, 4, 10, 20), "Point", "rectangle");
            Operations.PrintIntersection(CheckIntersection.PointCircle(50, 90, 40, 80, 20), "Point", "circle");
            Operations.PrintIntersection(CheckIntersection.PointCircle(40, 190, 70, 10, 10), "Point", "circle");
            Operations.PrintIntersection(CheckIntersection.RectangleRectangle(20, 30, 50, 50, 10, 20, 60, 100), "Rectangle", "rectangle");
            Operations.PrintIntersection(CheckIntersection.RectangleRectangle(100, 50, 10, 10, 20, 600, 30, 20), "Rectangle", "rectangle");
            Operations.PrintIntersection(CheckIntersection.RectangleCircle(10, 20, 40, 50, 100, 150, 15), "Rectangle", "circle");
            Operations.PrintIntersection(CheckIntersection.CircleCircle(400, 100, 45, 350, 150, 75), "Circle", "circle");
            Operations.PrintIntersection(CheckIntersection.PointSphere(75, 50, 45, 100, 75, 25, 45), "Point", "sphere");
            Operations.PrintIntersection(CheckIntersection.PointSphere(45, 165, 15, 190, 275, 55, 10), "Point", "sphere");
            Operations.PrintIntersection(CheckIntersection.PointQuadrangular(10, 10, 40, 40, 20, 35, 90, 100, 45), "Point", "quadrangular");
            Operations.PrintIntersection(CheckIntersection.PointCylinder(100, 100, 200, 55, 60, 85, 15, 45), "Point", "cylinder");
            Operations.PrintIntersection(CheckIntersection.CylinderCylinder(85, 100, 155, 30, 15, 200, 40, 60, 45, 100), "Cylinder", "cylinder");
            Operations.PrintIntersection(CheckIntersection.SphereSphere(100, 45, 65, 10, 50, 30, 70, 5), "Sphere", "sphere");
            Operations.PrintIntersection(CheckIntersection.SphereCylinder(55, 25, 10, 35, 100, 150, 95, 10, 20), "Sphere", "cylinder");
            Operations.PrintIntersection(CheckIntersection.SurfaceSphere(200, 100, 300, 55, 90, 80, 70, 55, 65, 90), "Surface", "sphere");
            Operations.PrintIntersection(CheckIntersection.SurfaceQuadrangular(30, 45, 10, 50, 90, 110, 45, 15, 20, 85, 120, 40), "Surface", "quadrangular");
            Operations.PrintIntersection(CheckIntersection.SurfaceCylinder(100, 20, 50, 45, 55, 65, 30, 60, 15, 30, 30), "Surface", "cylinder");
            Operations.PrintIntersection(CheckIntersection.SphereQuadrangular(20, 20, 20, 25, 50, 60, 70, 100, 75, 60), "Sphere", "quadrangular");
            Operations.PrintIntersection(CheckIntersection.QuadrangularQuadrangular(100, 250, 300, 40, 60, 90, 200, 300, 25, 60, 100, 25), "Quadrangular", "quadrangular");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            List<Shapes> myList = new List<Shapes>();
            Shapes point2D = new Shapes(30, 60, 0, 0, 0, 0, 0);
            Shapes point3D = new Shapes(335, 250, 0, 4, 0, 0, 0);
            Shapes rectangle = new Shapes(100, 60, 0, 0, 110, 55, 0);
            Shapes cylinder = new Shapes(30, 225, 150, 85, 85, 190, 85);
            Shapes quadrangular = new Shapes(175, 225, 150, 0, 55, 110, 65);
            Shapes sphere = new Shapes(400, 60, 80, 70, 0, 0, 0);
            Shapes circle = new Shapes(270, 60, 0, 50, 0, 0, 0);
            Shapes surface = new Shapes(400, 220, 100, 0, 90, 110, 70);
            Random rnd = new Random();
            point2D.x = rnd.Next(0, 500);
            point2D.y = rnd.Next(0, 250);
            point3D.x = rnd.Next(0, 500);
            point3D.y = rnd.Next(0, 250);
            point3D.z = rnd.Next(0, 50);
            rectangle.x = rnd.Next(0, 500);
            rectangle.y = rnd.Next(0, 250);
            cylinder.x = rnd.Next(0, 500);
            cylinder.y = rnd.Next(0, 250);
            cylinder.z = rnd.Next(0, 50);
            quadrangular.x = rnd.Next(0, 500);
            quadrangular.y = rnd.Next(0, 250);
            quadrangular.z = rnd.Next(0, 50);
            sphere.x = rnd.Next(0, 500);
            sphere.y = rnd.Next(0, 250);
            sphere.z = rnd.Next(0, 50);
            circle.x = rnd.Next(0, 500);
            circle.y = rnd.Next(0, 250);
            surface.x = rnd.Next(0, 500);
            surface.y = rnd.Next(0, 250);
            surface.z = rnd.Next(0, 50);

            myList.Add(point2D);
            myList.Add(rectangle);
            myList.Add(circle);
            myList.Add(sphere);
            myList.Add(cylinder);
            myList.Add(quadrangular);
            myList.Add(point3D);
            myList.Add(surface);
           
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.DeepPink);
            Brush myBrush2 = new SolidBrush(Color.RebeccaPurple);
            Brush myBrush3 = new SolidBrush(Color.BlueViolet);
            Pen myPen = new Pen(Color.DarkRed, 3);

            //Draw point 2D
            g.FillEllipse(myBrush, myList[0].x, myList[0].y, 10, 10);

            //Draw rectangle
            g.FillRectangle(myBrush, myList[1].x, myList[1].y, 90, 110);

            //Draw circle
            g.FillEllipse(myBrush, myList[2].x, myList[2].y, myList[2].radius * 2, myList[2].radius * 2);

            //Draw sphere
            g.FillEllipse(myBrush, myList[3].x, myList[3].y, myList[3].radius * 2, myList[3].radius * 2);
            g.DrawEllipse(myPen, myList[3].x, myList[3].y + myList[3].radius - 12, myList[3].radius * 2, 20);

            //Draw cylinder
            g.FillRectangle(myBrush, myList[4].x, myList[4].y, myList[4].width, myList[4].height);
            g.FillPie(myBrush2, myList[4].x, myList[4].y - 20, myList[4].radius, 40, 180, 180);
            g.DrawArc(myPen, myList[4].x, myList[4].y - 20, myList[4].radius, 40, 0, 180);
            g.DrawArc(myPen, myList[4].x, myList[4].y + 170, myList[4].radius, 40, 180, 180);
            //g.FillPie(myBrush2, myList[4].x, myList[4].y + 90, myList[4].radius, 40, 0, 180);

            //Draw quadrangular
            g.FillRectangle(myBrush, myList[5].x, myList[5].y, myList[5].width, myList[5].height);
            g.DrawLine(myPen, myList[5].x, myList[5].y, myList[5].x + 20, myList[5].y - 20);
            g.DrawLine(myPen, myList[5].x + myList[5].width, myList[5].y, myList[5].x + myList[5].width + 20, myList[5].y - 20);
            g.DrawLine(myPen, myList[5].x + 20, myList[5].y - 20, myList[5].x + myList[5].width + 20, myList[5].y - 20);
            g.DrawLine(myPen, myList[5].x + myList[5].width, myList[5].y + myList[5].height, myList[5].x + myList[5].width + 20, myList[5].y + myList[5].height - 20);
            g.DrawLine(myPen, myList[5].x, myList[5].y + myList[5].height, myList[5].x + 20, myList[5].y + myList[5].height - 20);
            g.DrawLine(myPen, myList[5].x + 20, myList[5].y + myList[5].height - 20, myList[5].x + myList[5].width + 20, myList[5].y + myList[5].height - 20);
            g.DrawLine(myPen, myList[5].x + myList[5].width + 20, myList[5].y + myList[5].height - 20, myList[5].x + myList[5].width + 20, myList[5].y - 20);

            //Draw point 3D
            g.FillEllipse(myBrush3, myList[6].x, myList[6].y, 10, 10);

            //Draw surface
            g.FillRectangle(myBrush3, myList[7].x, myList[7].y, myList[7].width, myList[7].height);

            if (CheckIntersection.PointRectangle(myList[0].x, myList[0].y, myList[1].x, myList[1].y, myList[1].width, myList[1].height) == true) //There is checks shapes that are drawn if there is collision
            {
                pointRectangleResult.Text = "Collision is detected";
            }
            else
            {
                pointRectangleResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.PointCircle(myList[0].x, myList[0].y, myList[2].x, myList[2].y, myList[2].radius) == true) //There is checks shapes that are drawn if there is collision
            {
                pointCircleResult.Text = "Collision is detected";
            }
            else
            {
                pointCircleResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.PointCylinder(myList[6].x, myList[6].y, myList[6].z, myList[4].x, myList[4].y, myList[4].z, myList[4].radius, myList[4].height) == true) //There is checks shapes that are drawn if there is collision
            {
                pointCylinderResult.Text = "Collision is detected";
            }
            else
            {
                pointCylinderResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.PointQuadrangular(myList[6].x, myList[6].y, myList[6].z, myList[5].x, myList[5].y, myList[5].z, myList[5].width, myList[5].height, myList[5].depth) == true) //There is checks shapes that are drawn if there is collision
            {
                pointQuadrangularResult.Text = "Collision is detected";
            }
            else
            {
                pointQuadrangularResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.RectangleCircle(myList[1].x, myList[1].y, myList[1].width, myList[1].height, myList[2].x, myList[2].y, myList[2].radius) == true) //There is checks shapes that are drawn if there is collision
            {
                rectangleCircleResult.Text = "Collision is detected";
            }
            else
            {
                rectangleCircleResult.Text = "Collision is not detected";
            }

            if(CheckIntersection.PointSphere(myList[6].x, myList[6].y, myList[6].z, myList[3].x, myList[3].y, myList[3].z, myList[3].radius) == true) //There is checks shapes that are drawn if there is collision
            {
                pointSphereResult.Text = "Collision is detected";
            }
            else
            {
                pointSphereResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.SphereCylinder(myList[3].x, myList[3].y, myList[3].z, myList[3].radius, myList[4].x, myList[4].y, myList[4].z, myList[4].radius, myList[4].height) == true) //There is checks shapes that are drawn if there is collision
            {
                sphereCylinderResult.Text = "Collision is detected";
            }
            else
            {
                sphereCylinderResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.SurfaceSphere(myList[3].x, myList[3].y, myList[3].z, myList[3].radius, myList[7].x, myList[7].y, myList[7].z, myList[7].width, myList[7].height, myList[7].depth) == true) //There is checks shapes that are drawn if there is collision
            {
                surfaceSphereResult.Text = "Collision is detected";
            }
            else
            {
                surfaceSphereResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.SurfaceCylinder(myList[7].x, myList[7].y, myList[7].z, myList[7].width, myList[7].height, myList[7].depth, myList[4].x, myList[4].y, myList[4].z, myList[4].radius, myList[4].height) == true) //There is checks shapes that are drawn if there is collision
            {
                surfaceCylinderResult.Text = "Collision is detected";
            }
            else
            {
                surfaceCylinderResult.Text = "Collision is not detected";
            }

            if (CheckIntersection.SphereQuadrangular(myList[3].x, myList[3].y, myList[3].z, myList[3].radius, myList[5].x, myList[5].y, myList[5].z, myList[5].width, myList[5].height, myList[5].depth) == true) //There is checks shapes that are drawn if there is collision
            {
                sphereQuadrangularResult.Text = "Collision is detected";
            }
            else
            {
                sphereQuadrangularResult.Text = "Collision is not detected";
            }
        }
    }
    class Shapes
    {
        public Shapes(int x, int y, int z, int radius, int width, int height, int depth)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.radius = radius;
            this.width = width;
            this.depth = depth;
            this.height = height;
        }
        public int x = 0;
        public int y = 0;
        public int z = 0;
        public int radius = 0;
        public int width = 0;
        public int height = 0;
        public int depth = 0;
    }

    static class Operations
    {
        public static float CalcDist2D(float firstX, float firstY, float secondX, float secondY)
        {
            float distanceX = firstX - secondX;
            float distanceY = firstY - secondY;
            float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

            return distance;
        }
        public static float CalcDist3D(float firstX, float firstY, float firstZ, float secondX, float secondY, float secondZ)
        {
            float distanceX = firstX - secondX;
            float distanceY = firstY - secondY;
            float distanceZ = firstZ - secondZ;
            float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);

            return distance;
        }

        public static void PrintIntersection(bool intersection, string firstObject, string secondObject)
        {
            if (intersection == true) //There is checks return if it is true so that if there is collision
            {
                Console.WriteLine("*****************************");
                Console.WriteLine(firstObject + " is collide " + secondObject);
                Console.WriteLine("*****************************");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("*****************************");
                Console.WriteLine(firstObject + " is not collide " + secondObject);
                Console.WriteLine("*****************************");
                Console.WriteLine("");
            }
        }
    }
    static class CheckIntersection
    {
        public static bool PointRectangle(int pointX, int pointY, int rectX, int rectY, int rectWidth, int rectHeight)
        {
            Console.WriteLine("X coordinate of point is " + pointY);
            Console.WriteLine("X coordinate of rectangle is " + rectX);
            Console.WriteLine("y coordinate of rectangle is " + rectY);
            Console.WriteLine("Width of rectangle is " + rectWidth);
            Console.WriteLine("Height of rectangle is " + rectHeight);
            if (pointX < rectX || pointX > rectX + rectWidth) //There is checked if x coordinate of point inside in x parameters of rectangle
            {
                return false;
            }
            if (pointY < rectY || pointY > rectY + rectHeight) //There is checked if y coordinate of point inside in y parameters of rectangle
            {
                return false;
            }
            return true;
        }

        public static bool PointCircle(int pointX, int pointY, int circleX, int circleY, int circleRadius)
        {
            Console.WriteLine("X coordinate of point is " + pointX);
            Console.WriteLine("Y coordinate of point is " + pointY);
            Console.WriteLine("X coordinate of circle is " + circleX);
            Console.WriteLine("Y coordinate of circle is " + circleY);
            Console.WriteLine("Radius of circle is " + circleRadius);
            float distance = Operations.CalcDist2D(pointX, pointY, circleX, circleY);
            if (distance <= circleRadius) //There is checked if point is in circle with radius
            {
                return true;
            }
            return false;
        }

        public static bool RectangleRectangle(int rect1X, int rect1Y, int rect1Width, int rect1Height, int rect2X, int rect2Y, int rect2Width, int rect2Height)
        {
            Console.WriteLine("X coordinate of first rectangle is " + rect1X);
            Console.WriteLine("y coordinate of first rectangle is " + rect1Y);
            Console.WriteLine("Width of first rectangle is " + rect1Width);
            Console.WriteLine("Height of first rectangle is " + rect1Height);
            Console.WriteLine("X coordinate of second rectangle is " + rect2X);
            Console.WriteLine("y coordinate of second rectangle is " + rect2Y);
            Console.WriteLine("Width of second rectangle is " + rect2Width);
            Console.WriteLine("Height of second rectangle is " + rect2Height);
            if (rect1X + rect1Width < rect2X || rect1X > rect2X + rect2Width) //There is checked x parameters is in other rectangle
            {
                return false;
            }

            if (rect1Y + rect1Height < rect2Y || rect1Y > rect2Y + rect2Height) //There is checked y parameters is in other rectangle
            {
                return false;
            }
            return true;
        }

        public static bool RectangleCircle(int rectX, int rectY, int rectWidth, int rectHeight, int circleX, int circleY, int circleRadius)
        {
            Console.WriteLine("X coordinate of rectangle is " + rectX);
            Console.WriteLine("y coordinate of rectangle is " + rectY);
            Console.WriteLine("Width of rectangle is " + rectWidth);
            Console.WriteLine("Height of rectangle is " + rectHeight);
            Console.WriteLine("X coordinate of circle is " + circleX);
            Console.WriteLine("Y coordinate of circle is " + circleY);
            Console.WriteLine("Radius of circle is " + circleRadius);
            float closestX = circleX;
            float closestY = circleY;

            if (circleX < rectX) //If x coordinate of bigger than x coordinate of circle closestX is made x coordinate of rectangle
            {
                closestX = rectX;
            }
            else if (circleX > rectX + rectWidth)
            {
                closestX = rectX + rectWidth;
            }

            if (circleY < rectY) //If x coordinate of bigger than y coordinate of circle closestY is made y coordinate of rectangle
            {
                closestY = rectY;
            }
            else if (circleY > rectY + rectHeight)
            {
                closestY = rectY + rectHeight;
            }

            float distance = Operations.CalcDist2D(rectX, rectY, circleX, circleY);

            if (distance <= circleRadius) //There is checked if distance smaller than radius of circle
            {
                return true;
            }
            return false;
        }

        public static bool CircleCircle(int circle1X, int circle1Y, int circle1Radius, int circle2X, int circle2Y, int circle2Radius)
        {
            Console.WriteLine("X coordinate of first circle is " + circle1X);
            Console.WriteLine("Y coordinate of first circle is " + circle1Y);
            Console.WriteLine("Radius of first circle is " + circle2Radius);
            Console.WriteLine("X coordinate of second circle is " + circle2X);
            Console.WriteLine("Y coordinate of second circle is " + circle2Y);
            Console.WriteLine("Radius of second circle is " + circle2Radius);
            float distance = Operations.CalcDist2D(circle1X, circle1Y, circle2X, circle2Y);
            if (distance <= circle1Radius + circle2Radius) //There is checked distance of two center of circles smaller than sum that theirs radius
            {
                return true;
            }
            return false;
        }

        public static bool PointSphere(int pointX, int pointY, int pointZ, int sphereX, int sphereY, int sphereZ, float sphereRadius)
        {
            Console.WriteLine("X coordinate of point is " + pointX);
            Console.WriteLine("Y coordinate of point is " + pointY);
            Console.WriteLine("X coordinate of sphere is " + sphereX);
            Console.WriteLine("Y coordinate of sphere is " + sphereY);
            Console.WriteLine("Z coordinate of sphere is " + sphereZ);
            Console.WriteLine("Radius of sphere is ", sphereRadius);
            float distance = Operations.CalcDist3D(pointX, pointY, pointZ, sphereX, sphereY, sphereZ);
            if (distance <= sphereRadius) //If distance of two center is smaller than radius of sphere return true
            {
                return true;
            }
            return false;
        }

        public static bool PointQuadrangular(int pointX, int pointY, int pointZ, int quadX, int quadY, int quadZ, int quadWidth, int quadHeight, int quadDepth)
        {
            Console.WriteLine("X coordinate of point is " + pointX);
            Console.WriteLine("Y coordinate of point is " + pointY);
            Console.WriteLine("X coordinate of first quadrangular is " + quadX);
            Console.WriteLine("Y coordinate of first quadrangular is " + quadY);
            Console.WriteLine("Z coordinate of first quadrangular is " + quadZ);
            Console.WriteLine("Width of first quadrangular is " + quadWidth);
            Console.WriteLine("Height of first quadrangular is " + quadHeight);
            Console.WriteLine("Depth of first quadrangular is " + quadDepth);
            if (pointX >= quadX && pointX <= quadX + quadWidth && pointY >= quadY && pointY <= quadY + quadHeight && pointZ >= quadZ && pointZ <= quadZ + quadDepth) //This if checks all coordinates if is in quadrangular
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PointCylinder(int pointX, int pointY, int pointZ, int cylinderCenterX, int cylinderCenterY, int cylinderCenterZ, int cylinderRadius, int cylinderHeight)
        {
            Console.WriteLine("X coordinate of point is " + pointX);
            Console.WriteLine("Y coordinate of point is " + pointY);
            Console.WriteLine("X coordinate of first inder is " + cylinderCenterX);
            Console.WriteLine("Y coordinate of first cylinder is " + cylinderCenterY);
            Console.WriteLine("Z coordinate of first cylinder is " + cylinderCenterZ);
            Console.WriteLine("Height of first cylinder is " + cylinderHeight);
            Console.WriteLine("Radius of first cylinder is " + cylinderRadius);
            float distanceBottom = Operations.CalcDist2D(pointX, pointY, cylinderCenterX, cylinderCenterY);
            float distanceTop = Math.Abs(pointZ - cylinderCenterZ) - (cylinderHeight / 2);
            if (distanceBottom <= cylinderRadius && distanceTop <= 0) //There is checks if bottom length is smaller than radius of cylinder and top length is smaller than 0
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CylinderCylinder(int cylinder1CenterX, int cylinder1CenterY, int cylinder1CenterZ, int cylinder1Radius, int cylinder1Height, int cylinder2CenterX, int cylinder2CenterY, int cylinder2CenterZ, int cylinder2Radius, int cylinder2Height)
        {
            Console.WriteLine("X coordinate of first inder is " + cylinder1CenterX);
            Console.WriteLine("Y coordinate of first cylinder is " + cylinder1CenterY);
            Console.WriteLine("Z coordinate of first cylinder is " + cylinder1CenterZ);
            Console.WriteLine("Height of first cylinder is " + cylinder1Height);
            Console.WriteLine("Radius of first cylinder is " + cylinder1Radius);
            Console.WriteLine("X coordinate of second cylinder is " + cylinder2CenterX);
            Console.WriteLine("Y coordinate of second cylinder is " + cylinder2CenterY);
            Console.WriteLine("Z coordinate of second cylinder is " + cylinder2CenterZ);
            Console.WriteLine("Height of second cylinder is " + cylinder2Height);
            Console.WriteLine("Radius of second cylinder is " + cylinder2Radius);
            float distance = Operations.CalcDist3D(cylinder1CenterX, cylinder1CenterY, cylinder1CenterZ, cylinder2CenterX, cylinder2CenterY, cylinder2CenterZ);
            if (distance <= cylinder1Radius + cylinder2Radius && Math.Abs(cylinder1CenterZ - cylinder2CenterZ) <= (cylinder1Height + cylinder2Height) / 2) //There is checks distance between two cylinder is smaller than sum of theirs radius and their gaps of z coordinate is smaller than sum of theirs heights
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SphereSphere(int sphere1X, int sphere1Y, int sphere1Z, int sphere1Radius, int sphere2X, int sphere2Y, int sphere2Z, int sphere2Radius)
        {
            Console.WriteLine("X coordinate of first sphere is " + sphere1X);
            Console.WriteLine("Y coordinate of first sphere is " + sphere1Y);
            Console.WriteLine("Z coordinate of first spere is " + sphere1Z);
            Console.WriteLine("Radius of first sphere is " + sphere1Radius);
            Console.WriteLine("X coordinate of second sphere is " + sphere2X);
            Console.WriteLine("Y coordinate of second sphere is " + sphere2Y);
            Console.WriteLine("Z coordinate of second sphere is " + sphere2Z);
            Console.WriteLine("Radius of second sphere is " + sphere2Radius);
            float distance = Operations.CalcDist3D(sphere1X, sphere1Y, sphere1Z, sphere2X, sphere2Y, sphere2Z);
            if (distance <= sphere1Radius + sphere2Radius) //Checks if distance is smaller than sum of radius two sphere 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SphereCylinder(int sphereX, int sphereY, int sphereZ, int sphereRadius, int cylinderX, int cylinderY, int cylinderZ, int cylinderRadius, int cylinderHeight)
        {
            Console.WriteLine("X coordinate of sphere is " + sphereX);
            Console.WriteLine("Y coordinate of sphere is " + sphereY);
            Console.WriteLine("Z coordinate of sphere is " + sphereZ);
            Console.WriteLine("Radius of sphere is " + sphereRadius);
            Console.WriteLine("X coordinate of cylinder is " + cylinderX);
            Console.WriteLine("Y coordinate of cylinder is " + cylinderY);
            Console.WriteLine("Z coordinate of cylinder is " + cylinderZ);
            Console.WriteLine("Height of cylinder is " + cylinderHeight);
            Console.WriteLine("Radius of cylinder is " + cylinderRadius);
            float distanceX = Convert.ToSingle(Math.Abs(sphereX - cylinderX));
            float distanceY = Convert.ToSingle(Math.Abs(sphereY - cylinderY));
            float distanceZ = Convert.ToSingle(Math.Abs(sphereZ - cylinderZ));
            if (distanceX < sphereRadius + cylinderRadius && distanceY < cylinderHeight / 2 + sphereRadius && distanceZ < cylinderRadius + sphereRadius) //There is checks radiuses of cylinder and sphere is bigger than distance of x cylinder radius and some checks be made
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SurfaceSphere(int sphereX, int sphereY, int sphereZ, int sphereRadius, int surfaceX, int surfaceY, int surfaceZ, int surfaceNormalX, int surfaceNormalY, int surfaceNormalZ)
        {
            Console.WriteLine("X coordinate of surface is " + surfaceX);
            Console.WriteLine("Y coordinate of surface is " + surfaceY);
            Console.WriteLine("Z coordinate of surface is " + surfaceZ);
            Console.WriteLine("Normal coordinate of X is " + surfaceNormalX);
            Console.WriteLine("Normal coordinate of Y is " + surfaceNormalY);
            Console.WriteLine("Normal coordinate of Z is " + surfaceNormalZ);
            Console.WriteLine("X coordinate of sphere is " + sphereX);
            Console.WriteLine("Y coordinate of sphere is " + sphereY);
            Console.WriteLine("Z coordinate of sphere is " + sphereZ);
            Console.WriteLine("Radius of sphere is " + sphereRadius);
            float distance = Operations.CalcDist3D(sphereX, sphereY, sphereZ, surfaceX, surfaceY, surfaceZ);
            float dot = surfaceNormalX * (sphereX - surfaceX) + surfaceNormalY * (sphereY - surfaceY) + surfaceNormalZ * (sphereZ - surfaceZ);

            if (distance < sphereRadius && dot < 0) //There is checked distance of two center is smaller than radius of sphere and if dot is smaller than 0
            {
                return true;
            }

            return false;
        }

        public static bool SurfaceQuadrangular(int surfaceX, int surfaceY, int surfaceZ, int surfaceWidth, int surfaceHeight, int surfaceDepth, int quadX, int quadY, int quadZ, int quadWidth, int quadHeight, int quadDepth)
        {
            Console.WriteLine("X coordinate of surface is " + surfaceX);
            Console.WriteLine("Y coordinate of surface is " + surfaceY);
            Console.WriteLine("Z coordinate of surface is " + surfaceZ);
            Console.WriteLine("Width of surface is " + surfaceWidth);
            Console.WriteLine("Height of surace is " + surfaceHeight);
            Console.WriteLine("Depth of surace is " + surfaceDepth);
            Console.WriteLine("X coordinate of quadrangular is " + quadX);
            Console.WriteLine("Y coordinate of quadrangular is " + quadY);
            Console.WriteLine("Z coordinate of quadrangular is " + quadZ);
            Console.WriteLine("Width of quadrangular is " + quadWidth);
            Console.WriteLine("Height of quadrangular is " + quadHeight);
            Console.WriteLine("Depth of quadrangular is " + quadDepth);
            double distMinX = quadX - quadWidth / 2.0;
            double distMaxX = quadX + quadWidth / 2.0;
            double distMinY = quadY;
            double distMaxY = quadY + quadHeight;
            double distMinZ = quadZ - quadDepth / 2.0;
            double distMaxZ = quadZ + quadDepth / 2.0;
            double distance = Operations.CalcDist3D(surfaceWidth, surfaceHeight, surfaceDepth, quadWidth, quadDepth, quadHeight);
            if (distance < 0) //There is checks distance between measures two shapes if smaller than zero
            {
                return true;
            }
            if ((distMinX + distMaxX) / 2 < surfaceX) //There is checks average of min and max x coordinate if smaller than x coordinate of surface
            {
                return true;
            }
            if ((distMinY + distMaxY) / 2 < surfaceY) //There is checks average of min and max y coordinate if smaller than y coordinate of surface
            {
                return true;
            }
            if ((distMinY + distMaxY) / 2 < surfaceY) //There is checks average of min and max z coordinate if smaller than z coordinate of surface
            {
                return true;
            }
            return false;
        }

        public static bool SurfaceCylinder(int surfaceX, int surfaceY, int surfaceZ, int surfaceWidth, int surfaceHeight, int surfaceDepth, int cylinderX, int cylinderY, int cylinderZ, int cylinderRadius, int cylinderHeight)
        {
            Console.WriteLine("X coordinate of surface is " + surfaceX);
            Console.WriteLine("Y coordinate of surface is " + surfaceY);
            Console.WriteLine("Z coordinate of surface is " + surfaceZ);
            Console.WriteLine("Width of surface is " + surfaceWidth);
            Console.WriteLine("Height of surace is " + surfaceHeight);
            Console.WriteLine("Depth of surace is " + surfaceDepth);
            Console.WriteLine("X coordinate of cylinder is " + cylinderX);
            Console.WriteLine("Y coordinate of cylinder is " + cylinderY);
            Console.WriteLine("Z coordinate of cylinder is " + cylinderZ);
            Console.WriteLine("Height of cylinder is " + cylinderHeight);
            Console.WriteLine("Radius of cylinder is " + cylinderRadius);
            float surfaceLeft = surfaceX;
            float surfaceRight = surfaceX + surfaceWidth;
            float surfaceTop = surfaceY;
            float surfaceBottom = surfaceY + cylinderHeight;
            float surfaceFront = surfaceZ;
            float surfaceBack = surfaceZ + surfaceDepth;
            if (cylinderX >= surfaceLeft + cylinderRadius && cylinderX <= surfaceRight - cylinderRadius &&
                cylinderY >= surfaceTop + cylinderRadius && cylinderY <= surfaceBottom - cylinderRadius &&
                cylinderZ >= surfaceFront + cylinderHeight / 2.0 && cylinderZ <= surfaceBack - cylinderHeight / 2.0) //There is checks center of cylinder if in surface 
            {
                return true;
            }
            float distanceX = Math.Max(surfaceLeft, Math.Min(cylinderX, surfaceRight));
            float distanceY = Math.Max(surfaceTop, Math.Min(cylinderY, surfaceBottom));
            float distanceZ = Math.Max(surfaceFront, Math.Min(cylinderZ, surfaceBack));
            float distance = Operations.CalcDist3D(cylinderX, cylinderY, cylinderZ, distanceX, distanceY, distanceZ);
            if (distance < cylinderRadius) //There is checked distance between the nearest coordinate between surface and center of cylinder if it is smaller than radius  of cylinder
            {
                return true;
            }
            return false;
        }

        public static bool SphereQuadrangular(int sphereX, int sphereY, int sphereZ, int sphereRadius, int quadX, int quadY, int quadZ, int quadWidth, int quadHeight, int quadDepth)
        {
            Console.WriteLine("X coordinate of quadrangular is " + quadX);
            Console.WriteLine("Y coordinate of quadrangular is " + quadY);
            Console.WriteLine("Z coordinate of quadrangular is " + quadZ);
            Console.WriteLine("Width of quadrangular is " + quadWidth);
            Console.WriteLine("Height of quadrangular is " + quadHeight);
            Console.WriteLine("Depth of quadrangular is " + quadDepth);
            Console.WriteLine("X coordinate of sphere is " + sphereX);
            Console.WriteLine("Y coordinate of sphere is " + sphereY);
            Console.WriteLine("Z coordinate of sphere is " + sphereZ);
            Console.WriteLine("Radius of sphere is " + sphereRadius);
            if (sphereX + sphereRadius >= quadX && sphereX - sphereRadius <= quadX + quadWidth &&
                sphereY + sphereRadius >= quadY && sphereY - sphereRadius <= quadY + quadHeight &&
                sphereZ + sphereRadius >= quadZ && sphereZ - sphereRadius <= quadZ + quadDepth) //There is checked center of sphere if it is in quarangular
            {
                return true;
            }
            float distanceX = Math.Max(quadX, Math.Min(sphereX, quadX + quadWidth));
            float distanceY = Math.Max(quadY, Math.Min(sphereY, quadY + quadHeight));
            float distanceZ = Math.Max(quadZ, Math.Min(sphereZ, quadZ + quadDepth));
            float distance = Operations.CalcDist3D(sphereX, sphereY, sphereZ, distanceX, distanceY, distanceZ);
            if (distance < sphereRadius) //There is checks distance of two shape if it is smaller than radius of sphere
            {
                return true;
            }
            return false;
        }

        public static bool QuadrangularQuadrangular(int quad1X, int quad1Y, int quad1Z, int quad1Width, int quad1Height, int quad1Depth, int quad2X, int quad2Y, int quad2Z, int quad2Width, int quad2Height, int quad2Depth)
        {
            Console.WriteLine("X coordinate of first quadrangular is " + quad1X);
            Console.WriteLine("Y coordinate of first quadrangular is " + quad1Y);
            Console.WriteLine("Z coordinate of first quadrangular is " + quad1Z);
            Console.WriteLine("Width of first quadrangular is " + quad1Width);
            Console.WriteLine("Height of first quadrangular is " + quad1Height);
            Console.WriteLine("Depth of first quadrangular is " + quad1Depth);
            Console.WriteLine("X coordinate of second quadrangular is " + quad2X);
            Console.WriteLine("Y coordinate of second quadrangular is " + quad2Y);
            Console.WriteLine("Z coordinate of second quadrangular is " + quad2Z);
            Console.WriteLine("Width of second quadrangular is " + quad2Width);
            Console.WriteLine("Height of second quadrangular is " + quad2Height);
            Console.WriteLine("Depth of second quadrangular is " + quad2Depth);

            if (quad1X < quad2X + quad2Width && quad1X + quad1Width > quad2X &&
                quad1Y < quad2Y + quad2Height && quad1Y + quad1Height > quad2Y &&
                quad1Z < quad2Z + quad2Depth && quad1Z + quad1Depth > quad2Z) //There is checked any point of first quadrangular if hits the other one
            {
                return true;
            }
            return false;
        }
    }
}