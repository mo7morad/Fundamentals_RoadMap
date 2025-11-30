#pragma once
#include <stack>
#include <string>

using namespace std;

class clsMyString
{

private:
  stack<string> _Undo;
  stack<string> _Redo;
  string _Value;

public:

  void SetValue(const string &value)
  {
    _Undo.push(_Value);
    _Value = value;
  }

  string GetValue() const
  {
    return _Value;
  }

  void Undo()
  {
    if (!_Undo.empty())
    {
      _Redo.push(_Value);
      _Value = _Undo.top();
      _Undo.pop();
    }
  }

  void Redo()
  {
    if (!_Redo.empty())
    {
      _Undo.push(_Value);
      _Value = _Redo.top();
      _Redo.pop();
    }
  }
};
