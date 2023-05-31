using System;
using System.IO;

class TextEditor
{
    private string currentText;
    private string clipboard;

    public TextEditor()
    {
        currentText = "";
        clipboard = "";
    }

    public void OpenFile(string filePath)
    {
        try
        {
            currentText = File.ReadAllText(filePath);
            Console.WriteLine("File opened successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void EditText(string newText)
    {
        currentText = newText;
    }

    public void SaveFile(string filePath)
    {
        try
        {
            File.WriteAllText(filePath, currentText);
            Console.WriteLine("File saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void CopyText()
    {
        clipboard = currentText;
        Console.WriteLine("Text copied to clipboard.");
    }

    public void CutText()
    {
        clipboard = currentText;
        currentText = "";
        Console.WriteLine("Text cut and copied to clipboard.");
    }

    public void PasteText()
    {
        currentText += clipboard;
        Console.WriteLine("Text pasted from clipboard.");
    }

    public void Undo()
    {
        // Assuming we can only undo the last action (editing or pasting)
        currentText = clipboard;
        clipboard = "";
        Console.WriteLine("Undo performed.");
    }

    public void Redo()
    {
        // Assuming we can only redo the last undone action
        clipboard = currentText;
        Console.WriteLine("Redo performed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Open file");
            Console.WriteLine("2. Edit text");
            Console.WriteLine("3. Save file");
            Console.WriteLine("4. Copy text");
            Console.WriteLine("5. Cut text");
            Console.WriteLine("6. Paste text");
            Console.WriteLine("7. Undo");
            Console.WriteLine("8. Redo");
            Console.WriteLine("9. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter file path: ");
                    string filePath = Console.ReadLine();
                    editor.OpenFile(filePath);
                    break;
                case 2:
                    Console.Write("Enter new text: ");
                    string newText = Console.ReadLine();
                    editor.EditText(newText);
                    break;
                case 3:
                    Console.Write("Enter file path: ");
                    filePath = Console.ReadLine();
                    editor.SaveFile(filePath);
                    break;
                case 4:
                    editor.CopyText();
                    break;
                case 5:
                    editor.CutText();
                    break;
                case 6:
                    editor.PasteText();
                    break;
                case 7:
                    editor.Undo();
                    break;
                case 8:
                    editor.Redo();
                    break;
                case 9:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

