using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace PetEmote.Editor
{
	/// <summary>
	/// Bietet die Möglichkeit, eine HTTP-Verbindung herzustellen,
	/// um beliebige URLs unter Angabe von Parametern aufzurufen.
	/// </summary>
	public class HttpResponder
	{
		public HttpResponder (Uri uri)
		{
			this.Uri = uri;
			this.Parameters = new Dictionary<string, string>();
		}

		public Uri Uri { get; set; }

		public Dictionary<string, string> Parameters { get; private set; }

		public string Content
		{
			get
			{
				List<string> items = new List<string>();

				foreach (KeyValuePair<string, string> parameter in this.Parameters)
				{
					items.Add(parameter.Key + "=" + parameter.Value);
				}

				return String.Join("&", items.ToArray());
			}
		}

		public string Result { get; private set; }

		/// <summary>
		/// Sendet eine Anfrage per HTTP und gibt die Antwort zurück.
		/// </summary>
		public void SendResponse ()
		{
			byte[] content = Encoding.UTF8.GetBytes(this.Content);

			HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.Uri);

			// ContentType anhand des Request-Typs auswählen
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentLength = content.Length;
			httpWebRequest.Timeout = 300000;

			// Falls wir mal hinter einem Proxy hocken, könnte das hier evtl. helfen
			// http://msdn.microsoft.com/de-de/library/system.net.httpwebrequest.begingetresponse.aspx

			// Bytes der Nachricht als POST an das HttpWebRequest anhängen
			using (Stream requestStream = httpWebRequest.GetRequestStream()) {
				requestStream.Write(content, 0, content.Length);
			}

			using (HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse())
			{
				if (httpWebResponse.StatusCode == HttpStatusCode.OK)
				{
					Stream responseStream = httpWebResponse.GetResponseStream();

					using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
					{
						this.Result = reader.ReadToEnd();
					}
				}
				else {
					throw new Exception(String.Format("Der Aufruf der URL {0} wurde mit dem Status-Code {1} beendet.", this.Uri, httpWebResponse.StatusCode));
				}
			}
		}
	}
}
