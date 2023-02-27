using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StackDemo
{
    internal class MyStack
    {   
        /// <summary>
        /// Datenstruktur als Array
        /// </summary>
        /// 
        private int[] value; 

       
       
        
        /// <summary>
        /// aktuelle Stelle im Array, wo der letzte Wert gespeichert wurde
        /// </summary>
        /// <param name="size"></param>
        
        private int index; 

        
        /// <summary>
        /// Fügt ein neues Element zum Stack hinzu
        /// </summary>
       
            public MyStack(int size)
            {
                value = new int[size];
            }


        /// <summary>
        /// Fügt ein neues Elements hinzu
        /// </summary>

        public void Push(int value)
            {
                this.value[index++] = value;
            }

        /// <summary>
        /// gibt den zuletzt auf den Stack gelegten Wert zurück und löscht diesen
        /// </summary>


        public int Pop()
        {
            if (index == 0)
            {
                throw new InvalidOperationException("Der Stack ist leer.");
            }
            return value[--index];
        }


        /// <summary>
        /// vertauscht die obersten beiden Elemente auf dem Stack
        /// </summary>


        public void SwappXY()
        {
            if (index >= 1)
            {
                int temp = value[index];
                value[index] = value[index - 1];
                value[index - 1] = temp;
            }

        }

        /// <summary>
        ///  löscht alle Daten im Stack
        /// </summary>

        public void Clear()
        {
            index = -1; // Setzt den Index auf -1 zurück
            Array.Clear(value, 0, value.Length); // Leert das Array
        }


        /// <summary>
        ///  gibt zurück, ob der Stack leer ist
        /// </summary>

        public bool IsEmpty
        {
            get { return index == -1; }
        }

        /// <summary>
        ///  gibt zurück, ob der Stack voll ist
        /// </summary>


        public bool IsFull
        {
            get { return index == value.Length - 1; }
        }



        /// <summary>
        /// gibt den Inhalt des Stack als String zurück
        /// </summary>
        

        public override string ToString()
        {
            string result = "";

            for (int i = index; i >= 0; i--)
            {
                result += value[i].ToString() + " ";
            }

            return result.Trim();
        }













    }

            
 }

