using System.Security.Cryptography;
using System.Text;

namespace Spotifried.Helpers;

public static class Cryptograph{

    public static string GenerateHash(this string value){

        var hash = SHA256.Create();
        var encoding = new ASCIIEncoding();
        var array = encoding.GetBytes(value);

        array = hash.ComputeHash(array);

        var strHexa = new StringBuilder();

        foreach (var i in array){
            strHexa.Append(i.ToString("x2"));
        } 

        return strHexa.ToString();

    }

}