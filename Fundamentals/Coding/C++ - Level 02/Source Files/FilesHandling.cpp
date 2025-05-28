#include <iostream>
#include <fstream>

using namespace std;

int main()
{
  // Create an fstream object for file operations
  fstream MyFile;

  // Open the file "MyFile.txt" in write mode (ios::out)
  MyFile.open("MyFile.txt", ios::out);

  // Check if the file was opened successfully
  if (MyFile.is_open())
  {
    // Write content to the file
    MyFile << "Hi, this is the first line\n";
    MyFile << "Hi, this is the second line\n";
    MyFile << "Hi, this is the third line\n";

    // Close the file to release resources
    MyFile.close();
    cout << "Successfully wrote to MyFile.txt" << endl; // Optional success message
  }
  else
  {
    cerr << "Error opening file MyFile.txt" << endl; // Error message if opening fails
  }

  return 0;
}


// Append Mode

/*
#include <iostream>
#include <fstream>

using namespace std;

int main() {
    // Create an fstream object for file operations
    fstream MyFile;

    // Open the file "MyFile.txt" in append mode (ios::out | ios::app)
    MyFile.open("MyFile.txt", ios::out | ios::app);

    // Check if the file was opened successfully
    if (MyFile.is_open()) {
        // Write content to the file (appending to existing content)
        MyFile << "Hi, this is a new line\n";
        MyFile << "Hi, this is another new line\n";

        cout << "Successfully appended to MyFile.txt" << endl; // Optional success message

        // Close the file to release resources
        MyFile.close();
    } else {
        cerr << "Error opening file MyFile.txt" << endl; // Error message if opening fails
    }

    return 0;
}
*/

// Read Mode

/*
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

// Function to print the contents of a file
void PrintFileContent(const string& fileName) {
    // Create an fstream object
    fstream MyFile;

    // Open the file in read mode (ios::in)
    MyFile.open(fileName, ios::in);

    // Check if the file was opened successfully
    if (MyFile.is_open()) {
        string line;

        // Read the file line by line using a while loop
        while (getline(MyFile, line)) {
            // Print each line to the console
            cout << line << endl;
        }

        // Close the file
        MyFile.close();
    } else {
        cerr << "Error opening file: " << fileName << endl;
    }
}

int main() {
    // Call the PrintFileContent function with the filename
    PrintFileContent("MyFile.txt");

    return 0;
}

*/


// Load file to vector

/*
#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

void LoadDataFromFileToVector(string FileName, vector<string>& vFileContent) {
    fstream MyFile;
    MyFile.open(FileName, ios::in);
    if (MyFile.is_open()) {
        string Line;
        while (getline(MyFile, Line)) {
            vFileContent.push_back(Line);
        }
        MyFile.close();
    }
}

int main() {
    vector<string> vFileContenet;
    LoadDataFromFileToVector("MyFile.txt", vFileContenet);
    for (string &Line : vFileContenet) {
        cout << Line << endl;
    }
    return 0;
}

*/



// Load vector to file

/*
#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

// Function to save a vector of strings to a file
void SaveVectorToFile(const string& fileName, const vector<string>& vFileContent) {
    // Open the file for writing (ios::out)
    fstream MyFile;
    MyFile.open(fileName, ios::out);

    // Check if the file was opened successfully
    if (MyFile.is_open()) {
        // Loop through each line in the vector
        for (const string& line : vFileContent) {
            // Write the line to the file (excluding empty lines)
            if (!line.empty()) {
                MyFile << line << endl;
            }
        }

        // Close the file
        MyFile.close();
    } else {
        cerr << "Error opening file: " << fileName << endl; // Error handling
    }
}

int main() {
    // Create a vector of strings
    vector<string> vFileContent = {"Ali", "Shadi", "Maher", "Fadi", "Lama"};

    // Save the vector content to a file
    SaveVectorToFile("MyFile.txt", vFileContent);

    return 0;
}

*/



// Deleting a record.

/*

#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

void LoadDataFromFileToVector(string fileName, vector<string>& vFileContent) {
  fstream MyFile;
  MyFile.open(fileName, ios::in); // Read mode
  if (MyFile.is_open()) {
    string Line;
    while (getline(MyFile, Line)) {
      vFileContent.push_back(Line);
    }
    MyFile.close();
  }
}

void SaveVectorToFile(string fileName, vector<string> vFileContent) {
  fstream MyFile;
  MyFile.open(fileName, ios::out); // Write mode
  if (MyFile.is_open()) {
    for (string Line : vFileContent) {
      if (Line != "") {
        MyFile << Line << endl;
      }
    }
    MyFile.close();
  }
}

void DeleteRecordFromFile(string fileName, string record) {
  vector<string> vFileContent;
  LoadDataFromFileToVector(fileName, vFileContent);
  for (string& Line : vFileContent) {
    if (Line == record) {
      Line = "";
    }
  }
  SaveVectorToFile(fileName, vFileContent);
}

void PrintFileContent(string fileName) {
  fstream MyFile;
  MyFile.open(fileName, ios::in); // Read mode
  if (MyFile.is_open()) {
    string Line;
    while (getline(MyFile, Line)) {
      cout << Line << endl;
    }
    MyFile.close();
  }
}

int main() {
  cout << "File Content Before Delete.\n";
  PrintFileContent("MyFile.txt");
  DeleteRecordFromFile("MyFile.txt", "Ali");
  cout << "\n\nFile Content After Delete.\n";
  PrintFileContent("MyFile.txt");
  return 0;
}

*/

// Switching values.

/*
#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

void LoadDataFromFileToVector(const string& FileName, vector<string>& vFileContent) {
    fstream MyFile;
    MyFile.open(FileName, ios::in); // Read mode
    if (MyFile.is_open()) {
        string Line;
        while (getline(MyFile, Line)) {
            vFileContent.push_back(Line);
        }
        MyFile.close();
    } else {
        cerr << "Could not open the file: " << FileName << endl;
    }
}

void SaveVectorToFile(const string& FileName, const vector<string>& vFileContent) {
    fstream MyFile;
    MyFile.open(FileName, ios::out); // Write mode
    if (MyFile.is_open()) {
        for (const string& Line : vFileContent) {
            if (!Line.empty()) {
                MyFile << Line << endl;
            }
        }
        MyFile.close();
    } else {
        cerr << "Could not open the file: " << FileName << endl;
    }
}

void UpdateRecordInFile(const string& FileName, const string& Record, const string& UpdateTo) {
    vector<string> vFileContent;
    LoadDataFromFileToVector(FileName, vFileContent);
    for (string& Line : vFileContent) {
        if (Line == Record) {
            Line = UpdateTo;
        }
    }
    SaveVectorToFile(FileName, vFileContent);
}

void PrintFileContent(const string& FileName) {
    fstream MyFile;
    MyFile.open(FileName, ios::in); // Read mode
    if (MyFile.is_open()) {
        string Line;
        while (getline(MyFile, Line)) {
            cout << Line << endl;
        }
        MyFile.close();
    } else {
        cerr << "Could not open the file: " << FileName << endl;
    }
}

int main() {
    cout << "File Content Before Update.\n";
    PrintFileContent("MyFile.txt");

    UpdateRecordInFile("MyFile.txt", "Ali", "Omar");

    cout << "\n\nFile Content After Update.\n";
    PrintFileContent("MyFile.txt");

    return 0;
}

*/