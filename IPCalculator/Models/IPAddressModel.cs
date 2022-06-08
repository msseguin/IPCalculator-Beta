using System;
using System.Net;
namespace IPCalculator.Models
{
	
	public class IPAddressModel
	{
		//private IPAddress iPAddress;
		/// <summary>
        /// 
        /// </summary>
        /// <param name="firstRange"></param>
        /// <param name="secondRange"></param>
        /// <param name="thirdRange"></param>
        /// <param name="fourthRange"></param>
        /// <exception cref="ArgumentException"></exception>
		/*public IPAddressModel()
		{
			firstRange = 
			string ip = this.firstRange.ToString() + "." + this.secondRange.ToString() + "." + this.thirdRange.ToString() + "." + this.fourthRange.ToString();
			try { this.IPAddress = IPAddress.Parse(ip); }
            catch { throw new ArgumentException(); }
		}*/


		/// <summary>
        /// 
        /// </summary>
		public IPAddress IPAddress
		{
			get { return IPAddress; }
			set
			{
				string ip = this.firstRange.ToString() + "." + this.secondRange.ToString() + "." + this.thirdRange.ToString() + "." + this.fourthRange.ToString();
				try { this.IPAddress = IPAddress.Parse(ip); }
				catch { throw new ArgumentException(); }
			}
		}
		
		public int? firstRange { get; set; }
		public int? secondRange{ get; set; }
		public int? thirdRange { get; set; }
		public int? fourthRange { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string getHexIP()
        {
			if (this.IPAddress != null)
			{
				byte[] bytes = this.IPAddress.GetAddressBytes();

				string hexIP = String.Format("{0:X2}:{1:X2}:{2:X2}:{3:X2}", bytes[0], bytes[1], bytes[2], bytes[3]);

				return hexIP;
			}
			else
				return "00:00:00:00";
        }
	}
}

