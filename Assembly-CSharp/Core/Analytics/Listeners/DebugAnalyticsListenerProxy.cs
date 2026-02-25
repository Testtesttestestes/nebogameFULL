using System;
using Core.Events;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CE RID: 4814
	[Token(Token = "0x20012CE")]
	public class DebugAnalyticsListenerProxy : AbstractAnalyticsListener
	{
		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001731")]
		protected override string Theme
		{
			[Token(Token = "0x6007273")]
			[Address(RVA = "0xBC7C", Offset = "0xBC7C", VA = "0xBC7C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (set) Token: 0x06007274 RID: 29300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001732")]
		public override EventBus EventBus
		{
			[Token(Token = "0x6007274")]
			[Address(RVA = "0xBC7D", Offset = "0xBC7D", VA = "0xBC7D", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007275")]
		[Address(RVA = "0xBC7E", Offset = "0xBC7E", VA = "0xBC7E", Slot = "8")]
		public override void AddService(IAnalyticsService service)
		{
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007276")]
		[Address(RVA = "0xBC7F", Offset = "0xBC7F", VA = "0xBC7F", Slot = "9")]
		public override void RemoveService(IAnalyticsService service)
		{
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007277")]
		[Address(RVA = "0xBC80", Offset = "0xBC80", VA = "0xBC80", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007278")]
		[Address(RVA = "0xBC81", Offset = "0xBC81", VA = "0xBC81", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007279")]
		[Address(RVA = "0xBC82", Offset = "0xBC82", VA = "0xBC82")]
		public DebugAnalyticsListenerProxy()
		{
		}

		// Token: 0x04003BFE RID: 15358
		[Token(Token = "0x4003BFE")]
		[FieldOffset(Offset = "0x10")]
		private readonly AbstractAnalyticsListener[] _listeners;
	}
}
