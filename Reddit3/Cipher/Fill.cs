using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    partial class Fill
    {
        public List<char> alphabet = new List<char>();

        public List<char> fill()
        {
            alphabet.Add(' ');
            alphabet.Add('a');
            alphabet.Add('b');
            alphabet.Add('c'); 
            alphabet.Add('d');
            alphabet.Add('e'); 
            alphabet.Add('f'); 
            alphabet.Add('g');
            alphabet.Add('h'); 
            alphabet.Add('i'); 
            alphabet.Add('j');
            alphabet.Add('k'); 
            alphabet.Add('l');
            alphabet.Add('m');
            alphabet.Add('n');
            alphabet.Add('o'); 
            alphabet.Add('p');
            alphabet.Add('q'); 
            alphabet.Add('r');
            alphabet.Add('s');
            alphabet.Add('t');
            alphabet.Add('u'); 
            alphabet.Add('v'); 
            alphabet.Add('w'); 
            alphabet.Add('x');
            alphabet.Add('y');
            alphabet.Add('z');
            
            return alphabet;
        }
    }
}
