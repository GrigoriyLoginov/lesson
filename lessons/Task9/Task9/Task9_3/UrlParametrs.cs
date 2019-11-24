using System;
using System.Text.RegularExpressions;

namespace Task9_3
{
    public static class UrlParametrs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">URL parameter</param>
        /// <param name="param">key value</param>
        /// <returns></returns>
        public static string AddOrChangeUrlParameter(string url, string param)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(param))
                throw new ArgumentNullException();

            string[] par = param.Split('=');
            string[] s1 = url.Split('?');
            string result = url;
            Regex rg = new Regex("^?" + par[0] + "=&*");
            MatchCollection mc = rg.Matches(url);
            if (mc.Count >= 1)
            {
                string[] s2 = s1[1].Split('&');
                for (int i = 0; i < s2.Length; i++)
                {
                    string[] s3 = s2[i].Split('=');
                    if (s3[0] == par[0])
                        result = result.Replace(s3[1], par[1]);
                }
            }
            else if (mc.Count == 0 && s1.Length > 1)
                result += "&" + param;
            else
                result += "?" + param;
            return result;
        }
    }
}
