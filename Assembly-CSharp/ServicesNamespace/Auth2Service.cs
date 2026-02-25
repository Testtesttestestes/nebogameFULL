using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Auth2;
using Protocol.Consts;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public class Auth2Service : AbstractService
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x17000090")]
		public override short ServiceId
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x580F", Offset = "0x580F", VA = "0x580F", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x5810", Offset = "0x5810", VA = "0x5810")]
		public Auth2Service()
		{
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000014")]
		public event Action<MoveUserEvt> MoveUserEvent
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x2285", Offset = "0x2285", VA = "0x2285")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x5811", Offset = "0x5811", VA = "0x5811")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x5812", Offset = "0x5812", VA = "0x5812", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x5813", Offset = "0x5813", VA = "0x5813")]
		public OpToken<IMessage, object> GetPossibleNicks(string nick, string lang)
		{
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5814", Offset = "0x5814", VA = "0x5814")]
		public OpToken<IMessage, object> Login(ClientPlatform platform, Provider provider, string providerUserId, string token, string languageCode, string version)
		{
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x228B", Offset = "0x228B", VA = "0x228B")]
		public OpToken<IMessage, object> Register(Provider provider, ClientPlatform platform, string providerUserId, string token, string languageCode, string nick, uint aprId, string version, string marketingParams, string identityCode)
		{
			return null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x5815", Offset = "0x5815", VA = "0x5815")]
		public OpToken<IMessage, object> OTPCodeGet()
		{
			return null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5816", Offset = "0x5816", VA = "0x5816")]
		public OpToken<IMessage, object> OTPTokenGen(string code)
		{
			return null;
		}
	}
}
