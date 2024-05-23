using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelowanie_Wieloskalowe___aplikacja
{
    public class Value_controller
    {
        int lower_limit;    // real
        int upper_limit;    // real
        int length;
        bool[] available_values;        // true == available
        int boundary_length_per_side;

        public Value_controller(int lower_limit_, int upper_limit_, int boundery_length_per_side_)
        {
            lower_limit = lower_limit_;
            upper_limit = upper_limit_;
            length = upper_limit_ - lower_limit_;
            available_values = new bool[length]; for (int i = 0; i < length; i++) { available_values[i] = true; }
            boundary_length_per_side = boundery_length_per_side_;
        }

        bool all_locked()
        {
            for(int i=0; i<length; i++)
            {
                if (available_values[i] == true) return false;
            }
            return true;
        }
        public int get_value()
        {
            if (all_locked()) return -1;

            Random random = new Random();   int r;
            do
            {
                r = random.Next(lower_limit, upper_limit + 1);
            }
            while (!available_values[r - lower_limit]);

            int starting_point = r - boundary_length_per_side;  if (starting_point < 0) starting_point = 0;
            int ending_point = r + boundary_length_per_side;    if (ending_point > length) ending_point = length;

            for (int i = starting_point; i < ending_point; i++)
            {
                available_values[i] = false;
            }

            return r;
        }
    }
}
