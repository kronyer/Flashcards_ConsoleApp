using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Enums
    {

        internal enum MainMenuChoices
        {
            ManageStacks,
            ManageFlashcards,
            StudySession,
            StudyHistory,
            Quit
        }

        internal enum StackChoices
        {
            ViewStacks,
            AddStack,
            DeleteStack,
            UpdateStack,
            Return
        }

        internal enum FlashcardChoices
        {
            ViewFlashcards,
            AddFlashcard,
            DeleteFlashcard,
            UpdateFlashcard,
            Return
        }

    }
}
