using System.Security.Cryptography;

int answer = 0;
MD5 md5 = MD5.Create();
string hash = string.Empty;

while(hash != "000000")
{
    answer++;
    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes($"bgvyzdsv{answer}");
    byte[] hashBytes = md5.ComputeHash(inputBytes);

    hash = Convert.ToHexString(hashBytes).Substring(0, 6);
}

Console.WriteLine(answer);