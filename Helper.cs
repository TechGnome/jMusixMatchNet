namespace jMusixMatchSharp;

using System.Web;
using System.Text;
/**
 * Helper Utility Class
 * 
 * @author Sachin Handiekar
 * @version 1.0
 */
public static class Helper
{

    public static String getURLString(String methodName, Dictionary<String, Object> parameters) {
		String paramString = "";

		paramString += methodName + "?";

        foreach (KeyValuePair<String, Object> entry in parameters) {
            paramString += entry.Key + "=" + HttpUtility.UrlEncode(entry.Value.ToString(), Encoding.UTF8) + "&";
        }

		paramString = paramString.Substring(0, paramString.Length - 1);
        return paramString;
    }

}
