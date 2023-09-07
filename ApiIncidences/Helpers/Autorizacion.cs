namespace ApiIncidences.Helpers;

    public class Autorizacion
    {
        public enum Rols
        {
            Admin,
            Gerente,
            Administrativo,
            Trainer,
            Camper
        }
        public const Rols RolDefault = Rols.Administrativo;
    }
