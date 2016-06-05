using System.IO;
using System.Net;
using System.Text;

namespace KaizenSoftFBEL
{
  public class KaizenSoftFBEL
  {
    public bool Enter(string Id, string Pass)
    {
      bool tof = false;
      CookieContainer cC1 = (CookieContainer) null;
      string s = "lsd=AVphHiRP&email=" + Id + "&pass=" + Pass + "&lgnrnd=093439_-52j&lgnjs=1380213284&locale=en_GB";
      CookieContainer cC2 = new CookieContainer();
      byte[] bite = new UTF8Encoding().GetBytes(s);
      HttpWebRequest Wr = (HttpWebRequest) WebRequest.Create("https://m.facebook.com/login.php");
      Wr.Method = "POST";
            Wr.KeepAlive = true;
            Wr.CookieContainer = cC2;
            Wr.ContentType = "application/x-www-form-urlencoded";
            Wr.Referer = "https://m.facebook.com/";
            Wr.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
            Wr.ContentLength = (long)bite.Length;
            Wr.GetRequestStream().Write(bite, 0, bite.Length);
      HttpWebResponse httpWebResponse = (HttpWebResponse)Wr.GetResponse();
            cC2.Add(httpWebResponse.Cookies);
            cC1 = cC2;
      string endsession = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
      if (endsession.Contains("logout") | endsession.Contains("Your account is temporarily locked."))
        tof = true;
      return tof;
    }
  }
}