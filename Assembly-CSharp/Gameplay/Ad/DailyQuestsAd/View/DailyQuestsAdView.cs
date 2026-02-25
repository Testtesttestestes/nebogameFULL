using System;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests;
using Gameplay.Ad.DailyQuestsAd.Controller;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.DailyQuestsAd.View
{
	// Token: 0x02000DAF RID: 3503
	[Token(Token = "0x2000DAF")]
	public class DailyQuestsAdView : MonoBehaviour
	{
		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001162")]
		public Button WatchButton
		{
			[Token(Token = "0x6005593")]
			[Address(RVA = "0xA333", Offset = "0xA333", VA = "0xA333")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001163")]
		public GameObject LoadingGroup
		{
			[Token(Token = "0x6005594")]
			[Address(RVA = "0xA334", Offset = "0xA334", VA = "0xA334")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005595")]
		[Address(RVA = "0xA335", Offset = "0xA335", VA = "0xA335")]
		public void Init(IDailyQuest dailyQuest, DailyQuestsAdPlacementManager manager)
		{
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005596")]
		[Address(RVA = "0xA336", Offset = "0xA336", VA = "0xA336")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005597")]
		[Address(RVA = "0xA337", Offset = "0xA337", VA = "0xA337")]
		public DailyQuestsAdView()
		{
		}

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _loadingGroup;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		[FieldOffset(Offset = "0x18")]
		private DailyQuestsAdViewMediator _mediator;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x1C")]
		private bool _mvcSetup;
	}
}
