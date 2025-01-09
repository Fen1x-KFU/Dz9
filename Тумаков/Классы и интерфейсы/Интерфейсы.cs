using System;

namespace Tumakov
{
    interface ICipher
    {
        string Encode(string str); // Метод для шифрования строки
        string Decode(string str); // Метод для дешифрования строки
    }

    interface IShape
    {
        void MoveHorizontal(int distance);
        void MoveVertical(int distance);
        void ChangeColor(string color);
        void ToggleVisibility(string visible);
        void DisplayState();
    }

}
