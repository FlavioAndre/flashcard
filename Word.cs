using System;
using System.Collections.Generic;
using System.Text;

namespace FlashCard
{
    class Word
    {
        private string palavraOrigem;

        public string PalavraOrigem
        {
            get { return palavraOrigem; }
            set { palavraOrigem = value; }
        }
        private string palavraTraduzida;

        public string PalavraTraduzida
        {
            get { return palavraTraduzida; }
            set { palavraTraduzida = value; }
        }

        private string fileSom;

        public string FileSom
        {
            get { return fileSom; }
            set { fileSom = value; }
        }


    }
    
}
