using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Praioou
{
    class Class1
    {
        private static ArrayList nome = new ArrayList();
        private static ArrayList senha = new ArrayList();
        private static ArrayList numTel = new ArrayList();
        private static ArrayList email = new ArrayList();
        private static ArrayList sexo = new ArrayList();
        private static ArrayList tipoperfil = new ArrayList();

        public static ArrayList Nome {
            get { return nome; }
            set { nome.Add(value); }
        }

        public static ArrayList Senha
        {
            get { return senha; }
            set { senha.Add(value); }
        }

        public static ArrayList NumTel
        {
            get { return numTel; }
            set { numTel.Add(value); }
        }

        public static ArrayList Email
        {
            get { return email; }
            set { email.Add(value); }
        }

        public static ArrayList Sexo
        {
            get { return sexo; }
            set { sexo.Add(value); }
        }
        public static ArrayList TipoPerfil
        {
            get { return tipoperfil; }
            set { tipoperfil.Add(value); }
        }

   

    }
}
