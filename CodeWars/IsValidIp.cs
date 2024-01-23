namespace Solution
{
    class Kata
    {
        public static bool IsValidIp(string ipAddress)
        {
            if (ipAddress.Contains(' '))
                return false;

            string[] ip = ipAddress.Split('.');
            
            if (ip.Length != 4)
                return false;

            foreach (string segment in ip)
            {
                if (!int.TryParse(segment, out int ipSegment))
                    return false;

                if (ipSegment < 0 || ipSegment > 255 || (segment.Length > 1 && segment[0] == '0'))
                    return false;
            }

            return true;
        }
    }
}
