#pragma once
#include <iostream>
#include <string>
#include <stack>
using namespace std;

class MyString {
private:
    stack<string> _UndoStack;
    stack<string> _RedoStack;
    string _Value = "";

public:

  MyString(const string& initialValue = "") 
  {
    _Value = initialValue;
    _UndoStack.push(_Value); // Save the initial value to the undo stack
  }

  void SetValue(const string& Value) 
  {
    _UndoStack.push(_Value);
    _Value = Value;          
    while (!_RedoStack.empty())
      _RedoStack.pop();    // Clear the redo stack
  }

  string GetValue() const
  {
    return _Value;
  }

  bool Undo() 
  {
    if (!_UndoStack.empty())
    {
      _RedoStack.push(_Value); // Save the current value to the redo stack
      _Value = _UndoStack.top();
      _UndoStack.pop();
      return true;
    }
    cout << "Nothing to undo!" << endl;
    return false;
  }

  bool Redo() 
  {
    if (!_RedoStack.empty()) 
    {
      _UndoStack.push(_Value);
      _Value = _RedoStack.top();
      _RedoStack.pop();
      return true;
    }
    cout << "Nothing to redo!" << endl;
    return false;
  }

  // First thought of the implementation
  /*
  #pragma once
#include <iostream>
#include <string>
#include "../../Project6-StackArray/MySolution/StackArray.h"

using namespace std;

class MyString
{
private:
    string _Value;
    int _HistoryIndex = 0;
    StackArray<string> StackArrayHistory;

public:
  MyString(const string& initialValue = "")
  {
    _Value = initialValue;
    _UndoStack.push(_Value); // Save the initial value to the undo stack
  }

    void SetValue(const string &Value)
    {
        _Value = Value;
        StackArrayHistory.push(_Value);
        _HistoryIndex = 0; // Reset history index on new value
    }

    string GetValue() const
    {
        return _Value;
    }

    void Undo()
    {
        if (_HistoryIndex + 1 < StackArrayHistory.Size())
        {
            _HistoryIndex++;
            _Value = StackArrayHistory.GetItem(StackArrayHistory.Size() - 1 - _HistoryIndex);
        }
        else
        {
            cout << "\nThere's Nothing to undo!\n";
        }
    }

    void Redo()
    {
        if (_HistoryIndex > 0)
        {
            _HistoryIndex--;
            _Value = StackArrayHistory.GetItem(StackArrayHistory.Size() - 1 - _HistoryIndex);
        }
        else
        {
            cout << "\nThere's Nothing to redo!\n";
        }
    }
};

  */
};