// Message.cs
// Classe servant à gérer les messages affichés durant le déroulement du jeu.
// Programmé par Jean-Sébastien Campeau
// Le 23 février 2012

using System;
using System.Linq;

namespace SimVille
{
    /// <summary>
    /// Définit les messages de succès et d'erreur générés par l'application.
    /// </summary>
    [Serializable]
    public class Messages
    {
        /// <summary>
        /// Définit les identificateurs de messages. On utilise un enum pour
        /// éviter d'assigner le même Id à 2 messges différents et pour plus
        /// de clarté dans le code.
        /// </summary>
        public enum Id
        {
            MessageOk,
            ErreurProgrammation,
            ErreurFondInsuffisants,
            ErreurLocationInvalide,
            ErreurTropLoinEnergie,
            DesastreVerglas,
            DesastreSante,
            DesastreTremblementTerre,
            DesastreIncendie,
            DesastreEquipe,
            ChargementDriverBd,
            ConnexionBd,
            RequeteBd,
            ChargementOk,
            SauvegardeOk
        };

        /// <summary>
        /// Tableau contenant tous les messages
        /// </summary>
        private static string[] message;

        /// <summary>
        /// Constructeur. Initialise les message.
        /// </summary>
        static Messages()
        {
            message = new string[Enum.GetNames(typeof(Id)).Length];
        /*0*/    message[(int)Id.MessageOk] = "Opération effectuée!";
        /*1*/    message[(int)Id.ErreurProgrammation] = "Erreur de programmation.";
        /*2*/    message[(int)Id.ErreurFondInsuffisants] = "Fonds insuffisants pour réaliser cette opération.";
        /*3*/    message[(int)Id.ErreurLocationInvalide] = "Vous ne pouvez bâtir ce bâtiment à cet endroit.";
        /*4*/    message[(int)Id.ErreurTropLoinEnergie] = "Vous devez avoir une source d'énergie à une distance inférieure à 12.";
        /*5*/    message[(int)Id.DesastreVerglas] = "Tempête de verglas!  Des lignes électriques sont détruites.";
        /*6*/    message[(int)Id.DesastreSante] = "Reforme de la santé!  Des hôpitaux sont fermés.";
        /*7*/    message[(int)Id.DesastreTremblementTerre] = "Tremblement de terre!  Des zones résidentielles sont détruites.";
        /*8*/    message[(int)Id.DesastreIncendie] = "Un incendie affecte des zones commerciale!  Ces zones disparaissent.";
        /*9*/    message[(int)Id.DesastreEquipe] = "Votre équipe sportive locale déménage!  Votre stade est détruit.";
        }

        /// <summary>
        /// Permet d'accéder en lecture à un message à partir de son Id.
        /// </summary>
        public static string[] Message
        {
            get { return Messages.message; }
        }
    }
}


