using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoDesafio {
    class ClassificacaoAnimal {
        public ClassificacaoAnimal(string primeiroAnimal, string segundoAnimal, string terceiroAnimal) {
            if (primeiroAnimal == "vertebrado") {
                if (segundoAnimal == "ave") {
                    if (terceiroAnimal == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else {
                        Console.WriteLine("pomba");
                    }
                }
                else {
                    if (terceiroAnimal == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else {
                if (segundoAnimal == "inseto") {
                    if (terceiroAnimal == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else {
                        Console.WriteLine("lagarta");
                    }
                }
                else {
                    if (terceiroAnimal == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
