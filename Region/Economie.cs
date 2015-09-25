using System;
using System.Linq;

namespace SimVille
{
    [Serializable]
    class Economie
    {
        
        //Déclaration des variables
        private static int argentBanque = 1000000;//1m au départ
        private static int revenuMensuel = 0;

        public Economie() {
        
        }
        
        public static int RevenuMensuel
        {
            get
            {
                return revenuMensuel;
            }
            set
            {
                revenuMensuel = value;
            }
        }

        public static int ArgentBanque
        {
            get
            {
                return argentBanque;
            }
            set
            {
                argentBanque = value;
            }
        }
    }
}
