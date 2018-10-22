using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRobotExample.Model;


namespace MarsRobotExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console

            List<Robot> robots = new List<Robot>();

            #region MaxMinLocation

            Console.WriteLine("Sol alt köşe koordinatı (0,0) olarak kabul edilerek , Mars’taki yüzeyin sağ üst köşesinin koordinatı Giriniz ?");
            Location maxLocation = new Location();
            string loc = ResponseType.InnerTrim(Console.ReadLine());
            maxLocation.xCordinate = int.Parse(loc[0].ToString());
            maxLocation.yCordinate = int.Parse(loc[1].ToString());
            Location minLocation = new Location();
            minLocation.xCordinate = 0;
            minLocation.yCordinate = 0;

            #endregion

            #region Robot1Console

            Console.WriteLine("Robot1'in ilK Konumunu ve Yönünü Birer boşlukla belirtiniz");
            string rbt1Location = ResponseType.InnerTrim(Console.ReadLine());
            Robot rbt1 = new Robot();
            rbt1.Name = "Robot1";
            rbt1.xCordinate = int.Parse(rbt1Location[0].ToString());
            rbt1.yCordinate = int.Parse(rbt1Location[1].ToString());
            rbt1.Direction = rbt1Location[2].ToString();
            Console.WriteLine("Robot1 in komutları 'L','M','R' harfleri kullanarak oluşturunuz/n");
            rbt1.Movement = ResponseType.InnerTrim(Console.ReadLine()).ToCharArray();
            robots.Add(rbt1);

            #endregion

            #region Robot2Console

            Console.WriteLine("Robot2'in ilK Konumunu ve Yönünü Birer boşlukla belirtiniz");
            string rbt2Location = ResponseType.InnerTrim(Console.ReadLine());
            Robot rbt2 = new Robot();
            rbt2.Name = "Robot2";
            rbt2.xCordinate = int.Parse(rbt2Location[0].ToString());
            rbt2.yCordinate = int.Parse(rbt2Location[1].ToString());
            rbt2.Direction = rbt2Location[2].ToString();
            Console.WriteLine("Robot2 nin komutları 'L','M','R' harfleri kullanarak oluşturunuz");
            rbt2.Movement = ResponseType.InnerTrim(Console.ReadLine()).ToCharArray();
            robots.Add(rbt2);

            #endregion

            #endregion

            foreach (var item in robots)
            {

                foreach (var itemRbt in item.Movement)
                {
                    if (itemRbt.ToString() != "M")
                    {
                        item.Direction = ResponseType.FinDirection(item.Direction, itemRbt.ToString());
                    }
                    else
                    {
                        var hareketResult = ResponseType.RobotMovement(item.Direction, item.xCordinate, item.yCordinate);
                        item.xCordinate = hareketResult.xCordinate;
                        item.yCordinate = hareketResult.yCordinate;

                    }
                }
            }

            Console.WriteLine("\nRobotların Son Konumları\n");

            foreach (var item in robots)
            {
                if (item.xCordinate > maxLocation.xCordinate)
                {
                    item.xCordinate = maxLocation.xCordinate;
                }

                if (item.xCordinate < minLocation.xCordinate)
                {
                    item.xCordinate = minLocation.xCordinate;
                }


                if (item.yCordinate > maxLocation.yCordinate)
                {
                    item.yCordinate = maxLocation.xCordinate;
                }

                if (item.yCordinate < minLocation.yCordinate)
                {
                    item.yCordinate = minLocation.yCordinate;
                }
                Console.WriteLine($"{item.Name}: {item.xCordinate} {item.yCordinate} {item.Direction}");
             
            }

            Console.ReadKey();

        }
    }
}
