using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000743 RID: 1859
	[Token(Token = "0x2000743")]
	public class ConditionsEventSectionView : AbstractEventSectionView
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000867")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002C45")]
			[Address(RVA = "0x7CD4", Offset = "0x7CD4", VA = "0x7CD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000868")]
		public GameObject PlaceholderText
		{
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0x7CD5", Offset = "0x7CD5", VA = "0x7CD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000869")]
		public Transform RewardsOwner
		{
			[Token(Token = "0x6002C47")]
			[Address(RVA = "0x7CD6", Offset = "0x7CD6", VA = "0x7CD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086A")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x6002C48")]
			[Address(RVA = "0x7CD7", Offset = "0x7CD7", VA = "0x7CD7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086B")]
		public RequirementsView Requirements
		{
			[Token(Token = "0x6002C49")]
			[Address(RVA = "0x7CD8", Offset = "0x7CD8", VA = "0x7CD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x7CD9", Offset = "0x7CD9", VA = "0x7CD9", Slot = "5")]
		protected override void CreateMediator(ref IViewMediator mediator, GdEventsController controller)
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x7CDA", Offset = "0x7CDA", VA = "0x7CDA")]
		public ConditionsEventSectionView()
		{
		}

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _placeholderTest;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _rewardsOwner;

		// Token: 0x04001847 RID: 6215
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirements;
	}
}
