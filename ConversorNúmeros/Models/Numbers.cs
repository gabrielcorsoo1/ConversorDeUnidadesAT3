﻿namespace ConversorNúmeros.Models
{
    public class Numbers
    {
        public int myNumber = 925;
        public string myNumberInWords = String.Empty;

        public string WriteNumber(int numero) 
        {
            int size = numero.ToString().Length;
            string numberInWords = String.Empty;
            string checkedString = String.Empty; 
            bool unit = false;
            bool ten = false;
            bool hundred = false;

            foreach (char x in numero.ToString())
            {
                if (numberInWords.Length > 0)
                {
                    checkedString = " e ";
                }
                if (size == 4)
                {
                    if (x == '1') numberInWords += "um mil, ";
                    if (x == '2') numberInWords += "dois mil, ";
                    if (x == '3') numberInWords += "três mil, ";
                    if (x == '4') numberInWords += "quatro mil, ";
                    if (x == '5') numberInWords += "cinco mil, ";
                    if (x == '6') numberInWords += "seis mil, ";
                    if (x == '7') numberInWords += "sete mil, ";
                    if (x == '8') numberInWords += "oito mil, ";
                    if (x == '9') numberInWords += "nove mil, ";
                }
                else if (size == 3)
                {
                    if (x == '1') hundred = true;
                    if (x == '2') numberInWords += "duzentos";
                    if (x == '3') numberInWords += "trezentos";
                    if (x == '4') numberInWords += "quatrocentos";
                    if (x == '5') numberInWords += "quinhentos";
                    if (x == '6') numberInWords += "seissentos";
                    if (x == '7') numberInWords += "setessentos";
                    if (x == '8') numberInWords += "oitocentos";
                    if (x == '9') numberInWords += "novecentos";
                }
                else if (hundred && size == 2)
                {
                    if (x == '0')
                    {
                        unit = true;
                    }
                    if (x == '1')
                    {
                        ten = true;
                        numberInWords += "cento e ";
                    }
                    if (x == '2') numberInWords += "cento e vinte";
                    if (x == '3') numberInWords += "cento e trinta";
                    if (x == '4') numberInWords += "cento e quarenta";
                    if (x == '5') numberInWords += "cento e cinquenta";
                    if (x == '6') numberInWords += "cento e sessenta";
                    if (x == '7') numberInWords += "cento e setenta";
                    if (x == '8') numberInWords += "cento e oitenta";
                    if (x == '9') numberInWords += "cento e noventa";
                }
                else if (size == 2)
                {
                    if (x == '1') ten = true;
                    if (x == '2') numberInWords += checkedString + "vinte";
                    if (x == '3') numberInWords += checkedString + "trinta";
                    if (x == '4') numberInWords += checkedString + "quarenta";
                    if (x == '5') numberInWords += checkedString + "cinquenta";
                    if (x == '6') numberInWords += checkedString + "sessenta";
                    if (x == '7') numberInWords += checkedString + "setenta";
                    if (x == '8') numberInWords += checkedString + "oitenta";
                    if (x == '9') numberInWords += checkedString + "noventa";
                }
                else if (ten && size == 1)
                {
                    if (x == '0') numberInWords += checkedString + "dez";
                    if (x == '1') numberInWords += checkedString + "onze";
                    if (x == '2') numberInWords += checkedString + "doze";
                    if (x == '3') numberInWords += checkedString + "treze";
                    if (x == '4') numberInWords += checkedString + "quatorze";
                    if (x == '5') numberInWords += checkedString + "quinze";
                    if (x == '6') numberInWords += checkedString + "dezesseis";
                    if (x == '7') numberInWords += checkedString + "dezessete";
                    if (x == '8') numberInWords += checkedString + "dezoito";
                    if (x == '9') numberInWords += checkedString + "dezenove";
                }
                else if (unit && size == 1)
                {
                    if (x == '0') numberInWords += "cem";
                    if (x == '1') numberInWords += "cento e um";
                    if (x == '2') numberInWords += "cento e dois";
                    if (x == '3') numberInWords += "cento e três";
                    if (x == '4') numberInWords += "cento e quatro";
                    if (x == '5') numberInWords += "cento e cinco";
                    if (x == '6') numberInWords += "cento e seis";
                    if (x == '7') numberInWords += "cento e sete";
                    if (x == '8') numberInWords += "cento e oito";
                    if (x == '9') numberInWords += "cento e nove";
                }
                else if (size == 1)
                {
                    if (x == '1') numberInWords += checkedString + "um";
                    if (x == '2') numberInWords += checkedString + "dois";
                    if (x == '3') numberInWords += checkedString + "três";
                    if (x == '4') numberInWords += checkedString + "quatro";
                    if (x == '5') numberInWords += checkedString + "cinco";
                    if (x == '6') numberInWords += checkedString + "seis";
                    if (x == '7') numberInWords += checkedString + "sete";
                    if (x == '8') numberInWords += checkedString + "oito";
                    if (x == '9') numberInWords += checkedString + "nove";
                }

                size--;
            }

            return numberInWords;
        }
    }
}
