using AccessModifiers;
using System;

namespace AccessModifierInternal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Добавям от Dependencies достъп до AccessModifier и:
            //Event Ctrl+. и ни дава using AccessModifiers;
            //Ako Event не е публик, а например интърнал, както е по дефолт няма да имаме достъп до него!

            Event ev = new Event();
            //ev. нямам достъп до интернал филда, т. е. от другите проекти виждаме само публичните полета
        }
    }
}
