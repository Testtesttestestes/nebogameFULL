using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Il2CppDummyDll;
using Protocol.Auth;

namespace ServicesNamespace
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public class AuthService : AbstractService
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x17000091")]
		public override short ServiceId
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x5817", Offset = "0x5817", VA = "0x5817", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000015")]
		public event Action<ProtoBanStatusChangedEvt> BanStatusChangedEvent
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x5818", Offset = "0x5818", VA = "0x5818")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x5819", Offset = "0x5819", VA = "0x5819")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x581A", Offset = "0x581A", VA = "0x581A", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x581B", Offset = "0x581B", VA = "0x581B")]
		public AuthService()
		{
		}
	}
}
