/* El programa debe obtener:
El promedio general.
Cuántos alumnos aprobaron.
Cuántos reprobaron.
El alumno con la calificación más alta.
Mostrar qué alumnos reprobaron.
Considera:
Aprobado = calificación >= 70
Reprobado = calificación < 70
 */
partial class Program
{
    static void Exercise08()
    {
        List<string> alumnos = new List<string> { "Ana", "Luis", "María", "Carlos", "Sofía" };
        List<double> calificaciones = new List<double> { 85.5, 62, 95, 48, 73.5 };

        double suma = 0;
        int aprobados = 0;
        int reprobados = 0;
        double mejorAlumno = 0;
        int posicionMejorAlumno = 0;
        List<string> alumnosReprobados = new List<string>();
        List<double> calificacionesReprobados = new List<double>();

        for (int i = 0; i < calificaciones.Count; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] >= 70)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
                alumnosReprobados.Add(alumnos[i]);
                calificacionesReprobados.Add(calificaciones[i]);
            }

            if (calificaciones[i] > mejorAlumno)
            {
                mejorAlumno = calificaciones[i];
                posicionMejorAlumno = i;
            }
        }
        double promedio = suma / calificaciones.Count;

        WriteLine($"Promedio general: {promedio:F2}");
        WriteLine($"Alumnos aprobados: {aprobados}");
        WriteLine($"Alumnos reprobados: {reprobados}");
        WriteLine($"Mejor alumno(a): {alumnos[posicionMejorAlumno]} - Calificación: {mejorAlumno}");
        WriteLine($"Alumnos reprobados:");
        for (int i = 0; i < alumnosReprobados.Count; i++)
        {
            WriteLine($"{alumnosReprobados[i]} - {calificacionesReprobados[i]}");
        }
    }
}