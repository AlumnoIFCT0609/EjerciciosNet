using System.Text.RegularExpressions;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new System.Text.StringBuilder();
        identifier = identifier.Replace(' ', '_');
        identifier = identifier.Replace("\0", "CTRL");
      
        for (int i = 0; i < identifier.Length; i++){
            if (identifier[i] == '-' && i + 1 < identifier.Length){
                result.Append(char.ToUpper(identifier[i + 1]));
                i++; // saltamos el siguiente carácter
            }            else            {
                result.Append(identifier[i]);
            }
        }
        identifier = result.ToString();
        identifier = Regex.Replace(identifier, @"[^\p{L}_]", "");
        // \p{L} → cualquier letra Unicode, \p{Nd} → cualquier número decimal 
        //  _ → cualquier guión bajo, ^ dentro de [] → negación, griegas mayusculas              //  \u0391-\u03A9 ]
        identifier = Regex.Replace(identifier, @"[\u03B1-\u03C9]", "");
        //[\u0391-\u03A9\u03B1-\u03C9] → cualquier letra griega mayúscula o minúscula
        // se elimina 
        return identifier;
    }
}
