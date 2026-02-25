using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Il2CppDummyDll;
using Protocol.System;

namespace ServicesNamespace
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public class SystemService : AbstractService
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x170000AF")]
		public override short ServiceId
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x5A85", Offset = "0x5A85", VA = "0x5A85", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A7")]
		public event Action<DisconnectCode> ConnectionClosedEvent
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x5A86", Offset = "0x5A86", VA = "0x5A86")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x5A87", Offset = "0x5A87", VA = "0x5A87")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A8")]
		public event Action ServerReadyToStopEvent
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x5A88", Offset = "0x5A88", VA = "0x5A88")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x5A89", Offset = "0x5A89", VA = "0x5A89")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x5A8A", Offset = "0x5A8A", VA = "0x5A8A", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x5A8B", Offset = "0x5A8B", VA = "0x5A8B")]
		public void EmulateDisconect(DisconnectCode code)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x5A8C", Offset = "0x5A8C", VA = "0x5A8C")]
		public SystemService()
		{
		}
	}
}
