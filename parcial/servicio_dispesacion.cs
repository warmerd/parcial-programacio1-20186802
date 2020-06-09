using System;
using System.Collections.Generic;
using System.Text;

namespace cajero_1er_parcial
{
    class proceso_dispensiones
    {
        public string modo_200_1000(int retiro)
        {
            int separador_1000; 
            int separador_200; 
            separador_1000 = retiro - retiro % 1000;
            separador_200 = retiro % 1000;
            if (retiro >= 1000)
            {

                separador_1000 = retiro - retiro % 1000;
                separador_200 = retiro % 1000;
                return "Usted ha recibido :" + separador_1000 / 1000 + " papeletas de 1000 y " + separador_200 / 200 + " papeletas de 200";
            }
            else
            {
                return "Usted ha recibido :" + separador_1000 / 1000 + " papeletas de 1000 y " + separador_200 / 200 + " papeletas de 200";
            }
        }
        public string modo_100_500(int retiro)
        {
            int separador_500; 
            int separador_100; 
            separador_500 = retiro - retiro % 500;
            separador_100 = retiro % 500;


            return "Usted ha recibido :" + separador_500 / 500 + " papeletas de 500 y " + separador_100 / 100 + " papeletas de 100";



        }

        public string modo_eficiente(int retiro)
        {
            
            int separador_1k, sepadaor_500, separador_200, separador_100;
            separador_1k = retiro / 1000;
            retiro = retiro % 1000;
            sepadaor_500 = retiro / 500;
            retiro = retiro % 500;
            separador_200 = retiro / 200;
            retiro = retiro % 200;
            separador_100 = retiro / 100;


            return "Usted ha  recibido :" + separador_1k + " papeletas de 1000 " + sepadaor_500 + " papeletas de 500 y " + separador_200 + " papeletas de 200 y " + separador_100 + " papeletas de 100";
        }
    }
}
