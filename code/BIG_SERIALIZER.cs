using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelowanie_Wieloskalowe___aplikacja
{
    public class BIG_SERIALIZER
    {
        public int matrix_widht;
        public int matrix_height;
        public int matrix_depth;

        public int seed_adder_1;
        public int seed_adder_2;

        public int homogeneous_row;
        public int homogeneous_col;

        public double kT;

        public int MC_ids;
        public int slice_visualized;

        public string radio_button_neighbourhood;
        public string radio_button_boundary_conditions;
        public string radio_button_iter_method;
        public string radio_button_save_to;

        public bool checkbox_grains;
        public bool checkbox_coverage;
        public bool checkbox_system_energy;
    }
}
