# Notes App

## Overview
This is a simple Windows Forms Notes App built in C#. Users can:
- Add new notes (title + message)
- Read notes
- Delete notes
- Open a note in a second form (Form2) to view its contents
- Navigate back from Form2 to the main form

## Features Implemented
- **Add a Note**: Users can enter a title and message and save it to a list.
- **Read a Note**: Click "Read" to load the selected note into the text fields.
- **New Note Creation**: "New" button clears the text fields for creating another note.
- **Delete a Note**: Deletes the selected note and clears the text fields.
- **Open Note in Form2**: Displays the selected note on a separate form.
- **Go Back Button**: Closes Form2 and returns to the main form.
- **Error Handling**: Prevents adding empty notes and displays a warning.

## How to Run
1. Clone the repository.
2. Open the solution (`.sln`) in Visual Studio.
3. Build the project.
4. Run the application.
5. Use the main form to add, read, delete, and open notes in Form2.

## Demonstration
1. Enter a title and message in Form1.
2. Click "Save" to add the note.
3. Select the note in the list and click "Read" to view it.
4. Click "Open Second Form" to see the note displayed on Form2.
5. Click "Go Back" on Form2 to return to the main form.
6. Use "New" to start a new note, or "Delete" to remove a note.

## Project Structure
- **Form1.cs / Form1.Designer.cs** → Main notes form
- **Form2.cs / Form2.Designer.cs** → Secondary form to view notes
- **Program.cs** → Entry point for the application
