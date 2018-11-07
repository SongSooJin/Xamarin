using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteText
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
