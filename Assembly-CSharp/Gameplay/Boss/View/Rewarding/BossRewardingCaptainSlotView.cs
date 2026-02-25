using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5E RID: 2910
	[Token(Token = "0x2000B5E")]
	public class BossRewardingCaptainSlotView : AbstractBossRewardingSlotView
	{
		// Token: 0x140001B6 RID: 438
		// (add) Token: 0x06004687 RID: 18055 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004688 RID: 18056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B6")]
		public event Action<BossRewardingCaptainSlotView> ClickEvent
		{
			[Token(Token = "0x6004687")]
			[Address(RVA = "0x951D", Offset = "0x951D", VA = "0x951D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004688")]
			[Address(RVA = "0x951E", Offset = "0x951E", VA = "0x951E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF2")]
		public override bool Interactable
		{
			[Token(Token = "0x6004689")]
			[Address(RVA = "0x951F", Offset = "0x951F", VA = "0x951F", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x9520", Offset = "0x9520", VA = "0x9520", Slot = "6")]
		protected override void HandleClick()
		{
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600468B")]
		[Address(RVA = "0x9521", Offset = "0x9521", VA = "0x9521")]
		public BossRewardingCaptainSlotView()
		{
		}
	}
}
