// Rot13
public class Kata
{
    public static string Rot13(string message)
    {
        string messageToRot13 = "";
        
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] >= 65 && message[i] <= 90)
                messageToRot13 += message[i] + 13 > 90 ? (char)(message[i] - 13) : (char)(message[i] + 13);
            else if (message[i] >= 97 && message[i] <= 122)
                messageToRot13 += message[i] + 13 > 122 ? (char)(message[i] - 13) : (char)(message[i] + 13);
            else
                messageToRot13 += message[i];
        }

        return messageToRot13;
    }
}