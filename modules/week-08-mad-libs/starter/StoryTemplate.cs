/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Cedar Quarmby
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    public string GenerateStory(string[] words)
    {
        if (words.Length != Prompts.Length)
        {
            throw new Exception("Number of words does not match number of prompts.");
        }
        // - See line 42
        return FormatStory(words);
    }

    private string FormatStory(string[] words)
    {
        // - Adds the input words to the template sentence
        object[] values = words;
        return string.Format(TemplateText, values);
    }
}
