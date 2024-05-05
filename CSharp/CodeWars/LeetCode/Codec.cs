public class Codec {

    Dictionary<string, string> urlsDictionary = new Dictionary<string, string>();

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {    
        string code = Guid.NewGuid().ToString();
        urlsDictionary.Add(code, longUrl);
        return new StringBuilder("http://tinyurl.com/").Append(code).ToString();
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string code = shortUrl.Replace("http://tinyurl.com/","");
        string url = urlsDictionary[code];
        return url;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));