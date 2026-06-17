
Stack<char> bottle = new Stack<char>();

for(int i =0; i < s.Length; i++){
   char current = s[i];

   if(current == '(' || current == '{' || current == '['){
      bottle.Push(current);
   }
   else{
    if(bottle.Count == 0){
      return false;
    }
    char top = bottle.Pop();

    if (current == ')' && top !='(') return false;
    if (current == '}' && top !='{') return false;
    if (current == ']' && top !='[') return false;
   }
}

return bottle.Count ==0;