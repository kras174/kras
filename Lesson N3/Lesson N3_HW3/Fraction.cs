using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N3_HW3
{
    public class Fraction
    {
        private int numerator;              // Числитель
        private int denominator;            // Знаменатель
        private int sign;                   // Знак

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }

            this.numerator = Math.Abs(numerator);
            this.denominator = Math.Abs(denominator);

            if (numerator * denominator < 0)
            {
                this.sign = -1;
            }
            else
            {
                this.sign = 1;
            }
        }

        // Возвращает наибольший общий делитель (Алгоритм Евклида)
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Возвращает наименьшее общее кратное
        private static int getLeastCommonMultiple(int a, int b)
        {
            return a * b / getGreatestCommonDivisor(a, b);
        }

        // Перегрузка оператора "+" для случая суммы двух дробей
        public static Fraction operator +(Fraction a, Fraction b)
        {
            // Наименьшее общее кратное знаменателей
            int leastCommonMultiple = getLeastCommonMultiple(a.denominator, b.denominator);

            // Дополнительный множитель к первой дроби
            int additionalMultiplierFirst = leastCommonMultiple / a.denominator;

            // Дополнительный множитель ко второй дроби
            int additionalMultiplierSecond = leastCommonMultiple / b.denominator;

            // Результат операции
            int operationResult = (a.numerator * additionalMultiplierFirst * a.sign) +
                                            (b.numerator * additionalMultiplierSecond * b.sign);

            return new Fraction(operationResult, a.denominator * additionalMultiplierFirst);
        }
        // Перегрузка оператора "-" для случая разности двух дробей
        public static Fraction operator -(Fraction a, Fraction b)
        {
            // Наименьшее общее кратное знаменателей
            int leastCommonMultiple = getLeastCommonMultiple(a.denominator, b.denominator);

            // Дополнительный множитель к первой дроби
            int additionalMultiplierFirst = leastCommonMultiple / a.denominator;

            // Дополнительный множитель ко второй дроби
            int additionalMultiplierSecond = leastCommonMultiple / b.denominator;

            // Результат операции
            int operationResult = (a.numerator * additionalMultiplierFirst * a.sign) -
                                            (b.numerator * additionalMultiplierSecond * b.sign);

            return new Fraction(operationResult, a.denominator * additionalMultiplierFirst);
        }

        // Перегрузка оператора "*" для случая произведения двух дробей
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * a.sign * b.numerator * b.sign, a.denominator * b.denominator);
        }

        // Перегрузка оператора "/" для случая деления двух дробей
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * b.GetReverse();
        }

        // Возвращает дробь, обратную данной
        private Fraction GetReverse()
        {
            return new Fraction(this.denominator * this.sign, this.numerator);
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            if (this.numerator == 0)
            {
                return "0";
            }

            string result;

            if (this.sign < 0)
            {
                result = "-";
            }
            else
            {
                result = "";
            }

            if (this.numerator == this.denominator)
            {
                return result + "1";
            }

            if (this.denominator == 1)
            {
                return result + this.numerator;
            }

            return result + this.numerator + "/" + this.denominator;
        }
    }
}
