using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_DelcaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quadrado obj1 = new quadrado();
            // obj1.Lado = 5;
            // obj1.ImprimiArea();

            //obj1.Lado = 15;
            //obj1.ImprimiArea();

            //quadrado obj2 = new quadrado();
            //obj2.Lado = 25;

            ///obj2.ImprimiArea();

            //Retangulo obj3 = new Retangulo();
            /// obj3.largura = 10;
            // obj3.altura = 5;
            // obj3.ImprimiArea();


            //circulo obj4 = new circulo();
            /// obj4.raio = 10;
            // obj4.ImprimiArea();

            //triangulo obj5 = new triangulo();
            //obj5.altura = 25.6;
            ///obj5.Base = 12.75;
            // obj5.ImprimiArea();

            //conta conta3 = new conta();
            //conta3.banco = 1;
            // conta3.agencia = "0001";
            // conta3.numero = "123";
            //conta3.saldo = 123;
            // conta3.limite = 10000;

            aluno alunoLuisGustavo = new aluno();

            alunoLuisGustavo.codigo = 1;
            alunoLuisGustavo.nome = "Luis Gustavo De Sousa Soeiro";
            alunoLuisGustavo.lancarNota(1, 8.6);
            alunoLuisGustavo.lancarNota(2,9.0);
            alunoLuisGustavo.lancarNota(3, 9.5);
            alunoLuisGustavo.lancarNota(4,10.0);

            Console.WriteLine($"Aluno {alunoLuisGustavo.nome} {alunoLuisGustavo.mencao()} com média de {alunoLuisGustavo.CalcularMedia():N2}");


        }
    }

    public class quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimiArea()
        {
            Console.WriteLine($"Quadrado com area de {Lado} possui uma Área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        public int largura;
        public int altura;

        public int CalcularArea()
        {
            int area = largura * altura;
            return area;
        }
        public void ImprimiArea()
        {
            Console.WriteLine($"Retângulo com Largura de {largura} = altura de {altura} possui uma Area de {CalcularArea()})");
        }
    }

    public class circulo
    {
        public double raio;


        public double CalcularArea()
        {
            double area = (raio * raio) * Math.PI;
            return area;
        }
        public void ImprimiArea()
        {

            Console.WriteLine($"circulo com raio de {raio}possui um aarea de {CalcularArea():N2}");
        }

    }
    public class triangulo
    {
        public double Base, altura;


        public double CalcularArea()
        {
            double area = (Base * altura) * Math.PI;
            return Base * altura / 2;
        }
        public void ImprimiArea()
        {

            Console.WriteLine($"triangulo com base de {Base}altura de {altura} {CalcularArea():N2}");
        }


    }

    public class conta
    {
        public int banco;
        public string agencia;
        public string numero;
        public double saldo;
        public double limite;

        public void Dpositar(double valor)
        {
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            saldo += valor;
        }
        public double consultar()
        {
            return saldo;
        }


    }

    public class aluno
    {

        public int codigo;
        public string nome;
        public double[] notas = new double[4];

        public void lancarNota (int trimestre, double nota)
        {
            notas[trimestre - 1] = nota;
        }

        public double CalcularMedia()
        {
            double media = 0;
            foreach (double nota in notas)
            {
                media += nota;
            }
            return media / 4.0;

        }
        public string mencao()
        {
            if (CalcularMedia() >= 5.0)
                return "aprovado";
            else
                return "Reporvado";
        }
       


   
    }






}
