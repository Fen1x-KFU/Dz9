namespace Tumakov
{
    internal class ACipher : ICipher
    {
        public string Encode(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    charArray[i] = (char)(charArray[i] + 1);
                }
            }
            return new string(charArray);
        }

        public string Decode(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    charArray[i] = (char)(charArray[i] - 1);
                }
            }
            return new string(charArray);
        }
    }

    internal class BCipher : ICipher
    {
        public string Encode(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    if (char.IsLower(charArray[i]))
                    {
                        charArray[i] = (char)('z' - (char.ToLower(charArray[i]) - 'a'));
                    }
                    else
                    {
                        charArray[i] = (char)('Z' - (char.ToUpper(charArray[i]) - 'A'));
                    }
                }
            }
            return new string(charArray);
        }

        public string Decode(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    if (char.IsLower(charArray[i]))
                    {
                        charArray[i] = (char)('z' - (char.ToLower(charArray[i]) - 'a'));
                    }
                    else
                    {
                        charArray[i] = (char)('Z' - (char.ToUpper(charArray[i]) - 'A'));
                    }
                }
            }
            return new string(charArray);
        }
    }

    internal abstract class Figure : IShape
    {
        protected string color;
        protected string visible;

        public abstract void MoveHorizontal(int distance);
        public abstract void MoveVertical(int distance);
        public abstract void ChangeColor(string color);
        public abstract void ToggleVisibility(string visible);
        public abstract void DisplayState();
    }

    internal class Point : Figure
    {
        public int x;
        public int y;

        public override void MoveHorizontal(int distance)
        {
            // Реализация метода для передвижения точки по горизонтали
            this.x = distance;
        }

        public override void MoveVertical(int distance)
        {
            // Реализация метода для передвижения точки по вертикали
            this.y = distance;
        }

        public override void ChangeColor(string color)
        {
            // Реализация метода для изменения цвета точки
            this.color = color;
        }

        public override void ToggleVisibility(string visible)
        {
            // Реализация метода для переключения видимости точки
            this.visible = visible;
        }

        public override void DisplayState()
        {
            // Реализация метода для отображения состояния точки
            Console.WriteLine($"Цвет вашей фигуры: {this.color}");
            Console.WriteLine($"Ваша имеет видимость/невидимость: {this.visible}");
        }
    }

    internal class Circle : Point
    {
        public double CalculateArea(double r)
        {
            // Реализация метода для вычисления площади окружности
            double radius = Math.PI * r * r;
            return radius;
        }
    }

    internal class Rectangle : Point
    {
        public double CalculateArea(double a, double b)
        {
            // Реализация метода для вычисления площади прямоугольника
            double area = a * b;
            return area;
        }
    }

}
