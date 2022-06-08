using System;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        public string Execute(string input)
        {
            if(string.IsNullOrEmpty(input)) return "0:0:N";

            return string.Format("0:{0}:N", input.Length);
        }
    }
}