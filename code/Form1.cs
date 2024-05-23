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
using System.Timers;

namespace Modelowanie_Wieloskalowe___aplikacja
{
    public partial class Form1 : Form
    {
        XmlSerializer serializer = new XmlSerializer(typeof(BIG_SERIALIZER));        BIG_SERIALIZER BIG_serializer = new BIG_SERIALIZER();        const string path_serializer = "config.xml";
                
        const string dir_generated_output = @"generations\";



        // CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();

            setup_dir_structure();
            decodeAndApplySerialization();

            constructor_setup();
        }

        // FUNCTION TO BE CALLED AT START AND END
        private void setup_dir_structure()
        {
            make_sure_dir_exists(dir_generated_output);
        }
        private void decodeAndApplySerialization()
        {
            if (!File.Exists(path_serializer)) return;

            using (FileStream fileStream = new FileStream(path_serializer, FileMode.Open))
                BIG_serializer = (BIG_SERIALIZER)serializer.Deserialize(fileStream);

            applySerailization();
        }
        private void save_window_position()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Form_Location = RestoreBounds.Location;
                Properties.Settings.Default.Form_Size = RestoreBounds.Size;
                Properties.Settings.Default.Form_Maximised = true;
                Properties.Settings.Default.Form_Minimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Form_Location = Location;
                Properties.Settings.Default.Form_Size = Size;
                Properties.Settings.Default.Form_Maximised = false;
                Properties.Settings.Default.Form_Minimised = false;
            }
            else
            {
                Properties.Settings.Default.Form_Location = RestoreBounds.Location;
                Properties.Settings.Default.Form_Size = RestoreBounds.Size;
                Properties.Settings.Default.Form_Maximised = false;
                Properties.Settings.Default.Form_Minimised = true;
            }
            Properties.Settings.Default.Save();
        }
        private void apply_window_position(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Form_Maximised)
            {
                Location = Properties.Settings.Default.Form_Location;
                WindowState = FormWindowState.Maximized;
                Size = Properties.Settings.Default.Form_Size;
            }
            else if (Properties.Settings.Default.Form_Minimised)
            {
                Location = Properties.Settings.Default.Form_Location;
                WindowState = FormWindowState.Minimized;
                Size = Properties.Settings.Default.Form_Size;
            }
            else
            {
                Location = Properties.Settings.Default.Form_Location;
                Size = Properties.Settings.Default.Form_Size;
            }
        }        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_window_position();

            saveStateToSerialize();
            using (FileStream fileStream = new FileStream(path_serializer, FileMode.Create))
                serializer.Serialize(fileStream, BIG_serializer);
        }

        // APPLYING AND SAVING TO BIG_SERIALIZER
        void applySerailization()
        {
            apply_textBox(ref textBox_matrix_width, ref BIG_serializer.matrix_widht);
            apply_textBox(ref textBox_matrix_height, ref BIG_serializer.matrix_height);
            apply_textBox(ref textBox_matrix_depth, ref BIG_serializer.matrix_depth);

            apply_textBox(ref textBox_seed_number_1, ref BIG_serializer.seed_adder_1);
            apply_textBox(ref textBox_seed_number_2, ref BIG_serializer.seed_adder_2);

            apply_textBox(ref textBox_homogeneous_row, ref BIG_serializer.homogeneous_row);
            apply_textBox(ref textBox_homogeneous_col, ref BIG_serializer.homogeneous_col);

            apply_textBox(ref textBox_MC_unique_ids, ref BIG_serializer.MC_ids);
            apply_textBox(ref textBox_kT_value, ref BIG_serializer.kT);
            apply_textBox(ref textBox_slice_number, ref BIG_serializer.slice_visualized);

            apply_radio_buttons();


            apply_checkbox(ref checkBox_Coverage_percent, ref BIG_serializer.checkbox_coverage);
            apply_checkbox(ref checkBox_how_many_grains, ref BIG_serializer.checkbox_grains);
            apply_checkbox(ref checkBox_whole_energy, ref BIG_serializer.checkbox_system_energy);
        }
        void saveStateToSerialize()
        {
            serialize_textBox(ref textBox_matrix_width, ref BIG_serializer.matrix_widht);
            serialize_textBox(ref textBox_matrix_height, ref BIG_serializer.matrix_height);
            serialize_textBox(ref textBox_matrix_depth, ref BIG_serializer.matrix_depth);

            serialize_textBox(ref textBox_seed_number_1, ref BIG_serializer.seed_adder_1);
            serialize_textBox(ref textBox_seed_number_2, ref BIG_serializer.seed_adder_2);

            serialize_textBox(ref textBox_homogeneous_row, ref BIG_serializer.homogeneous_row);
            serialize_textBox(ref textBox_homogeneous_col, ref BIG_serializer.homogeneous_col);

            serialize_textBox(ref textBox_MC_unique_ids, ref BIG_serializer.MC_ids);
            serialize_textBox(ref textBox_kT_value, ref BIG_serializer.kT);
            serialize_textBox(ref textBox_slice_number, ref BIG_serializer.slice_visualized);

            serialize_radio_buttons();


            serialize_checkbox(ref checkBox_Coverage_percent, ref BIG_serializer.checkbox_coverage);
            serialize_checkbox(ref checkBox_how_many_grains, ref BIG_serializer.checkbox_grains);
            serialize_checkbox(ref checkBox_whole_energy, ref BIG_serializer.checkbox_system_energy);
        }


        // SUB
        void apply_radio_buttons()
        {
            string current = BIG_serializer.radio_button_neighbourhood;
            if (current != "")
            {
                if (current == "radioButton_moore") radioButton_moore.Checked = true;
                else if (current == "radioButton_von_nueman") radioButton_von_nueman.Checked = true;
                else if (current == "radioButton_penta") radioButton_penta.Checked = true;
                else if (current == "radioButton_hexa") radioButton_hexa.Checked = true;
            }

            current = BIG_serializer.radio_button_boundary_conditions;
            if (current != "")
            {
                if (current == "radioButton_periodic") radioButton_periodic.Checked = true;
                else if (current == "radioButton_hard_stop") radioButton_hard_stop.Checked = true;
            }
            
            current = BIG_serializer.radio_button_iter_method;
            if (current != "")
            {
                if (current == "radioButton_type_of_iter_CA") radioButton_type_of_iter_CA.Checked = true;
                else if (current == "radioButton_type_of_iter_MC") radioButton_type_of_iter_MC.Checked = true;
            }

            current = BIG_serializer.radio_button_save_to;
            if (current != "")
            {
                if (current == "radioButton_save_to_png") radioButton_save_to_png.Checked = true;
                else if (current == "radioButton_save_to_ovito") radioButton_save_to_ovito.Checked = true;
            }
        }
        void serialize_radio_buttons()
        {
            ref string current = ref BIG_serializer.radio_button_neighbourhood;
            if (radioButton_moore.Checked) current = "radioButton_moore";
            else if (radioButton_von_nueman.Checked) current = "radioButton_von_nueman";
            else if (radioButton_penta.Checked) current = "radioButton_penta";
            else if (radioButton_hexa.Checked) current = "radioButton_hexa";
            else current = "";

            current = ref BIG_serializer.radio_button_boundary_conditions;
            if (radioButton_periodic.Checked) current = "radioButton_periodic";
            else if (radioButton_hard_stop.Checked) current = "radioButton_hard_stop";
            else current = "";

            current = ref BIG_serializer.radio_button_iter_method;
            if (radioButton_type_of_iter_CA.Checked) current = "radioButton_type_of_iter_CA";
            else if (radioButton_type_of_iter_MC.Checked) current = "radioButton_type_of_iter_MC";
            else current = "";

            current = ref BIG_serializer.radio_button_save_to;
            if (radioButton_save_to_png.Checked) current = "radioButton_save_to_png";
            else if (radioButton_save_to_ovito.Checked) current = "radioButton_save_to_ovito";
            else current = "";
        }


        // SUPPORT
        void apply_textBox<T>(ref TextBox textBox, ref T input)
        {
            textBox.Text = input.ToString();
        }
        void serialize_textBox<T>(ref TextBox textBox, ref T save_to)
        {
            try
            {
                save_to = (T)Convert.ChangeType(textBox.Text, typeof(T));
            }
            catch (FormatException)
            {
                save_to = default(T);
            }
        }
        void apply_checkbox(ref CheckBox checkBox, ref bool input)
        {
            checkBox.Checked = input;
        }
        void serialize_checkbox(ref CheckBox checkBox, ref bool save_to)
        {
            save_to = checkBox.Checked;
        }



        void make_sure_dir_exists(in string dir)
        {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        }
        void make_sure_dir_is_reset(in string dir)
        {
            if (Directory.Exists(dir)) { Directory.Delete(dir); Directory.CreateDirectory(dir); } else { Directory.CreateDirectory(dir); };
        }
        void make_sure_file_exists(in string file)
        {
            if (!File.Exists(file)) File.Create(file).Dispose();
        }
        void make_sure_file_is_reset(in string file)
        {   
            if (File.Exists(file)) { File.Delete(file); File.Create(file).Dispose(); } else { File.Create(file).Dispose(); };
        }
        void change_focus()
        {
            this.ActiveControl = label1; // its invisible (top left corner)
        }
        void display_directory(in string dir)
        {
            string full_dir = Environment.CurrentDirectory.ToString() + "/" + dir;

            if (Directory.Exists(full_dir))
                Process.Start(full_dir);
        }

        //Add to event DragEnter / DragDrop        AllowDrop -> True
        private void DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {   
            handle_DragAndDrop_textbox(ref textBox_matrix_width, e);
        }
        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {   
            handle_DragAndDrop_textbox(ref textBox_matrix_height, e);
        }
        private void handle_DragAndDrop_textbox(ref TextBox textBox, DragEventArgs e)
        {
            string[] incoming_text = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBox.Text = incoming_text[0];
        }
        int max(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
        int min(int a, int b)
        {
            if (a < b) return a;
            return b;
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        controller_generation G;
        controller_apply_modyfie M;
        Variables V;

        static System.Timers.Timer mainTimer;
        static int elapsed_time;

        Cell[,,] real_tab_3D;
        Cell[,] real_tab;   // REAL DEAL
        Cell[,] real_tab_next_iteration;    // buffer, po to żeby ciągle nie zwalniać pamięci
        Bitmap frame_now_active;        
        Random random;

        void error_report(string input)
        {   
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { error_report(input); }));
            }
            else
            {
               label_error.Text = input;
            }
        }
        void error_reset()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { error_reset(); }));
            }
            else
            {
                label_error.Text = "";
            }
        }
        bool textBox_parses_to_int(string text)
        {
            return int.TryParse(text, out int res);
        }
        bool textBox_parses_to_int(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int res);
        }
        int textBox_to_int(TextBox textBox)
        {
            int ret = int.Parse(textBox.Text);

            if(ret < 1)
            {
                ret = 1;
                textBox.Text = ret.ToString();
            }

            return ret;
        }
        bool input_incorrect_matrix_dimenstions()
        {
            if (!textBox_parses_to_int(textBox_matrix_width)) return true;
            if (!textBox_parses_to_int(textBox_matrix_height)) return true;
            if (!textBox_parses_to_int(textBox_matrix_depth)) return true;

            return false;
        }
        bool input_incorrect_homogeneous()
        {
            if (!textBox_parses_to_int(textBox_homogeneous_row)) return true;
            if (!textBox_parses_to_int(textBox_homogeneous_col)) return true;

            return false;
        }

        public void change_textbox_text(string text, TextBox textBox)
        {
            if (this.InvokeRequired)
            {
                // no, so call this method again but this
                // time use the UI thread!
                // the heavy-lifting for switching to the ui-thread
                // is done for you
                this.Invoke(new MethodInvoker(delegate { change_textbox_text(text, textBox); }));
            }
            else
            {
                textBox.Text = text;
            }
        }
        public void change_button_text(string text, Button button)
        {
            if (this.InvokeRequired)
            {
                // no, so call this method again but this
                // time use the UI thread!
                // the heavy-lifting for switching to the ui-thread
                // is done for you
                this.Invoke(new MethodInvoker(delegate { change_button_text(text, button); }));
            }
            else
            {   
                button.Text = text;
            }
        }
        public void change_label_text(string text, Label label)
        {
            if (this.InvokeRequired)
            {
                // no, so call this method again but this
                // time use the UI thread!
                // the heavy-lifting for switching to the ui-thread
                // is done for you
                this.Invoke(new MethodInvoker(delegate { change_label_text(text, label); }));
            }
            else
            {
                label.Text = text;
            }
        }
        bool in_bourders(in int x, in int y)
        {
            if((0 <= x && x < V.real_tab_size_x) && (0 <= y && y < V.real_tab_size_y))
            {
                return true;
            }

            return false;
        }
        bool in_bourders(in int x, in int y, in int z)
        {
            if ((0 <= x && x < V.real_tab_size_x) && (0 <= y && y < V.real_tab_size_y) && (0 <= z && z < V.real_tab_size_z))
            {
                return true;
            }

            return false;
        }
        bool single_value_in_bourder(in int val, in int MAX)
        {
            if (0 <= val && val < MAX)
                return true;

            return false;
        }        
        void show_neighbourhood()
        {
            Console.WriteLine("Neighbourhood");

            /*foreach (var coord in V.neighbourhood_list)
            {
                Console.WriteLine(coord.x + " " + coord.y);
            }*/

            Console.WriteLine();
            Console.WriteLine();
        }


        void apply_modyfie_update_text_and_lock_or_unlock()
        {
            string text = "";
            bool value = true;

            if (M.status())
            {
                text = "Apply";
                value = V.value_apply;
            }
            else
            {
                text = "Modyfie";
                value = V.value_modyfie;
            }
            
            textBox_matrix_height.Enabled = value;
            textBox_matrix_width.Enabled = value;
            textBox_matrix_depth.Enabled = value;
            change_button_text(text, button_apply_modyfie);
        }        
        void update_start_stopper()
        {
            G.button_clicked();

            if (G.status())
            {
                change_button_text("Stop", button_start_stop);
                ResumeTimer();
            }
            else
            {
                change_button_text("Start", button_start_stop);
                StopTimer();
            }
        }
        void reset_for_generation()
        {
            G.stop_generation();            
            change_button_text("Start", button_start_stop);
        }
        void copying_new_iteration_to_old_one()
        {
            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    if (real_tab[x, y] == null) Console.WriteLine("real is null");
                    if (real_tab_next_iteration[x, y] == null) Console.WriteLine("next iteration is null");

                    real_tab[x, y].set_id(real_tab_next_iteration[x, y].get_id());
                    real_tab[x, y].set_color(real_tab_next_iteration[x, y].get_color());
                }
        }
        void show_real_tab()
        {
            for (int y = 0; y < V.real_tab_size_y; y++)
            {
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    Console.Write(real_tab[x, y].get_id() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        void all_controls_lock()
        {
            V.ALL_CONTROLLES_STATUS = false;
            all_controls_value(false);
        }
        void all_controls_unlock()
        {
            V.ALL_CONTROLLES_STATUS = true;
            all_controls_value(true);

            if (checkBox_3D.Checked)
                lock_for_MC_3D();
        }
        void all_controls_value(bool value)
        {
            textBox_seed_number_1.Enabled = value;
            textBox_seed_number_2.Enabled = value;

            button_add_seed_1.Enabled = value;
            button_add_seed_2.Enabled = value;

            checkBox_mouse_add.Enabled = value;

            textBox_homogeneous_row.Enabled = value;
            textBox_homogeneous_col.Enabled = value;
            button_homogeneous_apply.Enabled = value;
            radioButton_periodic.Enabled = value;
            radioButton_hard_stop.Enabled = value;
            radioButton_von_nueman.Enabled = value;
            radioButton_moore.Enabled = value;
            radioButton_penta.Enabled = value;
            radioButton_hexa.Enabled = value;
            button_color_reshuffle.Enabled = value;
            button_reset.Enabled = value;
            button_start_stop.Enabled = value;
            button_save_image.Enabled = value;
            button_background_phase.Enabled = value;

            textBox_MC_unique_ids.Enabled = value;
            button_scramble.Enabled = value;
            checkBox_mouse_delete.Enabled = value;
            radioButton_type_of_iter_CA.Enabled = value;
            radioButton_type_of_iter_MC.Enabled = value;
            button_recal_edges.Enabled = value;
            button_edges_on_off.Enabled = value;

            checkBox_Coverage_percent.Enabled = value;
            checkBox_how_many_grains.Enabled = value;

            textBox_kT_value.Enabled = value;


            checkBox_whole_energy.Enabled = value;
            checkBox_auto_edges.Enabled = value;
            checkBox_auto_energy.Enabled = value;
            button_recal_energy.Enabled = value;
            button_energy_on_off.Enabled = value;
            button_2_phases.Enabled = value;

            checkBox_3D.Enabled = value;
            textBox_slice_number.Enabled = value;

            radioButton_save_to_png.Enabled = value;
            radioButton_save_to_ovito.Enabled = value;
        }
        void save_image()
        {
            update_start_stopper();
            {
                string s = DateTime.Now.ToString();
                s = s.Replace(".", "_");
                s = s.Replace(":", "-");
                s = s.Replace(" ", "__");
                
                Bitmap bitmap = new Bitmap(V.pictureBox_size_x, V.pictureBox_size_y);
                
                V.scaling_y = V.scaling;
                V.scaling_x = V.scaling;

                for (int real_y = 0; real_y < V.real_tab_size_y; real_y++)
                    for (int real_x = 0; real_x < V.real_tab_size_x; real_x++)
                    {

                        for (int y = (real_y * V.scaling_y); y < ((real_y + 1) * V.scaling_y); y++)
                            for (int x = (real_x * V.scaling_x); x < ((real_x + 1) * V.scaling_x); x++)
                            {
                                if(real_tab[real_x, real_y].get_id() == V.default_id)
                                    bitmap.SetPixel(x, y, V.default_background_color);
                                else
                                    bitmap.SetPixel(x, y, real_tab[real_x, real_y].get_color());
                            }
                    }

                bitmap.Save(dir_generated_output + s + ".png", ImageFormat.Png);
            }
            update_start_stopper();
        }        
        void save_ovito_2D()
        {
            string text = (V.real_tab_size_x * V.real_tab_size_y).ToString() + Environment.NewLine;

            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    text += Environment.NewLine + x.ToString() + " " + y.ToString() + " " + (real_tab[x, y].get_id()).ToString();
                }
            
            File.WriteAllText(dir_generated_output + DateTime.Now.ToString("h-mm-ss--d-M-yyyy") + "__2D.ovito", text);
        }
        void save_ovito_3D()
        {
            string text = (V.real_tab_size_x * V.real_tab_size_y * V.real_tab_size_z).ToString() + Environment.NewLine;

            for (int z = 0; z < V.real_tab_size_z; z++)
            for (int y = 0; y < V.real_tab_size_y; y++)
            for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    text += Environment.NewLine + x.ToString() + " " + y.ToString() + " " + z.ToString() + " " + (real_tab_3D[x, y, z].get_id()).ToString();
                }

            File.WriteAllText(dir_generated_output + DateTime.Now.ToString("h-mm-ss--d-M-yyyy") + "__3D.ovito", text);
        }
        Color get_new_color()
        {
            return Color.FromArgb(V.color_r.get_value(), V.color_g.get_value(), V.color_b.get_value());
        }
        Color get_random_color()
        {   
            return Color.FromArgb(random.Next(30, 226), random.Next(30, 226), random.Next(30, 226));
        }
        void scaling_update()
        {
            if (V.real_tab_size_x != 0 && V.real_tab_size_y != 0)
            {
                V.scaling_x = V.pictureBox_size_x / V.real_tab_size_x;
                V.scaling_y = V.pictureBox_size_y / V.real_tab_size_y;

                V.scaling = min(V.scaling_x, V.scaling_y);
            }
        }
        void delete_id(Point in_real_tab)
        {
            int id_clicked_on = real_tab[in_real_tab.X, in_real_tab.Y].get_id();

            if (id_clicked_on != V.default_id)
            {
                {
                    for (int y = 0; y < V.real_tab_size_y; y++)
                        for (int x = 0; x < V.real_tab_size_x; x++)
                        {
                            if (real_tab[x, y].get_id() == id_clicked_on)
                            {
                                real_tab[x, y].set_id(V.default_id);
                                real_tab[x, y].set_color(V.default_background_color);

                                real_tab_next_iteration[x, y].set_id(V.default_id);
                                real_tab_next_iteration[x, y].set_color(V.default_background_color);
                            }
                        }
                }
                generate_and_refresh_frame_based_on_REAL_TAB();
            }
        }
        void delete_id_3D(Point in_real_tab_2D)
        {
            int id_clicked_on = real_tab[in_real_tab_2D.X, in_real_tab_2D.Y].get_id();

            if (id_clicked_on != V.default_id)
            {
                for (int z = 0; z < V.real_tab_size_z; z++)
                for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        if (real_tab_3D[x, y, z].get_id() == id_clicked_on)
                        {
                            real_tab_3D[x, y, z].set_id(V.default_id);
                            real_tab_3D[x, y, z].set_color(V.default_background_color);
                        }
                    }

                fill_2D_with_3D_slice();
                generate_and_refresh_frame_based_on_REAL_TAB();
            }
        }
        void handling_click_on_matrix(EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Console.WriteLine(coordinates.X + " " + coordinates.Y);

            if (M.status() == V.value_modyfie)
            {
                scaling_update();
                Point in_real_tab = translate_to_small_tab(coordinates);
                Console.WriteLine("INSIDE   " + in_real_tab.X + " " + in_real_tab.Y);

                if (checkBox_mouse_add.Checked)
                {
                    if (real_tab[in_real_tab.X, in_real_tab.Y].get_id() == V.default_id)
                    {
                        real_tab[in_real_tab.X, in_real_tab.Y].set_id(V.free_id); V.free_id++;
                        real_tab[in_real_tab.X, in_real_tab.Y].set_color(get_random_color());

                        generate_and_refresh_frame_based_on_REAL_TAB();
                    }
                }

                if (checkBox_mouse_delete.Checked)
                {
                    if (checkBox_3D.Checked)
                        delete_id_3D(in_real_tab);
                    else
                        delete_id(in_real_tab);
                }
            }
        }
        Point translate_to_small_tab(Point incoming)
        {
            Point ret = new Point();

            ret.X = incoming.X / V.scaling_x;
            ret.Y = incoming.Y / V.scaling_y;

            return ret;
        }
        void clear_previous_edges()
        {
            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    real_tab[x, y].no_longer_edge();
                    real_tab_next_iteration[x, y].no_longer_edge();
                }
        }
        
        int contains_id(ref List<id_and_Energy> list_freq, int id)
        {
            for (int i = 0; i < list_freq.Count; i++)
            {
                if (list_freq[i].id == id)
                    return i;
            }

            return -1;
        }
        List<id_and_Energy> save_id_and_color_later_energy_calc(coord c)
        {
            //Console.WriteLine("save_id_and_color_later_energy_calc(coord c)");

            List<id_and_Energy> ret = new List<id_and_Energy>();

            foreach (var p in V.MC_energy_pattern)
            {
                int testing_x = c.x + p.x;
                int testing_y = c.y + p.y;

                if (in_bourders(testing_x, testing_y))
                {
                    int id = real_tab[testing_x, testing_y].get_id();
                    int index = contains_id(ref ret, id);

                    if (index == -1)
                    {
                        Color color = real_tab[testing_x, testing_y].get_color();
                        ret.Add(new id_and_Energy(id, color));
                    }
                }
            }

            return ret;
        }
        List<id_and_Energy> save_id_and_color_later_energy_calc(coord_3D c)
        {
            //Console.WriteLine("save_id_and_color_later_energy_calc(coord_3D c)");

            List<id_and_Energy> ret = new List<id_and_Energy>();

            foreach (var p in V.MC_energy_pattern_3D)
            {
                int testing_x = c.x + p.x;
                int testing_y = c.y + p.y;
                int testing_z = c.z + p.z;

                if (in_bourders(testing_x, testing_y, testing_z))
                {
                    int id = real_tab_3D[testing_x, testing_y, testing_z].get_id();
                    int index = contains_id(ref ret, id);

                    if (index == -1)
                    {
                        Color color = real_tab_3D[testing_x, testing_y, testing_z].get_color();
                        ret.Add(new id_and_Energy(id, color));
                    }
                }
            }

            return ret;
        }

        void calc_energy(coord c, ref List<id_and_Energy> list)
        {
            foreach (var neighbour in list)
            {
                foreach (var p in V.MC_energy_pattern)
                {
                    int testing_x = c.x + p.x;
                    int testing_y = c.y + p.y;

                    if (in_bourders(testing_x, testing_y))
                    {
                        if(neighbour.id != real_tab[testing_x, testing_y].get_id())
                        {
                            neighbour.Energy++;
                        }
                    }
                }
            }
        }
        void calc_energy(coord_3D c, ref List<id_and_Energy> list)
        {
            foreach (var neighbour in list)
            {
                foreach (var p in V.MC_energy_pattern_3D)
                {
                    int testing_x = c.x + p.x;
                    int testing_y = c.y + p.y;
                    int testing_z = c.z + p.z;

                    if (in_bourders(testing_x, testing_y, testing_z))
                    {
                        if (neighbour.id != real_tab_3D[testing_x, testing_y, testing_z].get_id())
                        {
                            neighbour.Energy++;
                        }
                    }
                }
            }
        }


        id_and_Energy get_rand(ref List<id_and_Energy> list)
        {
            return list[random.Next(0, list.Count)];
        }
        id_and_Energy get_original_energy(ref List<id_and_Energy> list, int original_id)
        {
            foreach (var neighbour in list)
            {
                if (neighbour.id == original_id)
                    return neighbour;
            }

            return null;
        }
        bool list_contains(ref List<coord> coord_list, coord adding_element)
        {
            foreach (var c in coord_list)
            {
                if (c.x == adding_element.x && c.y == adding_element.y)
                    return true;
            }
            return false;
        }
        void add_unique(ref List<coord> coord_list, coord adding_element)
        {
            if (!list_contains(ref coord_list, adding_element))
            {
                coord_list.Add(adding_element);
            }
        }
        void mark_id_surrounding_cell(ref List<coord> coord_list)
        {
            int original_id = real_tab[coord_list[0].x, coord_list[0].y].get_id();


            while (coord_list.Count > 0)
            {
                coord el_0 = coord_list[0];
                real_tab[el_0.x, el_0.y].mark_as_counted();

                foreach (var p in V.MC_energy_pattern)
                {
                    int testing_x = el_0.x + p.x;
                    int testing_y = el_0.y + p.y;

                    if (in_bourders(testing_x, testing_y))
                    {
                        if (!real_tab[testing_x, testing_y].status_counted() && real_tab[testing_x, testing_y].get_id() == original_id)
                        {
                            add_unique(ref coord_list, new coord(testing_x, testing_y));
                        }
                    }
                }
                coord_list.RemoveAt(0);
            }
        }
        int energy_for_single_cell(in int x, in int y, in int original_id)
        {
            int energy = 0;

            foreach (var p in V.MC_energy_pattern)
            {
                int testing_x = x + p.x;
                int testing_y = y + p.y;

                if (in_bourders(testing_x, testing_y))
                {
                    if (real_tab[testing_x, testing_y].get_id() != original_id)
                    {
                        energy++;
                    }
                }
            }

            return energy;
        }
        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            elapsed_time++;

            //Console.WriteLine("HAPPENDED - OnTimedEvent");
        }
        void StartTimer()
        {
            elapsed_time = 0;
            V.iteration_number = 0;
            mainTimer.Start();

            //Console.WriteLine("HAPPENDED - StartTimer");
        }
        void StopTimer()
        {
            mainTimer.Stop();

            //Console.WriteLine("HAPPENDED - StopTimer");
        }
        void ResumeTimer()
        {
            mainTimer.Start();

            //Console.WriteLine("HAPPENDED - ResumeTimer");
        }
        string prepare_timer_log()
        {
            //      "    m     s   -   iter. "

            int min = elapsed_time / 60;
            int sec = elapsed_time - 60 * min;
            int iter = V.iteration_number;

            string log = "";

            log += min.ToString();
            log += " m ";

            if (sec <= 9)
                log += "  ";

            log += sec.ToString();
            log += " s   -   iter. ";

            log += iter.ToString();

            return log;
        }

        private void button_add_seed_1_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            {
                change_focus();
                string text = textBox_seed_number_1.Text;

                if (!textBox_parses_to_int(text)) return;
                add_seed(int.Parse(text));
            }
            Application.UseWaitCursor = false;
        }
        private void button_add_seed_2_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            {
                change_focus();
                string text = textBox_seed_number_2.Text;

                if (!textBox_parses_to_int(text)) return;
                add_seed(int.Parse(text));
            }
            Application.UseWaitCursor = false;
        }
        private void button_color_reshuffle_Click(object sender, EventArgs e)
        {
            change_focus();            

            Dictionary<int, Color> dick = new Dictionary<int, Color>();

            for (int i=0; i < V.free_id; i++)
            {
                dick.Add(i, get_random_color());
            }
            int current_id;


            if (checkBox_3D.Checked)
            {
                for (int z = 0; z < V.real_tab_size_z; z++)
                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        current_id = real_tab_3D[x, y, z].get_id();

                        real_tab_3D[x, y, z].set_color(dick[current_id]);
                    }

                fill_2D_with_3D_slice();
            }
            else
            {
                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        current_id = real_tab[x, y].get_id();

                        real_tab[x, y].set_color(dick[current_id]);
                    }
            }
            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        private void button_apply_modyfie_Click(object sender, EventArgs e)
        {
            change_focus();
            if (M.status() == V.value_apply)
            {
                // był state modyfie -> (i teraz próbujemy zrobić lock down wartości)

                if (input_incorrect_matrix_dimenstions()) { error_report("Input incorrect"); return; }
                else error_reset();

                M.set_modyfie();
                regenerate_real_tab();
                scaling_update();

                all_controls_unlock();
            }
            else
            {
                M.set_apply();
                all_controls_lock();
            }

            apply_modyfie_update_text_and_lock_or_unlock();
        }
        private void button_save_image_Click(object sender, EventArgs e)
        {
            change_focus();


            if (radioButton_save_to_png.Checked)
            {
                save_image();                
            }

            if (radioButton_save_to_ovito.Checked)
            {
                if(checkBox_3D.Checked)
                {
                    save_ovito_3D();
                }
                else
                {
                    save_ovito_2D();
                }
            }
        }
        private void button_homogeneous_apply_Click(object sender, EventArgs e)
        {
            change_focus();
            Application.UseWaitCursor = true;
            {

                if (input_incorrect_homogeneous()) { error_report("Input incorrect"); return; }
                else error_reset();

                /*int x_start = V.padding_homogeneous;            int x_end = V.real_tab_size_x - V.padding_homogeneous;
                int y_start = V.padding_homogeneous;            int y_end = V.real_tab_size_y - V.padding_homogeneous;
                int row_length = V.real_tab_size_x - (2 * V.padding_homogeneous);
                int col_length = V.real_tab_size_y - (2 * V.padding_homogeneous);*/

                int how_many_in_row = textBox_to_int(textBox_homogeneous_row);
                int how_many_in_col = textBox_to_int(textBox_homogeneous_col);

                int pos_x_scalar = V.real_tab_size_x / how_many_in_row;
                int pos_y_scalar = V.real_tab_size_y / how_many_in_col;

                for (int y = pos_y_scalar / 2; y < V.real_tab_size_y; y += pos_y_scalar)
                    for (int x = pos_x_scalar / 2; x < V.real_tab_size_x; x += pos_x_scalar)
                    {
                        real_tab[x, y].set_id(V.free_id); V.free_id++;
                        real_tab[x, y].set_color(get_random_color());
                    }

                change_focus();

                generate_and_refresh_frame_based_on_REAL_TAB();
            }
            Application.UseWaitCursor = false;
        }
        private void pictureBox_main_show_matrix_Click(object sender, EventArgs e)
        {
            change_focus();
            handling_click_on_matrix(e);
        }
        private void button_scramble_Click(object sender, EventArgs e)
        {
            change_focus();
            if (!textBox_parses_to_int(textBox_MC_unique_ids)) return;


            List<id_and_color> list = new List<id_and_color>();

            for (int i = 0; i < textBox_to_int(textBox_MC_unique_ids); i++)
                list.Add(new id_and_color(V.free_id++, get_random_color()));

            for (int y = 0; y < V.real_tab_size_y; y++)
            for (int x = 0; x < V.real_tab_size_x; x++)
            {
                    var current = list[random.Next(0, list.Count)];

                    real_tab[x, y].set_id(current.id);
                    real_tab[x, y].set_color(current.color);
            }

            for (int z = 0; z < V.real_tab_size_z; z++)
            for (int y = 0; y < V.real_tab_size_y; y++)
            for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    var current = list[random.Next(0, list.Count)];

                    real_tab_3D[x, y, z].set_id(current.id);
                    real_tab_3D[x, y, z].set_color(current.color);
                }

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        private void button_high_edges_Click(object sender, EventArgs e)
        {
            change_focus();

            recal_edges();

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        void recal_edges()
        {
            clear_previous_edges();
            List<coord> neighbourhood = new List<coord>(); int length = 1; for (int y = -length; y <= length; y++) for (int x = -length; x <= length; x++) if(x == 0 || y == 0) neighbourhood.Add(new coord(x, y));

            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    List<int> list_of_processed_ids = new List<int>();

                    foreach (var c in neighbourhood)
                    {
                        int real_x = x + c.x;
                        int real_y = y + c.y;

                        if (in_bourders(real_x, real_y))
                        {
                            int id = real_tab[real_x, real_y].get_id();

                            if (!list_of_processed_ids.Contains(id))
                            {
                                list_of_processed_ids.Add(id);
                            }
                        }
                    }

                    if (list_of_processed_ids.Count > 1)
                    {
                        real_tab[x, y].mark_as_edge();
                        real_tab_next_iteration[x, y].mark_as_edge();
                    }
                }
        }
        private void button_edges_on_off_Click(object sender, EventArgs e)
        {
            change_focus();
            V.edge_on = !V.edge_on;

            if (V.edge_on)
            {
                button_edges_on_off.Text = "On";
            }
            else
            {
                button_edges_on_off.Text = "Off";
            }

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        private void button_background_phase_Click(object sender, EventArgs e)
        {
            change_focus();
            int new_id = V.free_id; V.free_id++;
            Color new_color = get_random_color();

            if (checkBox_3D.Checked)
            {
                for (int z = 0; z < V.real_tab_size_z; z++)
                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        if (real_tab_3D[x, y, z].get_id() == V.default_id)
                        {
                            real_tab_3D[x, y, z].set_id(new_id);
                            real_tab_3D[x, y, z].set_color(new_color);
                        }
                    }

                fill_2D_with_3D_slice();
            }
            else
            {
                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        if (real_tab[x, y].get_id() == V.default_id)
                        {
                            real_tab[x, y].set_id(new_id);
                            real_tab[x, y].set_color(new_color);
                        }
                    }
            }

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        private void button_work_dir_Click_1(object sender, EventArgs e)
        {
            change_focus();
            Process.Start(Directory.GetCurrentDirectory());
        }
        private void button_see_output_Click(object sender, EventArgs e)
        {
            change_focus();
            Process.Start(dir_generated_output);
        }
        private void button_2_phases_Click(object sender, EventArgs e)
        {
            change_focus();

            int new_id_1 = V.free_id; V.free_id++;
            Color new_color_1 = get_random_color();

            int new_id_2 = V.free_id; V.free_id++;
            Color new_color_2 = get_random_color();

            if(checkBox_3D.Checked)
            {
                for (int z = 0; z < V.real_tab_size_z; z++)
                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        if (real_tab_3D[x, y, z].get_id() == V.default_id)
                        {
                                real_tab_3D[x, y, z].set_id(new_id_1);
                                real_tab_3D[x, y, z].set_color(new_color_1);
                        }
                        else
                        {
                                real_tab_3D[x, y, z].set_id(new_id_2);
                                real_tab_3D[x, y, z].set_color(new_color_2);
                        }
                    }

                fill_2D_with_3D_slice();
            }
            else
            {
                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        if (real_tab[x, y].get_id() == V.default_id)
                        {
                            real_tab[x, y].set_id(new_id_1);
                            real_tab[x, y].set_color(new_color_1);
                        }
                        else
                        {
                            real_tab[x, y].set_id(new_id_2);
                            real_tab[x, y].set_color(new_color_2);
                        }
                    }
            }

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        private void button_recal_energy_Click(object sender, EventArgs e)
        {
            change_focus();

            recal_energy();

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        void recal_energy()
        {
            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    real_tab[x, y].set_energy_level(energy_for_single_cell(x, y, real_tab[x, y].get_id()));
                }
        }
        private void button_energy_on_off_Click(object sender, EventArgs e)
        {
            change_focus();

            V.energy_on = !V.energy_on;

            if (V.energy_on)
            {
                button_energy_on_off.Text = "On";
            }
            else
            {
                button_energy_on_off.Text = "Off";
            }

            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        
        
        
        void regenerate_real_tab()
        {
            // if locked -> no need for input validation
            if(M.status() == V.value_modyfie)
            {
                V.real_tab_size_x = textBox_to_int(textBox_matrix_width);
                V.real_tab_size_y = textBox_to_int(textBox_matrix_height);
                V.real_tab_size_z = textBox_to_int(textBox_matrix_depth);
                V.real_tab_size_all = V.real_tab_size_x * V.real_tab_size_y;


                regenerate_2D_real_tab();
                regenerate_3D_real_tab();
            }
        }
        void regenerate_2D_real_tab()
        {
            Console.WriteLine("Regenerated 2D");
            Console.WriteLine(V.real_tab_size_x + " " + V.real_tab_size_y);

            real_tab = new Cell[V.real_tab_size_x, V.real_tab_size_y];
            real_tab_next_iteration = new Cell[V.real_tab_size_x, V.real_tab_size_y];
            for (int y = 0; y < V.real_tab_size_y; y++) for (int x = 0; x < V.real_tab_size_x; x++) { real_tab[x, y] = new Cell(V.default_id, V.default_background_color); real_tab_next_iteration[x, y] = new Cell(V.default_id, V.default_background_color); }
        }
        void regenerate_3D_real_tab()
        {
            Console.WriteLine("Regenerated 3D");
            Console.WriteLine(V.real_tab_size_x + " " + V.real_tab_size_y + " " + V.real_tab_size_z);

            real_tab_3D = new Cell[V.real_tab_size_x, V.real_tab_size_y, V.real_tab_size_z];

            for (int z = 0; z < V.real_tab_size_z; z++)
            for (int y = 0; y < V.real_tab_size_y; y++) 
            for (int x = 0; x < V.real_tab_size_x; x++)
            {
                real_tab_3D[x, y, z] = new Cell(V.default_id, V.default_background_color);
            }
        }
        void add_seed(int how_many_seeds)
        {
            //stop_worker_thread();
            {
                for (int i = 0; i < how_many_seeds; i++)
                {
                    coord c = random_free_coord();

                    real_tab[c.x, c.y].set_id(V.free_id); V.free_id++;
                    real_tab[c.x, c.y].set_color(get_random_color());
                }

                generate_and_refresh_frame_based_on_REAL_TAB();
            }
            //start_worker_thread();
        }
        coord random_coord()
        {
            return new coord(random.Next(0, V.real_tab_size_x), random.Next(0, V.real_tab_size_y));
        }
        coord_3D random_coord_3D()
        {
            return new coord_3D(random.Next(0, V.real_tab_size_x), random.Next(0, V.real_tab_size_y), random.Next(0, V.real_tab_size_z));
        }
        coord random_free_coord()
        {
            coord c = random_coord();
            
            while(real_tab[c.x, c.y].get_id() != V.default_id)
            {
                c = random_coord();
            }

            return c;
        }

        void von_nueman()
        {
            V.neighbourhood_list.Add(new List<coord>());        int length = 1;

            for (int y = -length; y <= length; y++)
            for (int x = -length; x <= length; x++)
            {
                if(!((x == 0 && y == 0)) && ((x == 0 || y == 0)))
                {
                        V.neighbourhood_list[0].Add(new coord(x, y));
                }
            }
        }        
        void moore()
        {
            V.neighbourhood_list.Add(new List<coord>());        int length = 1;

            for (int y = -length; y <= length; y++)
            for (int x = -length; x <= length; x++)
            {
                V.neighbourhood_list[0].Add(new coord(x, y));
            }
        }
        void pentago()
        {
            int length = 1; int current_list = 0;

            // Eliminate right column
            {
                V.neighbourhood_list.Add(new List<coord>());
                for (int y = -length; y <= length; y++)
                    for (int x = -length; x <= length; x++)
                    {
                        if(x < 1)
                            V.neighbourhood_list[current_list].Add(new coord(x, y));
                    }
                current_list++;
            }

            // Eliminate left column
            {
                V.neighbourhood_list.Add(new List<coord>());
                for (int y = -length; y <= length; y++)
                    for (int x = -length; x <= length; x++)
                    {
                        if (-1 < x)
                            V.neighbourhood_list[current_list].Add(new coord(x, y));
                    }
                current_list++;
            }

            // Eliminate upper row
            {
                V.neighbourhood_list.Add(new List<coord>());
                for (int y = -length; y <= length; y++)
                    for (int x = -length; x <= length; x++)
                    {
                        if (y < 1)
                            V.neighbourhood_list[current_list].Add(new coord(x, y));
                    }
                current_list++;
            }

            // Eliminate lower row
            {
                V.neighbourhood_list.Add(new List<coord>());
                for (int y = -length; y <= length; y++)
                    for (int x = -length; x <= length; x++)
                    {
                        if (-1 < y)
                            V.neighbourhood_list[current_list].Add(new coord(x, y));
                    }
                current_list++;
            }
        }
        void hexago()
        {
            int length = 1;     int current_list = 0;

            // like '/'
            {
                V.neighbourhood_list.Add(new List<coord>());
                for (int y = -length; y <= length; y++)
                    for (int x = -length; x <= length; x++)
                    {
                        if(!((x == -1 && y == 1) || (x == 1 && y == -1)))
                            V.neighbourhood_list[current_list].Add(new coord(x, y));
                    }
                current_list++;
            }

            // like '\'
            {
                V.neighbourhood_list.Add(new List<coord>());
                for (int y = -length; y <= length; y++)
                    for (int x = -length; x <= length; x++)
                    {
                        if (!((x == 1 && y == 1) || (x == -1 && y == -1)))
                            V.neighbourhood_list[current_list].Add(new coord(x, y));
                    }
                current_list++;
            }
        }



        void periodic_single_variable(ref int variable, in int MAX)
        {
            if (!single_value_in_bourder(variable, MAX))
            {
                if (variable < 0)
                {
                    variable = MAX + variable;
                }
                else if (variable > 0)
                {
                    variable = variable - MAX;
                }
            }
        }
        bool boundery_conditions_periodic(ref int x, ref int y)
        {
            periodic_single_variable(ref x, V.real_tab_size_x);
            periodic_single_variable(ref y, V.real_tab_size_y);

            return true;
        }
        bool boundery_conditions_hard_stop(ref int x, ref int y)
        {
            // they are declared to be out of bound -> so in this case we don't process them
            return false;
        }

        void stop_worker_thread()
        {
            if(V.t != null)
                V.t.Abort();

            V.t = null;
        }
        void start_worker_thread()
        {
            V.t = new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                thread_job();

            });
            V.t.Start();
        }
        void constructor_setup()
        {
            error_reset();
            change_focus();

            G = new controller_generation();
            M = new controller_apply_modyfie();
            V = new Variables();
            random = new Random();

            MC_energy_search_pattern();

            start_worker_thread();

            neighbourhood();

            apply_modyfie_update_text_and_lock_or_unlock();
            regenerate_real_tab();
                        
            V.default_background_color = Color.FromArgb(240, 240, 240);
            V.edge_color = Color.Black;

            V.pictureBox_size_x = pictureBox_main_show_matrix.Width;
            V.pictureBox_size_y = pictureBox_main_show_matrix.Height;

            frame_now_active = new Bitmap(V.pictureBox_size_x, V.pictureBox_size_y);
            pictureBox_main_show_matrix.Image = frame_now_active;

            label_stat_coverage.Text = "";
            label_number_of_grains.Text = "";
            label_energy_of_system.Text = "";
            label_iter_and_time_of_simulation.Text = "";

            mainTimer = new System.Timers.Timer(1000);
            mainTimer.Elapsed += OnTimedEvent;
            mainTimer.AutoReset = true;
            mainTimer.Enabled = true;

            reset_procedure();

            lock_for_MC_3D();
            unlock_for_MC_3D();
        }



        // TODO -    POMYSŁY NA IMPLEMENTACJE

        // TODO - wybieramy czy od razu zobaczymy ostatni krok, czy widać wszystko krok po kroku lub z pominięciem paru i albo dochodzi do końca albo zatrzymuje się po iluś iteracjach        



        // MAIN
        async void button1_Click(object sender, EventArgs e)
        {
            change_focus();
            Application.UseWaitCursor = true;

            if (V.t == null)
            {
                start_worker_thread();
                StartTimer();
            }            

            await Task.Run(() =>
            {
                handle_button_click();
            });

            Application.UseWaitCursor = false;
        }
        void button_reset_Click(object sender, EventArgs e)
        {
            change_focus();

            reset_procedure();
        }
        void reset_procedure()
        {
            stop_worker_thread();

            //Console.WriteLine("Reset fired up");

            change_label_text(V.default_time_text, label_iter_and_time_of_simulation);

            //await Task.Run(() =>
            {
                reset_for_generation(); // Start / Stop - button

                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        real_tab[x, y].set_id(V.default_id);
                        real_tab[x, y].set_color(V.default_background_color);

                        real_tab_next_iteration[x, y].set_id(V.default_id);
                        real_tab_next_iteration[x, y].set_color(V.default_background_color);
                    }

                for (int y = 0; y < V.pictureBox_size_y; y++) for (int x = 0; x < V.pictureBox_size_y; x++) { frame_now_active.SetPixel(x, y, V.default_background_color); }
                refresh_PictureBox();
            }
            //);
        }
        void handle_button_click()
        {
            if (input_incorrect_matrix_dimenstions() && (M.status() == V.value_modyfie)) { error_report("Input incorrect"); return; }
            else error_reset();

            neighbourhood();
            scaling_update();

            update_start_stopper();
        }
        void thread_job()
        {
            for (; ; )
            {
                //Console.WriteLine(G.status());

                if (G.status())
                {
                    //System.Threading.Thread.Sleep(500);
                    //show_real_tab();

                    try
                    {
                        if(checkBox_3D.Checked)
                        {
                            //Console.WriteLine("Generating 3D frame");
                            generate_new_frame_3D();
                        }
                        else
                        {
                            //Console.WriteLine("Generating 2D frame");
                            generate_new_frame_2D();
                        }
                    }
                    catch (ThreadAbortException ex)
                    {
                    }
                }
            }
            
        }


        void MC_energy_search_pattern()
        {
            V.MC_energy_pattern = new List<coord>();

            // Może ma być z tym w środku - tylko dodać to, żeby czasami podejmował nie optymalne decyzje

            
            int length = 1; 
            
            for (int y = -length; y <= length; y++)
            for (int x = -length; x <= length; x++)
                {
                    if(!(x == 0 & y == 0))
                        V.MC_energy_pattern.Add(new coord(x, y));
                }


            V.MC_energy_pattern_3D = new List<coord_3D>();

            for (int z = -length; z <= length; z++)
            for (int y = -length; y <= length; y++)
            for (int x = -length; x <= length; x++)
                {
                    if (!(x == 0 & y == 0 && z == 0))
                        V.MC_energy_pattern_3D.Add(new coord_3D(x, y, z));
                }
        }
        void neighbourhood()
        {
            V.neighbourhood_list = new List<List<coord>>();

            if(radioButton_von_nueman.Checked) von_nueman();
            else if(radioButton_moore.Checked) moore();
            else if(radioButton_penta.Checked) pentago();
            else if(radioButton_hexa.Checked) hexago();

            //show_neighbourhood();
        }
        bool boundery_conditions(ref int x, ref int y)
        {
            bool process_these_coords = true;
            {
                if (radioButton_periodic.Checked) process_these_coords = boundery_conditions_periodic(ref x, ref y);
                else if (radioButton_hard_stop.Checked) process_these_coords = boundery_conditions_hard_stop(ref x, ref y);
            }
            return process_these_coords;
        }
        bool cell_condition(int how_many_same_material_cells_around)
        {
            if (1 <= how_many_same_material_cells_around)
            {
                return true;
            }
            return false;
        }
        packed_answer analyzing_cell(in int real_x, in int real_y, in int original_id)
        {
            int x, y, id;
            List<(int id, Color color)> id_around = new List<(int id, Color color)>();
            bool coord_process_permission = true;

            List<coord> current_neighbourhood = null;
            if (V.neighbourhood_list.Count == 0)
            {
                Console.WriteLine("fatal error -> no heighbourhood");
            }
            else if(V.neighbourhood_list.Count == 1)
            {
                current_neighbourhood = V.neighbourhood_list[0];
            }
            else
            {
                if (radioButton_penta.Checked)
                {
                    current_neighbourhood = V.neighbourhood_list[random.Next(0, 4)];
                }
                else if (radioButton_hexa.Checked)
                {
                    current_neighbourhood = V.neighbourhood_list[random.Next(0, 2)];
                }
                else Console.WriteLine("fatal error - analyzing_cell");
            }

            foreach (var coord in current_neighbourhood)
            {
                x = real_x + coord.x;
                y = real_y + coord.y;
                //Console.WriteLine(x + ", " + y + "          " + real_x + " " + real_y + "          " + coord.x + " " + coord.y);

                if (!in_bourders(x, y))
                {
                    coord_process_permission = boundery_conditions(ref x, ref y);
                }

                //Console.WriteLine(x + ", " + y + "          " + real_x + " " + real_y + "          " + coord.x + " " + coord.y);
                if (coord_process_permission)
                {
                    id = real_tab[x, y].get_id();
                    if (id != V.default_id)
                    {
                        id_around.Add((id, real_tab[x, y].get_color()));
                    }
                }
            }

            if (id_around.Count == 0)
            {
                packed_answer error = new packed_answer(-1,-1, Color.Black);                
                return error;
            }

            var counter = new OccurrenceCounter(id_around);
            var mostCommonValue = counter.MostCommonValue();
            //Console.WriteLine($"Most common ID: {mostCommonValue.id}, Color: {mostCommonValue.color}, Occurrences: {mostCommonValue.occurrences}");


            packed_answer p = new packed_answer(mostCommonValue.id, mostCommonValue.occurrences, mostCommonValue.color);
            
            return p;
        }



        void Cellular_Automata()
        {
            // Automat Komórkowy
            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    int original_id = real_tab[x, y].get_id();
                    if (original_id == V.default_id)
                    {
                        //Console.WriteLine("Analizing  " + x + " " + y);

                        packed_answer answer = analyzing_cell(x, y, original_id);

                        if (answer.id != V.default_id)
                            if (cell_condition(answer.number_of_occurances))
                            {
                                real_tab_next_iteration[x, y].set_id(answer.id);
                                real_tab_next_iteration[x, y].set_color(answer.color);
                            }
                    }
                    else
                    {
                        // copying the same color from last iteration

                        real_tab_next_iteration[x, y].set_id(real_tab[x, y].get_id());
                        real_tab_next_iteration[x, y].set_color(real_tab[x, y].get_color());
                    }
                }

            copying_new_iteration_to_old_one();
        }
        void Monte_Carlo()
        {
            int number_of_coords_shot_at_one_cicle = (V.real_tab_size_x * V.real_tab_size_y) / 2;
            double kT = 0.6;

            if (double.TryParse(textBox_kT_value.Text, out double outcome))
                kT = outcome;


            List<id_and_Energy> list_energy;
            coord c;
            for (int i = 0; i < number_of_coords_shot_at_one_cicle; i++)
            {
                int original_energy_level = 0;

                if(true)
                {
                    c = random_coord();

                    list_energy = save_id_and_color_later_energy_calc(c);

                    // energia jeśli w środku jest - jakaś liczba
                    calc_energy(c, ref list_energy);
                    

                    id_and_Energy original_energy = get_original_energy(ref list_energy, real_tab[c.x, c.y].get_id());                    

                    if (original_energy == null)
                    {
                        // przypadek, że na około nie było, żadnego id takiego jak to w środku
                        // to znaczy jest maksymalne czyli 8

                        original_energy_level = 8;
                    }
                    else
                    {
                        original_energy_level = original_energy.Energy;
                    }
                }
                
                id_and_Energy answer = chosen_id_to_replace_middle(ref list_energy, original_energy_level, kT);                

                real_tab[c.x, c.y].set_id(answer.id);
                real_tab[c.x, c.y].set_color(answer.color);
            }
        }

        id_and_Energy chosen_id_to_replace_middle(ref List<id_and_Energy> list_energy, int original_energy_level, double kT)
        {
            while (true)
            {
                id_and_Energy rand = get_rand(ref list_energy);
                int delta_energy = rand.Energy - original_energy_level;


                if (delta_energy <= 0)
                {
                    return rand;
                }

                else if (0 < delta_energy)
                {
                    double exp_value = Math.Exp(-((double)delta_energy / kT));
                    if (exp_value < 0) exp_value = -exp_value;

                    // acceptance
                    if (exp_value >= 1)
                    {
                        return rand;
                    }
                    else
                    {
                        int representation = (int)(100 * exp_value);

                        // acceptance
                        if (random.Next(0, 100) < representation)
                        {
                            return rand;
                        }
                    }
                }
            }
        }

        void Monte_Carlo_3D()
        {
            int number_of_coords_shot_at_one_cicle = (V.real_tab_size_x * V.real_tab_size_y * V.real_tab_size_z) / 4;
            double kT = 0.6;

            if (double.TryParse(textBox_kT_value.Text, out double outcome))
                kT = outcome;


            List<id_and_Energy> list_energy;
            coord_3D c;
            for (int i = 0; i < number_of_coords_shot_at_one_cicle; i++)
            {
                // TIME Stats
                if(i % 250 == 0) change_label_text(prepare_timer_log(), label_iter_and_time_of_simulation);

                int original_energy_level = 0;

                if (true)
                {
                    c = random_coord_3D();

                    list_energy = save_id_and_color_later_energy_calc(c);

                    // energia jeśli w środku jest - jakaś liczba
                    calc_energy(c, ref list_energy);

                    id_and_Energy original_energy = get_original_energy(ref list_energy, real_tab_3D[c.x, c.y, c.z].get_id());

                    if (original_energy == null)
                    {
                        // przypadek, że na około nie było, żadnego id takiego jak to w środku
                        // to znaczy jest maksymalne czyli 24

                        original_energy_level = 26;
                    }
                    else
                    {
                        original_energy_level = original_energy.Energy;
                    }
                }


                id_and_Energy answer = chosen_id_to_replace_middle(ref list_energy, original_energy_level, kT);

                real_tab_3D[c.x, c.y, c.z].set_id(answer.id);
                real_tab_3D[c.x, c.y, c.z].set_color(answer.color);
            }
        }
        

        void lock_for_MC_3D()
        {
            change_value_for_MC_3D(false);
        }
        void unlock_for_MC_3D()
        {
            change_value_for_MC_3D(true);
        }
        void change_value_for_MC_3D(bool value)
        {
            textBox_seed_number_1.Enabled = value;
            textBox_seed_number_2.Enabled = value;

            button_add_seed_1.Enabled = value;
            button_add_seed_2.Enabled = value;

            checkBox_mouse_add.Enabled = value;

            textBox_homogeneous_row.Enabled = value;
            textBox_homogeneous_col.Enabled = value;
            button_homogeneous_apply.Enabled = value;
            radioButton_periodic.Enabled = value;
            radioButton_hard_stop.Enabled = value;
            radioButton_von_nueman.Enabled = value;
            radioButton_moore.Enabled = value;
            radioButton_penta.Enabled = value;
            radioButton_hexa.Enabled = value;
            
            radioButton_type_of_iter_CA.Enabled = value;

            textBox_slice_number.Enabled = !value;
        }


        void generate_new_frame_2D()
        {
            V.iteration_number++;

            // TIME Stats
            change_label_text(prepare_timer_log(), label_iter_and_time_of_simulation);

            if (radioButton_type_of_iter_CA.Checked)
                Cellular_Automata();

            else if (radioButton_type_of_iter_MC.Checked)
                Monte_Carlo();

            // TIME Stats
            change_label_text(prepare_timer_log(), label_iter_and_time_of_simulation);

            // tutaj co ile iteracji skaczemy  //   albo czy wszystkie celki są już zajęte
            generate_and_refresh_frame_based_on_REAL_TAB();
        }
        void generate_new_frame_3D()
        {
            V.iteration_number++;


            Monte_Carlo_3D();

            fill_2D_with_3D_slice();


            // tutaj co ile iteracji skaczemy  //   albo czy wszystkie celki są już zajęte
            generate_and_refresh_frame_based_on_REAL_TAB();
        }

        bool in_bound(in int x, in int limit)
        {
            return (0 <= x && x < limit);
        }
        void fill_2D_with_3D_slice()
        {
            int slice_num = 0;

            if (int.TryParse(textBox_slice_number.Text, out int user_input) && in_bound(user_input, V.real_tab_size_z))
            {
                slice_num = user_input;
            }
            else
            {
                change_textbox_text(slice_num.ToString(), textBox_slice_number);
            }

            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    real_tab[x, y].set_id(real_tab_3D[x, y, slice_num].get_id());
                    real_tab[x, y].set_color(real_tab_3D[x, y, slice_num].get_color());

                    // Console.WriteLine("slice    " + x + "  " + y + "  " + real_tab[x, y].get_id());
                }
        }

        int calculate_how_many_grains()
        {
            int grain_count = 0;

            for (int y = 0; y < V.real_tab_size_y; y++)
            for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    if (!(real_tab[x, y].status_counted()))
                    {
                        grain_count++;
                        List<coord> coord_list = new List<coord>();
                        coord_list.Add(new coord(x, y));

                        mark_id_surrounding_cell(ref coord_list);
                        coord_list.Clear();
                    }
                }

            // RESET
            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    real_tab[x, y].reset_counted_state();                    
                }

            return grain_count;
        }
        int calculate_how_much_energy()
        {
            int total_energy = 0;

            for (int y = 0; y < V.real_tab_size_y; y++)
                for (int x = 0; x < V.real_tab_size_x; x++)
                {
                    total_energy += energy_for_single_cell(x, y, real_tab[x, y].get_id());
                }

            return total_energy;
        }

        void generate_and_refresh_frame_based_on_REAL_TAB()
        {
            scaling_update();

            lock (V.sync_FILL_FRAME)
            {
                V.stats_coverage = 0;

                for (int y = 0; y < V.real_tab_size_y; y++)
                    for (int x = 0; x < V.real_tab_size_x; x++)
                    {
                        if("Stats" != "")
                        {
                            if (real_tab[x, y].get_id() != V.default_id) V.stats_coverage++;
                        }



                        if (real_tab[x, y].status_edge() && V.edge_on)                        
                            fill_frame_based_on_real_tab(x, y, V.edge_color);


                        else if(V.energy_on)
                            fill_frame_based_on_real_tab(x, y, real_tab[x, y].get_energy_color());


                        else
                            fill_frame_based_on_real_tab(x, y, real_tab[x, y].get_color());
                    }
            }
            
            if(checkBox_Coverage_percent.Checked) change_label_text("Coverage  " + (((float)V.stats_coverage / (float)(V.real_tab_size_all)) * 100) + "%", label_stat_coverage);
            else change_label_text("", label_stat_coverage);

            if (checkBox_how_many_grains.Checked) change_label_text( "Grains       " + calculate_how_many_grains().ToString(), label_number_of_grains);
            else change_label_text("", label_number_of_grains);

            if (checkBox_whole_energy.Checked) change_label_text("Energy      " + calculate_how_much_energy().ToString(), label_energy_of_system);
            else change_label_text("", label_energy_of_system);



            if (checkBox_auto_edges.Checked)
                recal_edges();

            if (checkBox_auto_energy.Checked)
                recal_energy();



            refresh_PictureBox();
        }
        void fill_frame_based_on_real_tab(int real_x, int real_y, Color color)
        {
            // jak chcę żeby się nie rozciągały
            V.scaling_y = V.scaling;
            V.scaling_x = V.scaling;

            for (int y = (real_y * V.scaling_y); y < ((real_y + 1) * V.scaling_y); y++)
                for (int x = (real_x * V.scaling_x); x < ((real_x + 1) * V.scaling_x); x++)
                {
                    // TODO   - WYŚWIETLANIE - dziwnie nie koloruje tych miejsc (0, 0) itd.

                    //if (y == 0 && x == 0) Console.WriteLine("frame_now_active (" + x + ", " + y + ")");
                    try
                    {
                        //if (y == 0 && x == 0) Console.WriteLine("INSIDE frame_now_active (" + x + ", " + y + ")");

                        frame_now_active.SetPixel(x, y, color);

                        //frame_buffer.SetPixel(x, y, color);

                        //Color a = frame_now_active.GetPixel(x, y);
                        //if (a == color) Console.WriteLine("color set succesfully ");
                        //else Console.WriteLine("color set failed");
                    }
                    catch (InvalidOperationException exc)
                    {
                        //MessageBox.Show(exc.ToString());
                    }
                    catch (Exception exception)
                    {
                        //MessageBox.Show(exception.Message);
                    }
                }
        }
        public void refresh_PictureBox()
        {
            try
            {
                // are we called from the UI thread?
                if (this.InvokeRequired)
                {
                    // no, so call this method again but this
                    // time use the UI thread!
                    // the heavy-lifting for switching to the ui-thread
                    // is done for you

                    //Console.WriteLine("Invoking UI thread");                    
                    this.Invoke(new MethodInvoker(delegate { refresh_PictureBox(); }));
                }
                else
                {
                    lock (V.sync_FILL_FRAME)
                    {
                        //Console.WriteLine("On UI thread");
                        pictureBox_main_show_matrix.Refresh();
                    }
                    return;
                }
            }
            catch
            {

            }
        }

        private void checkBox_3D_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_type_of_iter_MC.Checked)
            {
                checkBox_3D.Checked = false;               
            }
            

            if(checkBox_3D.Checked)
            {
                lock_for_MC_3D();
            }
            else
            {
                unlock_for_MC_3D();
            }
        }
        private void radioButton_type_of_iter_CA_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_type_of_iter_CA.Checked)
            {
                checkBox_3D.Checked = false;
            }
        }
    }
}