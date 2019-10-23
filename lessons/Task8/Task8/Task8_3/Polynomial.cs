using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    /// <summary>
    /// Класс полиномов
    /// </summary>
    public class Polynomial
    {
        private readonly double[] coefficients;
        //  Создание полинома на основе коэффициентов.
        //<param name = "coefficients">Коэффициенты полинома.</param>
        public Polynomial(params double[] coefficients)
        {
            this.coefficients = coefficients;
        }
        //<param name = "n">Номер коэффициента.</param>
        //<returns>Значение коэффициента.</returns>
        public double this[int n]
        {
            get
            {
                if (n < 0) throw new ArgumentOutOfRangeException();
                if (n >= coefficients.Length) return 0;
                return coefficients[n];
            }
        }
        #region Методы класса Polynomial
        //  Степень*полинома.
        public int Order
        {
            get
            {
                return coefficients.Length - 1;
            }
        }
        //Копирование массива коэффициентов
        public double[] Copy()
        {
            double[] result = new double[coefficients.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = coefficients[i];
            }
            return result;
        }
        #endregion
        #region Переопределение методов Object
        public override string ToString()
        {
            string result = string.Empty;

            string[] _coefstring = new string[coefficients.Length];
            for (int i = 0; i < coefficients.Length; i++)
            {
                if (coefficients[i] != 0)
                    _coefstring[i] = coefficients[i].ToString();
                else _coefstring[i] = "";
                string znak = "";
                if (coefficients[i] > 0) znak = "+";
                if (coefficients[i] != 0)
                {
                    if (i > 1)
                        result += znak + _coefstring[i] + "x^" + i;
                    else if (i > 0) result += znak + _coefstring[i] + "x";
                    else result += znak + _coefstring[i];
                }
            }
            return result.TrimEnd(new char[] { '+', '-', ' ' }).TrimStart('+');
        }
        public override bool Equals(object obj)
        {
            Polynomial polynomial = obj as Polynomial;
            if (polynomial.coefficients.Length != this.coefficients.Length)
            {
                return false;
            }
            for (int i = 0; i < polynomial.coefficients.Length; i++)
            {
                if (polynomial[i] != this[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
        #region Вычитание(-)полиномов.
        public static Polynomial operator -(Polynomial pFirst, Polynomial pSecond)
        {
            int resultorder = Math.Max(pFirst.Order + 1, pSecond.Order + 1);
            double[] resultpolynom = new double[resultorder];
            for (int i = 0; i < resultorder; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst.coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond.coefficients.Length)
                {
                    b = pSecond[i];
                }
                resultpolynom[i] = a - b;
            }
            return new Polynomial(resultpolynom);
        }
        public static Polynomial operator -(Polynomial polynomial, double number)
        {
            double[] resultpolynom = polynomial.Copy();
            resultpolynom[0] -= number;
            return new Polynomial(resultpolynom);
        }
        public static Polynomial operator -(double number, Polynomial polynomial)
        {
            double[] resultpolynom = polynomial.Copy();
            resultpolynom[0] = number - resultpolynom[0];
            for (int i = 1; i < resultpolynom.Length; i++)
            {
                resultpolynom[i] = -resultpolynom[i];
            }
            return new Polynomial(resultpolynom);
        }
        #endregion
        #region Сложение(+)полиномов.
        public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
        {
            int resultorder = Math.Max(pFirst.Order + 1, pSecond.Order + 1);
            double[] resultpolynom = new double[resultorder];
            for (int i = 0; i < resultorder; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst.coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond.coefficients.Length)
                {
                    b = pSecond[i];
                }
                resultpolynom[i] = a + b;
            }
            return new Polynomial(resultpolynom);
        }

        public static Polynomial operator +(double number, Polynomial polynomial)
        {
            double[] resultpolynom = polynomial.Copy();
            resultpolynom[0] += number;
            return new Polynomial(resultpolynom);
        }

        public static Polynomial operator +(Polynomial polynomial, double number)
        {
            return number + polynomial;
        }
        #endregion
        #region Умножение(*)полиномов

        public static Polynomial operator *(Polynomial pFirst, Polynomial pSecond)
        {
            int resultorder = pFirst.Order + pSecond.Order + 1;
            var resultpolynom = new double[resultorder];
            for (int i = 0; i < pFirst.coefficients.Length; i++)
            {
                for (int j = 0; j < pSecond.coefficients.Length; j++)
                {
                    resultpolynom[i + j] += pFirst[i] * pSecond[j];
                }
            }

            return new Polynomial(resultpolynom);
        }
        public static Polynomial operator *(Polynomial polynomial, double number)
        {
            double[] resultpolynom = polynomial.Copy();
            for (int i = 0; i < resultpolynom.Length; i++)
            {
                resultpolynom[i] = resultpolynom[i] * number;
            }
            return new Polynomial(resultpolynom);
        }
        public static Polynomial operator *(double number, Polynomial polynomial)
        {
            return polynomial * number;
        }
        #endregion
        #region Деление(/)полиномов
        /// <param name="pFirst">Делимое</param>
        /// <param name="pSecond">Делитель</param>
        /// <param name="quotient">Полином частного от деления</param> 
        /// <param name="remainder">Полином остаток от деления</param> 
        /// <returns></returns>
        public static string operator /(Polynomial pFirst, Polynomial pSecond)
        {
            if (pFirst.Order < pSecond.Order)
            {
                throw new ArgumentOutOfRangeException();
            }
            double[] remainder = pFirst.Copy();
            double[] quotient = new double[remainder.Length - pSecond.coefficients.Length + 1];
            for (int i = 0; i < quotient.Length; i++)
            {
                double coeff = remainder[remainder.Length - i - 1] / pSecond.coefficients[pSecond.Order];
                quotient[quotient.Length - i - 1] = coeff;
                for (int j = 0; j < pSecond.coefficients.Length; j++)
                {
                    remainder[remainder.Length - i - j - 1] -= coeff * pSecond.coefficients[pSecond.coefficients.Length - j - 1];
                }
            }
            string str = (new Polynomial(remainder).ToString() != "") ? $"+{new Polynomial(remainder)}" : "";
            return $"({pSecond.ToString()})({new Polynomial(quotient)}){str}";
        }

        public static Polynomial operator /(Polynomial polynomial, double number)
        {
            double[] resultpolynom = polynomial.Copy();
            for (int i = 0; i < resultpolynom.Length; i++)
            {
                resultpolynom[i] /= number;
            }
            return new Polynomial(resultpolynom);
        }
        public static Polynomial operator /(double number, Polynomial polynomial)
        {
            double[] resultpolynom = polynomial.Copy();
            for (int i = 0; i < resultpolynom.Length; i++)
            {
                if (resultpolynom[i] != 0)
                    resultpolynom[i] = number / resultpolynom[i];
            }
            return new Polynomial(resultpolynom);
        }
        #endregion
        #region Сравнение(==,!=)полиномов
        public static bool operator ==(Polynomial pFirst, Polynomial pSecond)
        {
            if (pFirst.coefficients.Length != pSecond.coefficients.Length)
            {
                return false;
            }
            for (int i = 0; i < pFirst.coefficients.Length; i++)
            {
                if (pFirst[i] != pSecond[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Polynomial pFirst, Polynomial pSecond)
        {
            return !(pFirst == pSecond);
        }
        #endregion

    }
}
