using System;
using System.Runtime.CompilerServices;
using Core.Events;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x02001250 RID: 4688
	[Token(Token = "0x2001250")]
	public class EventBusManager : IAppManager, IBaseManager
	{
		// Token: 0x140002E9 RID: 745
		// (add) Token: 0x06006F18 RID: 28440 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F19 RID: 28441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F18")]
			[Address(RVA = "0xB993", Offset = "0xB993", VA = "0xB993", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F19")]
			[Address(RVA = "0xB994", Offset = "0xB994", VA = "0xB994", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002EA RID: 746
		// (add) Token: 0x06006F1A RID: 28442 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F1B RID: 28443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EA")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F1A")]
			[Address(RVA = "0xB995", Offset = "0xB995", VA = "0xB995", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F1B")]
			[Address(RVA = "0xB996", Offset = "0xB996", VA = "0xB996", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F1D RID: 28445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B0")]
		public EventBus EventBus
		{
			[Token(Token = "0x6006F1C")]
			[Address(RVA = "0xB997", Offset = "0xB997", VA = "0xB997")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F1D")]
			[Address(RVA = "0xB998", Offset = "0xB998", VA = "0xB998")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F1E")]
		[Address(RVA = "0xB999", Offset = "0xB999", VA = "0xB999", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F1F")]
		[Address(RVA = "0xB99A", Offset = "0xB99A", VA = "0xB99A", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016B1")]
		public string Name
		{
			[Token(Token = "0x6006F20")]
			[Address(RVA = "0xB99B", Offset = "0xB99B", VA = "0xB99B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F21")]
		[Address(RVA = "0xB99C", Offset = "0xB99C", VA = "0xB99C")]
		public EventBusManager()
		{
		}
	}
}
