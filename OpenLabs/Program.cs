
//Teste 1 ================================
class Poligono
{

	protected float Area { get; set; }
	protected float Base { get; set; }
	protected float Altura { get; set; }
}

class Retangulo : Poligono
{

	public Retangulo ( float b, float a)
	{
		Base = b;
		Altura = a;
		Area = b * a;
	}
	public void Calcular ()
	{
		Console.WriteLine("Area Retangulo:" + Area);
	}
}

class Triangulo : Poligono
{
	public Triangulo(float a, float b)
    {
		Base = b;
		Altura = a;
		Area = a * b / 2;
    }
	public void Calcular()
    {
		Console.WriteLine("Area do Triangulo:" + Area);
    }
}


//Teste 3 =================================
class Funcao
{
	public int qualValorIssoImprime ( int n )
	{
		if ( n < 2 )
		{
			return n;
		}
		else
		{
			return qualValorIssoImprime(n - 1) + qualValorIssoImprime(n - 2);
		}
	}
}

public class Program
{
	public static void Main ()
	{
		//Teste1 ====================================================
		Retangulo ret = new Retangulo(30, 20);
		ret.Calcular();

		Triangulo tri = new Triangulo(30, 20);
		tri.Calcular ();

		//Teste 2  ==================================================
		int[] numbers = new int[] { -3, 8, 12, -5, 1, 4, 21, 13, 7 };
		//media
		Console.WriteLine("Média: " + numbers.Average());
		//maior numero
		Console.WriteLine("Maior numero: " + numbers.Max());
		//menor numero
		Console.WriteLine("Menor numero: " + numbers.Min());
		Console.Read();

		//Teste 3 ===================================================
		Funcao f = new Funcao();
		for ( int n = 0; n <= 8; n++ )
		{
			Console.Write(f.qualValorIssoImprime(n)); //saida: 01123581321
		}
	}
}