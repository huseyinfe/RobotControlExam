using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotExample.Model
{
    public static class ResponseType
    {
        public static string InnerTrim(string input)
        {
            return input.Trim().Replace(" ", string.Empty).ToUpper();
        }
        public static string FinDirection(string direction, string command)
        {
            string result = "";

            switch (direction)
            {
                case "N":
                    if (command == "L")
                    {
                        result = "W";
                    }
                    else
                    {
                        result = "E";
                    }
                    break;
                case "W":
                    if (command == "L")
                    {
                        result = "S";
                    }
                    else
                    {
                        result = "N";
                    }
                    break;
                case "S":
                    if (command == "L")
                    {
                        result = "E";
                    }
                    else
                    {
                        result = "W";
                    }
                    break;
                case "E":
                    if (command == "L")
                    {
                        result = "N";
                    }
                    else
                    {
                        result = "S";
                    }
                    break;
                default:
                    result = "N";
                    break;
            }
            return result;
        }

        public static Robot RobotMovement(string direction, int xCordinate, int yCordinate)
        {
            Robot rbtMove = new Robot();
            rbtMove.xCordinate = xCordinate;
            rbtMove.yCordinate = yCordinate;
            rbtMove.Direction = direction;
            switch (direction)
            {
                case "W":
                    rbtMove.xCordinate = xCordinate - 1;
                    break;
                case "E":
                    rbtMove.xCordinate = xCordinate + 1;
                    break;
                case "N":
                    rbtMove.yCordinate = yCordinate + 1;
                    break;
                case "S":
                    rbtMove.yCordinate = yCordinate - 1;
                    break;
            }
            return rbtMove;
        }

    }
}
