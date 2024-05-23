using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Modelowanie_Wieloskalowe___aplikacja
{
    public class packed_answer
    {
        public int id;
        public int number_of_occurances;
        public Color color;

        public packed_answer(int i, int num, Color c)
        {
            id = i;
            number_of_occurances = num;
            color = c;

        }
    }
    public struct OccurrenceCounter
    {
        private Dictionary<int, (Color color, int count)> occurrences;

        public OccurrenceCounter(IEnumerable<(int id, Color color)> values)
        {
            occurrences = new Dictionary<int, (Color, int)>();

            foreach (var (id, color) in values)
            {
                if (occurrences.ContainsKey(id))
                {
                    var (existingColor, count) = occurrences[id];
                    occurrences[id] = (color, count + 1);
                }
                else
                {
                    occurrences[id] = (color, 1);
                }
            }
        }

        public (int id, Color color, int occurrences) MostCommonValue()
        {
            if (occurrences.Count == 0)
            {
                throw new InvalidOperationException("No values provided.");
            }

            var mostCommonId = 0;
            var mostCommonColor = Color.Empty;
            var highestOccurrences = 0;

            foreach (var pair in occurrences)
            {
                if (pair.Value.Item2 > highestOccurrences)
                {
                    mostCommonId = pair.Key;
                    mostCommonColor = pair.Value.color;
                    highestOccurrences = pair.Value.Item2;
                }
            }

            return (mostCommonId, mostCommonColor, highestOccurrences);
        }

        public int GetOccurrences(int id)
        {
            return occurrences.ContainsKey(id) ? occurrences[id].Item2 : 0;
        }
    }
    public class Variables
    {
        public int stats_coverage;
        

        public int real_tab_size_x;
        public int real_tab_size_y;
        public int real_tab_size_z;
        public int real_tab_size_all;

        public int pictureBox_size_x;
        public int pictureBox_size_y;
        public int scaling;
        public int scaling_x;
        public int scaling_y;
        public int default_id = 0;
        
        public Color default_background_color;
        public Color edge_color;
        
        public Value_controller color_r;
        public Value_controller color_g;
        public Value_controller color_b;       // about 50 colors max

        public bool value_apply = true;
        public bool value_modyfie = false;        
        public bool ALL_CONTROLLES_STATUS = true;
        public bool clicked_fully_handled = true;
        public bool edge_on = false;
        public bool energy_on = false;        

        public int free_id = 0;
        public int padding_homogeneous = 0;
        public List<List<coord>> neighbourhood_list;
        public List<coord> MC_energy_pattern;
        public List<coord_3D> MC_energy_pattern_3D;
        public Thread t;
        public readonly object sync_FILL_FRAME = new object();
        public readonly object sync_REFRESH = new object();

        public string default_time_text = "   m      s   -   iter. ";

        public int iteration_number = 0;
    }


    public class id_and_color
    {
        public int id;
        public Color color;

        public id_and_color(int i, Color c)
        {
            id = i;
            color = c;
        }
    }
    public class id_and_Energy
    {
        public int id;
        public int Energy;
        public Color color;

        public id_and_Energy(int i, Color c)
        {
            id = i;
            Energy = 0;
            color = c;
        }
    }
    public class coord
    {
        public int x;
        public int y;

        public coord(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
    public class coord_3D
    {
        public int x;
        public int y;
        public int z;

        public coord_3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
    public class controller_apply_modyfie
    {
        bool apply_modyfie;

        public bool status()
        {
            return apply_modyfie;
        }

        public void set_apply()
        {
            apply_modyfie = true;
        }
        public void set_modyfie()
        {
            apply_modyfie = false;
        }
    }
    public class controller_generation
    {
        bool start_stop;

        public controller_generation()
        {
            start_stop = false;            
        }
        public void start_generation()
        {
            start_stop = true;            
        }
        public void stop_generation()
        {
            start_stop = false;            
        }
        public bool status()
        {
            return start_stop;
        }
        public void button_clicked()
        {
            if (status())
            {
                stop_generation();
            }
            else
            {
                start_generation();
            }
        }
    }
    public class Cell
    {
        int unique_id;
        public Color visual_representation;
        bool edge;
        bool grain_counted;
        bool energy;
        int energy_level_from_last_calculation;
        

        public Cell(int i, Color c)
        {
            unique_id = i;
            visual_representation = c;
            edge = false;
            grain_counted = false;
            energy = false;

            energy_level_from_last_calculation = 0;
        }        
        public int get_id()
        {
            return unique_id;
        }
        public void set_id(int id)
        {
            unique_id = id;
        }
        public Color get_color()
        {
            return visual_representation;
        }
        public void set_color(Color color)
        {
            visual_representation = color;
        }
        public Color get_energy_color()
        {
            if (energy_level_from_last_calculation == 0) return Color.Black;

            double percent = ((double) energy_level_from_last_calculation) / 8;

            Color low_energy, mid_energy, high_energy;            if (false)
            {
                /*
                low_energy = Color.Blue;
                mid_energy = Color.Magenta;
                high_energy = Color.Red;

                low_energy = Color.Black;
                mid_energy = Color.GreenYellow;
                high_energy = Color.Red;

                low_energy = Color.Black;
                mid_energy = Color.GreenYellow;
                high_energy = Color.Yellow;

                low_energy = Color.Blue;
                high_energy = Color.Red;
                */

                /*if (percent < 0.5)
               {
                   r = (int)(low_energy.R * (1 - percent) + mid_energy.R * (percent));
                   g = (int)(low_energy.G * (1 - percent) + mid_energy.G * (percent));
                   b = (int)(low_energy.B * (1 - percent) + mid_energy.B * (percent));
               }
               else
               {
                   r = (int)(mid_energy.R * (1 - percent) + high_energy.R * (percent));
                   g = (int)(mid_energy.G * (1 - percent) + high_energy.G * (percent));
                   b = (int)(mid_energy.B * (1 - percent) + high_energy.B * (percent));
               }*/
            }

            low_energy = Color.Green;
            high_energy = Color.Yellow;

            int r, g, b, a = 255;

            r = (int)(low_energy.R * (1 - percent) + high_energy.R * (percent));
            g = (int)(low_energy.G * (1 - percent) + high_energy.G * (percent));
            b = (int)(low_energy.B * (1 - percent) + high_energy.B * (percent));

            return Color.FromArgb(a, r, g, b);
        }
        public void set_energy_level(int e)
        {
            energy_level_from_last_calculation = e;
        }


        public void mark_as_edge()
        {
            edge = true;
        }
        public void no_longer_edge()
        {
            edge = false;
        }
        public bool status_edge()
        {
            return edge;
        }
        public bool status_counted()
        {
            return grain_counted;
        }
        public void mark_as_counted()
        {
            grain_counted = true;
        }
        public void reset_counted_state()
        {
            grain_counted = false;
        }
    }
}
