using System;

public class EmpleadoAdministrativo : Empleado
{
    public decimal Bono { get; set; }

    public EmpleadoAdministrativo(string nombre, decimal sueldoBase, decimal bono)
        : base(nombre, sueldoBase)
    {
        // TODO: Inicializar el bono.
    }


}
