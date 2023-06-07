using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Enigma_1_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------

        string right_rotor = "LEYJVCNIXWPBQMDRTAKZGFUHOS";
        string alphabet_rotor_R = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        string middle_rotor = "FVPJIAOYEDRZXWGCTKUQSBNMHL";
        string alphabet_rotor_M = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        string left_rotor = "RDOBJNTKVEHMLFCWZAXGYIPSUQ";
        string alphabet_rotor_L = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //-----------------------------------------------------------

        string alphabet_rotor = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        string alphabet_rotor_10 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_10 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";

        string alphabet_rotor_9 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_9 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";

        string alphabet_rotor_8 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_8 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";

        string alphabet_rotor_7 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_7 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";

        string alphabet_rotor_6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_6 = "VZBRGITYUPSDNHLXAWMJQOFECK";

        string alphabet_rotor_5 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_5 = "JPGVOUMFYQBENHZRDKASXLICTW";

        string alphabet_rotor_4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_4 = "NZJHGRCXMYSWBOUFAIVLPEKQDT";

        string alphabet_rotor_3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_3 = "FKQHTLXOCBJSPDZRAMEWNIUYGV";

        string alphabet_rotor_2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_2 = "YRUHQSLDPXNGOKMIEBFZCWVJAT";

        string alphabet_rotor_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rotor_1 = "FSOKANUERHMBTIYCWLQPZXVGJD";

        //ABCDEFGHIJKLMNOPQRSTUVWXYZ
        string reverse_rotor = "YRUHQSLDPXNGOKMIEBFZCWVJAT";

        string message = "";
        string cryptogram = "";
        string cryptogram_key = "";
        string decryptogram = "";
        string decryptogram_key = "";
        string klucz = "";
        string klucz_key = "";
        int index;
        string final = "";

        Attachment attachment = null;
        //-----------------------------------------------------------------------------------
        void RotateRotor(string rotor)
        {
            char[] shiftedChars = new char[26];
            for (int i = 0; i < 26; i++)
            {
                int index = (i + 1) % 26;
                shiftedChars[i] = rotor[index];
            }
            rotor = "";
            rotor = new string(shiftedChars);
        }
        //----------------------------------------------------------------------------------
        public int FindIndex(char letter, string rotor)
        {       
            for (int i = 0; i < 26; i++)
            {
                if (letter == rotor[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        //-----------------------------------------------------------------------------------
        void SetRotor(string rotor, string key, int key_char)
        {
            char[] shiftedChars = new char[26];
            for (int i = 0; i < 26; i++)
            {
                int index = (i + FindIndex(key[key_char],alphabet_rotor)) % 26;
                shiftedChars[i] = rotor[index];
            }
            rotor = "";
            rotor = new string(shiftedChars);
        }
        //-----------------------------------------------------------------------------------
        string MergeCryptograms(string cryptogram, string cryptogram_key)
        {
            string merged = "";

            if(cryptogram.Length > 30)
            {
                StringBuilder sb = new StringBuilder(cryptogram);
                sb.Insert(cryptogram.Length - 1, cryptogram_key[0]); //2
                merged = sb.ToString();
                sb.Insert(merged.Length - 2, cryptogram_key[1]); //3
                merged = sb.ToString();
                sb.Insert(merged.Length - 4, cryptogram_key[2]); //5
                merged = sb.ToString();
                sb.Insert(merged.Length - 6, cryptogram_key[3]); //7
                merged = sb.ToString();
                sb.Insert(merged.Length - 10, cryptogram_key[4]); //11
                merged = sb.ToString();
                sb.Insert(merged.Length - 12, cryptogram_key[5]); //13
                merged = sb.ToString();
                sb.Insert(merged.Length - 16, cryptogram_key[6]); //17
                merged = sb.ToString();
                sb.Insert(merged.Length - 18, cryptogram_key[7]); //19
                merged = sb.ToString();
                sb.Insert(merged.Length - 22, cryptogram_key[8]); //23
                merged = sb.ToString();
                sb.Insert(merged.Length - 28, cryptogram_key[9]); //29

                merged = sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder(cryptogram);
                sb.Insert(cryptogram.Length - 1, cryptogram_key[0]); //2
                merged = sb.ToString();
                sb.Insert(merged.Length - 2, cryptogram_key[1]); //3
                merged = sb.ToString();
                sb.Insert(merged.Length - 4, cryptogram_key[2]); //5
                merged = sb.ToString();
                sb.Insert(merged.Length - 6, cryptogram_key[3]); //7
                merged = sb.ToString();
                sb.Insert(0, cryptogram_key[4]); //11
                merged = sb.ToString();
                sb.Insert(0, cryptogram_key[5]); //13
                merged = sb.ToString();
                sb.Insert(0, cryptogram_key[6]); //17
                merged = sb.ToString();
                sb.Insert(0, cryptogram_key[7]); //19
                merged = sb.ToString();
                sb.Insert(0, cryptogram_key[8]); //23
                merged = sb.ToString();
                sb.Insert(0, cryptogram_key[9]); //29

                merged = sb.ToString();
            }
            
            return merged;
        }

        string UnMergeCryptograms(string cryptogram_full)
        {
            string key = "";
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            string e = "";
            string f = "";
            string g = "";
            string h = "";
            string i = "";
            string j = "";

            if (cryptogram_full.Length - 10 > 30)
            {
                a = cryptogram_full.Substring(cryptogram_full.Length - 2, 1);
                key += a;

                b = cryptogram_full.Substring(cryptogram_full.Length - 3, 1);
                key += b;

                c = cryptogram_full.Substring(cryptogram_full.Length - 5, 1);
                key += c;

                d = cryptogram_full.Substring(cryptogram_full.Length - 7, 1);
                key += d;

                e = cryptogram_full.Substring(cryptogram_full.Length - 11, 1);
                key += e;

                f = cryptogram_full.Substring(cryptogram_full.Length - 13, 1);
                key += f;

                g = cryptogram_full.Substring(cryptogram_full.Length - 17, 1);
                key += g;

                h = cryptogram_full.Substring(cryptogram_full.Length - 19, 1);
                key += h;

                i = cryptogram_full.Substring(cryptogram_full.Length - 23, 1);
                key += i;

                j = cryptogram_full.Substring(cryptogram_full.Length - 29, 1);
                key += j;

                int[] positionsToremove = { cryptogram_full.Length - 2, cryptogram_full.Length - 3, cryptogram_full.Length - 5, cryptogram_full.Length - 7, cryptogram_full.Length - 11, cryptogram_full.Length - 13, cryptogram_full.Length - 17, cryptogram_full.Length - 19, cryptogram_full.Length - 23, cryptogram_full.Length - 29 };
                for (int x = 0; x < cryptogram_full.Length; x++)
                {
                    if (!positionsToremove.Contains(x))
                    {
                        cryptogram += cryptogram_full.Substring(x, 1);
                    }
                }
            }
            else
            {
                a = cryptogram_full.Substring(cryptogram_full.Length - 2, 1);
                key += a;

                b = cryptogram_full.Substring(cryptogram_full.Length - 3, 1);
                key += b;

                c = cryptogram_full.Substring(cryptogram_full.Length - 5, 1);
                key += c;

                d = cryptogram_full.Substring(cryptogram_full.Length - 7, 1);
                key += d;

                //5
                e = cryptogram_full.Substring(5, 1);
                key += e;

                f = cryptogram_full.Substring(4, 1);
                key += f;

                g = cryptogram_full.Substring(3, 1);
                key += g;

                h = cryptogram_full.Substring(2, 1);
                key += h;

                i = cryptogram_full.Substring(1, 1);
                key += i;

                j = cryptogram_full.Substring(0, 1);
                key += j;

                int[] positionsToremove = { cryptogram_full.Length - 2, cryptogram_full.Length - 3, cryptogram_full.Length - 5, cryptogram_full.Length - 7, 5, 4, 3, 2, 1, 0 };
                for (int x = 0; x < cryptogram_full.Length; x++)
                {
                    if (!positionsToremove.Contains(x))
                    {
                        cryptogram += cryptogram_full.Substring(x, 1);
                    }
                }

            }
            

            return key;
        }

        //-----------------------------------------------------------------------------------
        public void EncryptKey(string key_E)
        {
            char letter;

            for (int i = 0; i < key_E.Length; i++)
            {
                letter = key_E[i];

                //1. right rotor
                letter = right_rotor[FindIndex(letter, alphabet_rotor_R)];

                //2. middle rotor
                letter = middle_rotor[FindIndex(letter, alphabet_rotor_M)];

                //3. left rotor
                letter = left_rotor[FindIndex(letter, alphabet_rotor_L)];

                //4. reverse rotor
                letter = reverse_rotor[FindIndex(letter, alphabet_rotor)];

                //5. left rotor
                letter = alphabet_rotor_L[FindIndex(letter, left_rotor)];

                //6. middle rotor
                letter = alphabet_rotor_M[FindIndex(letter, middle_rotor)];

                //7. right rotor
                letter = alphabet_rotor_R[FindIndex(letter, right_rotor)];

                cryptogram_key += letter;
                letter = ' ';

                RotateRotor(alphabet_rotor_R);
                if (alphabet_rotor_R[0] == 'K') RotateRotor(alphabet_rotor_M);
                if (alphabet_rotor_M[0] == 'R') RotateRotor(alphabet_rotor_L);
            }
        }
        //-----------------------------------------------------------------------------------
        private void message_txtbox_TextChanged(object sender, EventArgs e)
        {
            message_txtbox.Text = message_txtbox.Text.ToUpper();
            message_txtbox.SelectionStart = message_txtbox.Text.Length;
        }
        //-----------------------------------------------------------------------------------
        private void key0_txtbox_TextChanged(object sender, EventArgs e)
        {
            key0_txtbox.Text = key0_txtbox.Text.ToUpper();
            key0_txtbox.SelectionStart = key0_txtbox.Text.Length;
            key1_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key1_txtbox_TextChanged(object sender, EventArgs e)
        {
            key1_txtbox.Text = key1_txtbox.Text.ToUpper();
            key1_txtbox.SelectionStart = key1_txtbox.Text.Length;
            key2_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key2_txtbox_TextChanged(object sender, EventArgs e)
        {
            key2_txtbox.Text = key2_txtbox.Text.ToUpper();
            key2_txtbox.SelectionStart = key2_txtbox.Text.Length;
            key3_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-----------------------------------------------------------------------------------
        private void clear_btn_Click(object sender, EventArgs e)
        {
            message_txtbox.Text = "";
            key0_txtbox.Text = "";
            key1_txtbox.Text = "";
            key2_txtbox.Text = "";
            key3_txtbox.Text = "";
            key4_txtbox.Text = "";
            key5_txtbox.Text = "";
            key6_txtbox.Text = "";
            key7_txtbox.Text = "";
            key8_txtbox.Text = "";
            key9_txtbox.Text = "";

            key0_K_txtbox.Text = "";
            key1_K_txtbox.Text = "";
            key2_K_txtbox.Text = "";

            alphabet_rotor_R = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_M = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_L = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            alphabet_rotor_10 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_9 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_8 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_7 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_5 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Random random = new Random();
            //string shuffledAlphabet = new string(alphabet.OrderBy(x => random.Next()).ToArray());
            //label4.Text = shuffledAlphabet;

            password_txtbox.Text = "";
            login_txtbox.Text = "";
            receiver_txtbox.Text = "";
            sender_txtbox.Text = "";
            mailboxes_cb.Text = "";
            filename_label.Text = "";
            filename_label.Visible = false;
            message_ok_label.Visible = false;
        }

        void Encrypt(string message_E)
        {
            char letter;
            int index;

            for (int i = 0; i < message_E.Length; i++)
            {
                letter = message_E[i];

                //1. 10 rotor
                letter = rotor_10[FindIndex(letter, alphabet_rotor_10)];

                //2. 9 rotor
                letter = rotor_9[FindIndex(letter, alphabet_rotor_9)];

                //3. 8 rotor
                letter = rotor_8[FindIndex(letter, alphabet_rotor_8)];

                //4. 7 rotor
                letter = rotor_7[FindIndex(letter, alphabet_rotor_7)];

                //5. 6 rotor
                letter = rotor_6[FindIndex(letter, alphabet_rotor_6)];

                //6. 5 rotor
                letter = rotor_5[FindIndex(letter, alphabet_rotor_5)];

                //7. 4 rotor
                letter = rotor_4[FindIndex(letter, alphabet_rotor_4)];

                //8. 3 rotor
                letter = rotor_3[FindIndex(letter, alphabet_rotor_3)];

                //9. 2 rotor
                letter = rotor_2[FindIndex(letter, alphabet_rotor_2)];

                //10. 1 rotor
                letter = rotor_1[FindIndex(letter, alphabet_rotor_1)];

                //11. reverse rotor
                letter = reverse_rotor[FindIndex(letter, alphabet_rotor)];

                //12. 1 rotor
                letter = alphabet_rotor_1[FindIndex(letter, rotor_1)];

                //13. 2 rotor
                letter = alphabet_rotor_2[FindIndex(letter, rotor_2)];

                //14. 3 rotor
                letter = alphabet_rotor_3[FindIndex(letter, rotor_3)];

                //15. 4 rotor
                letter = alphabet_rotor_4[FindIndex(letter, rotor_4)];

                //16. 5 rotor
                letter = alphabet_rotor_5[FindIndex(letter, rotor_5)];

                //17. 6 rotor
                letter = alphabet_rotor_6[FindIndex(letter, rotor_6)];

                //18. 7 rotor
                letter = alphabet_rotor_7[FindIndex(letter, rotor_7)];

                //19. 8 rotor
                letter = alphabet_rotor_8[FindIndex(letter, rotor_8)];

                //20. 9 rotor
                letter = alphabet_rotor_9[FindIndex(letter, rotor_9)];

                //21. 10 rotor
                letter = alphabet_rotor_10[FindIndex(letter, rotor_10)];

                cryptogram += letter;
                letter = ' ';

                RotateRotor(alphabet_rotor_10);
                if (alphabet_rotor_10[0] == 'F') RotateRotor(alphabet_rotor_9);
                if (alphabet_rotor_9[0] == 'C' || alphabet_rotor_9[0] == 'V') RotateRotor(alphabet_rotor_8);
                if (alphabet_rotor_8[0] == 'B' || alphabet_rotor_8[0] == 'L' || alphabet_rotor_8[0] == 'Y') RotateRotor(alphabet_rotor_7);
                if (alphabet_rotor_7[0] == 'M' || alphabet_rotor_7[0] == 'D' || alphabet_rotor_7[0] == 'R' || alphabet_rotor_7[0] == 'G') RotateRotor(alphabet_rotor_6);
                if (alphabet_rotor_6[0] == 'Q' || alphabet_rotor_6[0] == 'S' || alphabet_rotor_6[0] == 'A' || alphabet_rotor_6[0] == 'J') RotateRotor(alphabet_rotor_5);
            }
        }
        //--------------------------------------------------------------------
        void Decrypt(string message_D)
        {
            char letter;
            int index;

            for (int i = 0; i < message_D.Length; i++)
            {
                letter = message_D[i];

                //1. 10 rotor
                letter = rotor_10[FindIndex(letter, alphabet_rotor_10)];

                //2. 9 rotor
                letter = rotor_9[FindIndex(letter, alphabet_rotor_9)];

                //3. 8 rotor
                letter = rotor_8[FindIndex(letter, alphabet_rotor_8)];

                //4. 7 rotor
                letter = rotor_7[FindIndex(letter, alphabet_rotor_7)];

                //5. 6 rotor
                letter = rotor_6[FindIndex(letter, alphabet_rotor_6)];

                //6. 5 rotor
                letter = rotor_5[FindIndex(letter, alphabet_rotor_5)];

                //7. 4 rotor
                letter = rotor_4[FindIndex(letter, alphabet_rotor_4)];

                //8. 3 rotor
                letter = rotor_3[FindIndex(letter, alphabet_rotor_3)];

                //9. 2 rotor
                letter = rotor_2[FindIndex(letter, alphabet_rotor_2)];

                //10. 1 rotor
                letter = rotor_1[FindIndex(letter, alphabet_rotor_1)];

                //11. reverse rotor
                letter = reverse_rotor[FindIndex(letter, alphabet_rotor)];

                //12. 1 rotor
                letter = alphabet_rotor_1[FindIndex(letter, rotor_1)];

                //13. 2 rotor
                letter = alphabet_rotor_2[FindIndex(letter, rotor_2)];

                //14. 3 rotor
                letter = alphabet_rotor_3[FindIndex(letter, rotor_3)];

                //15. 4 rotor
                letter = alphabet_rotor_4[FindIndex(letter, rotor_4)];

                //16. 5 rotor
                letter = alphabet_rotor_5[FindIndex(letter, rotor_5)];

                //17. 6 rotor
                letter = alphabet_rotor_6[FindIndex(letter, rotor_6)];

                //18. 7 rotor
                letter = alphabet_rotor_7[FindIndex(letter, rotor_7)];

                //19. 8 rotor
                letter = alphabet_rotor_8[FindIndex(letter, rotor_8)];

                //20. 9 rotor
                letter = alphabet_rotor_9[FindIndex(letter, rotor_9)];

                //21. 10 rotor
                letter = alphabet_rotor_10[FindIndex(letter, rotor_10)];

                decryptogram += letter;
                letter = ' ';

                RotateRotor(alphabet_rotor_10);
                if (alphabet_rotor_10[0] == 'F') RotateRotor(alphabet_rotor_9);
                if (alphabet_rotor_9[0] == 'C' || alphabet_rotor_9[0] == 'V') RotateRotor(alphabet_rotor_8);
                if (alphabet_rotor_8[0] == 'B' || alphabet_rotor_8[0] == 'L' || alphabet_rotor_8[0] == 'Y') RotateRotor(alphabet_rotor_7);
                if (alphabet_rotor_7[0] == 'M' || alphabet_rotor_7[0] == 'D' || alphabet_rotor_7[0] == 'R' || alphabet_rotor_7[0] == 'G') RotateRotor(alphabet_rotor_6);
                if (alphabet_rotor_6[0] == 'Q' || alphabet_rotor_6[0] == 'S' || alphabet_rotor_6[0] == 'A' || alphabet_rotor_6[0] == 'J') RotateRotor(alphabet_rotor_5);
            }
        }

        //-----------------------------------------------------------------------------------
        private void Szyfr_btn_Click(object sender, EventArgs e)
        {
            klucz = key0_txtbox.Text + key1_txtbox.Text + key2_txtbox.Text + key3_txtbox.Text + key4_txtbox.Text + key5_txtbox.Text + key6_txtbox.Text + key7_txtbox.Text + key8_txtbox.Text + key9_txtbox.Text;
            klucz_key = key0_K_txtbox.Text + key1_K_txtbox.Text + key2_K_txtbox.Text;

            SetRotor(alphabet_rotor_L, klucz_key, 0);
            SetRotor(alphabet_rotor_M, klucz_key, 1);
            SetRotor(alphabet_rotor_R, klucz_key, 2);

            SetRotor(alphabet_rotor_10, klucz, 0);
            SetRotor(alphabet_rotor_9, klucz, 1);
            SetRotor(alphabet_rotor_8, klucz, 2);
            SetRotor(alphabet_rotor_7, klucz, 3);
            SetRotor(alphabet_rotor_6, klucz, 4);
            SetRotor(alphabet_rotor_5, klucz, 5);
            SetRotor(alphabet_rotor_4, klucz, 6);
            SetRotor(alphabet_rotor_3, klucz, 7);
            SetRotor(alphabet_rotor_2, klucz, 8);
            SetRotor(alphabet_rotor_1, klucz, 9);

            message = message_txtbox.Text;

            Encrypt(message);
            EncryptKey(klucz);

            //---------------------------------------------------------
            //combine cryptogram and cryptogram key

            string final_cryptogram = MergeCryptograms(cryptogram,cryptogram_key);
            final = final_cryptogram;

            message_txtbox.Text = final_cryptogram;

            //---------------------------------------------------------

            // create a new instance of the save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // set the file filter and default extension
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = "txt";

            // show the dialog box and get the result
            DialogResult result = saveFileDialog1.ShowDialog();

            // if the user clicked OK
            if (result == DialogResult.OK)
            {
                // get the file path from the dialog box
                string filePath = saveFileDialog1.FileName;

                // write the text to the file
                File.WriteAllText(filePath, final_cryptogram);
            }

            alphabet_rotor_R = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_M = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_L = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            alphabet_rotor_10 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_9 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_8 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_7 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_5 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        //-----------------------------------------------------------------------------------
        public void DecryptKey(string key_D)
        {
            char letter;

            for (int i = 0; i < key_D.Length; i++)
            {
                letter = key_D[i];

                //1. right rotor
                letter = right_rotor[FindIndex(letter, alphabet_rotor_R)];

                //2. middle rotor
                letter = middle_rotor[FindIndex(letter, alphabet_rotor_M)];

                //3. left rotor
                letter = left_rotor[FindIndex(letter, alphabet_rotor_L)];

                //4. reverse rotor
                letter = alphabet_rotor[FindIndex(letter, reverse_rotor)];

                //5. left rotor
                letter = alphabet_rotor_L[FindIndex(letter, left_rotor)];

                //6. middle rotor
                letter = alphabet_rotor_M[FindIndex(letter, middle_rotor)];

                //7. right rotor
                letter = alphabet_rotor_R[FindIndex(letter, right_rotor)];

                decryptogram_key += letter;
                letter = ' ';

                RotateRotor(alphabet_rotor_R);
            }
        }
        //-----------------------------------------------------------------------------------
        private void get_from_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select a text file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                message_txtbox.Text = fileContent;
            }
        }
        //-----------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            klucz_key = key0_K_txtbox.Text + key1_K_txtbox.Text + key2_K_txtbox.Text;

            SetRotor(alphabet_rotor_L, klucz_key, 0);
            SetRotor(alphabet_rotor_M, klucz_key, 1);
            SetRotor(alphabet_rotor_R, klucz_key, 2);

            //key = wczytanie klucza???
            string encrypted_key = UnMergeCryptograms(message_txtbox.Text);
            DecryptKey(encrypted_key);

            //message_txtbox.Text = decryptogram_key;

            SetRotor(alphabet_rotor_10, decryptogram_key, 0);
            SetRotor(alphabet_rotor_9, decryptogram_key, 1);
            SetRotor(alphabet_rotor_8, decryptogram_key, 2);
            SetRotor(alphabet_rotor_7, decryptogram_key, 3);
            SetRotor(alphabet_rotor_6, decryptogram_key, 4);
            SetRotor(alphabet_rotor_5, decryptogram_key, 5);
            SetRotor(alphabet_rotor_4, decryptogram_key, 6);
            SetRotor(alphabet_rotor_3, decryptogram_key, 7);
            SetRotor(alphabet_rotor_2, decryptogram_key, 8);
            SetRotor(alphabet_rotor_1, decryptogram_key, 9);

            //cryptogram = message_txtbox.Text;

            //DecryptKey(klucz_key);
            Decrypt(cryptogram);
            message_txtbox.Text = decryptogram;

            alphabet_rotor_R = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_M = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_L = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            alphabet_rotor_10 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_9 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_8 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_7 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_5 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet_rotor_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        //-----------------------------------------------------------------------------------
        private void key0_K_txtbox_TextChanged(object sender, EventArgs e)
        {
            key0_K_txtbox.Text = key0_K_txtbox.Text.ToUpper();
            key0_K_txtbox.SelectionStart = key0_K_txtbox.Text.Length;
            key1_K_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key1_K_txtbox_TextChanged(object sender, EventArgs e)
        {
            key1_K_txtbox.Text = key1_K_txtbox.Text.ToUpper();
            key1_K_txtbox.SelectionStart = key1_K_txtbox.Text.Length;
            key2_K_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key2_K_txtbox_TextChanged(object sender, EventArgs e)
        {
            key2_K_txtbox.Text = key2_K_txtbox.Text.ToUpper();
            key2_K_txtbox.SelectionStart = key2_K_txtbox.Text.Length;
        }
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        private void key3_txtbox_TextChanged(object sender, EventArgs e)
        {
            key3_txtbox.Text = key3_txtbox.Text.ToUpper();
            key3_txtbox.SelectionStart = key3_txtbox.Text.Length;
            key4_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key4_txtbox_TextChanged(object sender, EventArgs e)
        {
            key4_txtbox.Text = key4_txtbox.Text.ToUpper();
            key4_txtbox.SelectionStart = key4_txtbox.Text.Length;
            key5_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key5_txtbox_TextChanged(object sender, EventArgs e)
        {
            key5_txtbox.Text = key5_txtbox.Text.ToUpper();
            key5_txtbox.SelectionStart = key5_txtbox.Text.Length;
            key6_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key6_txtbox_TextChanged(object sender, EventArgs e)
        {
            key6_txtbox.Text = key6_txtbox.Text.ToUpper();
            key6_txtbox.SelectionStart = key6_txtbox.Text.Length;
            key7_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key7_txtbox_TextChanged(object sender, EventArgs e)
        {
            key7_txtbox.Text = key7_txtbox.Text.ToUpper();
            key7_txtbox.SelectionStart = key7_txtbox.Text.Length;
            key8_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key8_txtbox_TextChanged(object sender, EventArgs e)
        {
            key8_txtbox.Text = key8_txtbox.Text.ToUpper();
            key8_txtbox.SelectionStart = key8_txtbox.Text.Length;
            key9_txtbox.Focus();
        }
        //-----------------------------------------------------------------------------------
        private void key9_txtbox_TextChanged(object sender, EventArgs e)
        {
            key9_txtbox.Text = key9_txtbox.Text.ToUpper();
            key9_txtbox.SelectionStart = key9_txtbox.Text.Length;
        }
        //-----------------------------------------------------------------------------------
        private void message_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy naciśnięty klawisz jest jednym z dozwolonych znaków
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Zatrzymaj zdarzenie, aby nie wprowadzać nieprawidłowego znaku do pola tekstowego
                e.Handled = true;
            }
            if (e.KeyChar >= 'Ą' && e.KeyChar <= 'Ż')
            {
                e.Handled = true;
                return;
            }
        }
        //-----------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
        //-----------------------------------------------------------------------------------
        private void send_btn_Click(object sender, EventArgs e)
        {
            string to = receiver_txtbox.Text;
            string from = sender_txtbox.Text;
            string subject = "wiadomość";
            string body = final;

            MailMessage message = new MailMessage(from, to, subject, body);

            string SmtpClient = "";

            switch(mailboxes_cb.Text)
            {
                case "Gmail": SmtpClient = "smtp.gmail.com"; break;
                case "Interia": SmtpClient = "smtp.poczta.interia.pl"; break;
                case "Onet": SmtpClient = "smtp.poczta.onet.pl"; break;
                case "WP": SmtpClient = "smtp.wp.pl"; break;
            }

            if (attachment != null)
            {
                message.Attachments.Add(attachment);
            }

            SmtpClient client = new SmtpClient(SmtpClient);
            client.Port = 587;
            client.Credentials = new NetworkCredential(login_txtbox.Text, password_txtbox.Text);
            client.EnableSsl = true;
            client.Send(message);
            message_ok_label.Visible = true;
        }
        //-----------------------------------------------------------------------------------
        private void attachment_btn_Click(object sender, EventArgs e)
        {
            // Tworzymy kontrolkę OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Ustawiamy tytuł okna dialogowego
            openFileDialog.Title = "Wybierz plik do załączenia";

            // Ustawiamy domyślny folder, który będzie otwarty w oknie dialogowym
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Jeśli użytkownik kliknie przycisk OK, otwieramy plik i zapisujemy jako załącznik
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tworzymy załącznik dla wybranego pliku
                attachment = new Attachment(openFileDialog.FileName);
                filename_label.Text = openFileDialog.FileName;
                filename_label.Visible = true;
            }
        }
        //-----------------------------------------------------------------------------------
        private void delete_attachment_btn_Click(object sender, EventArgs e)
        {
            // Usuwamy załącznik z wiadomości e-mail
            if (attachment != null)
            {
                attachment.Dispose(); // zwalniamy zasoby załącznika
                attachment = null; // ustawiamy zmienną na null, aby usunąć załącznik z wiadomości
                filename_label.Text = "";
                filename_label.Visible = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------
    }
}
