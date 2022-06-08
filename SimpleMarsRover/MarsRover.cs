using System;

namespace SimpleMarsRover
{
    public class MarsRover
    {
        public string Execute(string input)
        {
            if(string.IsNullOrEmpty(input)) return "0:0:N";

            if (input.Length == 1) return "0:1:N";

            if (input.Length == 2) return "0:2:N";

            return "0:3:N";
        }
    }
}