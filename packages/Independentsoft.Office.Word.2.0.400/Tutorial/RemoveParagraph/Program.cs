﻿using System;
using Independentsoft.Office.Word;
using Independentsoft.Office.Word.Tables;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDocument doc = new WordDocument("c:\\test\\input.docx");

            for (int i = 0; i < doc.Body.Content.Count; i++)
            {
                if (doc.Body.Content[i] is Paragraph)
                {
                    Paragraph paragraph = (Paragraph)doc.Body.Content[i];

                    String paragraphText = "";

                    foreach (IParagraphContent pContent in paragraph.Content)
                    {
                        if (pContent is Run)
                        {
                            Run run = (Run)pContent;

                            foreach (IRunContent rContent in run.Content)
                            {
                                if (rContent is Text)
                                {
                                    Text text = (Text)rContent;
                                    paragraphText += text.Value;
                                }
                            }
                        }
                    }

                    if (paragraphText.ToLower().IndexOf("remove me") > -1)
                    {
                        paragraph.Content.Clear();
                    }
                }
            }

            doc.Save("c:\\test\\output.docx", true);
        }
    }
}
