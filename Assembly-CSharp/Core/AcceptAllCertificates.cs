using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Core
{
	// Token: 0x02000E55 RID: 3669
	[Token(Token = "0x2000E55")]
	public class AcceptAllCertificates : CertificateHandler
	{
		// Token: 0x060059D1 RID: 22993 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x60059D1")]
		[Address(RVA = "0xA6F9", Offset = "0xA6F9", VA = "0xA6F9", Slot = "5")]
		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return default(bool);
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059D2")]
		[Address(RVA = "0xA6FA", Offset = "0xA6FA", VA = "0xA6FA")]
		public AcceptAllCertificates()
		{
		}
	}
}
