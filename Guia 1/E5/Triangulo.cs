namespace E5
{
    public class Triangulo
    {
        static public bool EsEscaleno(int a, int b, int c){
            return a!=b&&b!=c;
        }

        static public bool EsIsosceles(int a, int b, int c){
            return a==c&&c!=b||a==b&&b!=c||b==c&&c!=a;
        }

        static public bool EsEquilatero(int a, int b, int c){
            return a==b&&b==c;
        }

        static public bool EsTrianguloRectangulo(int a, int b, int c){
            return (a*a+b*b)==(c*c);
        }
    }
}