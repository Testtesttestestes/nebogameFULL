using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Rewards;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	public class RewardsTitledListElement : BaseTitledListElement<RewardsTitledListElementArgs>
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x6027", Offset = "0x6027", VA = "0x6027")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x6028", Offset = "0x6028", VA = "0x6028")]
			set
			{
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x6029", Offset = "0x6029", VA = "0x6029", Slot = "6")]
		protected override void OnInit(RewardsTitledListElementArgs args)
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x602A", Offset = "0x602A", VA = "0x602A")]
		public RewardsTitledListElement()
		{
		}

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AbstractRewardsRender _rewardsRender;
	}
}
