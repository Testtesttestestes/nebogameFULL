using System;
using AssetContent;
using Gameplay.Clans.Office.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	public class ClanPolicyListElement : ClanListElement<ClanPolicyListElement.ClanPolicyListElementArgs>
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3D")]
		public TextMeshProUGUI Place
		{
			[Token(Token = "0x6003D95")]
			[Address(RVA = "0x8C54", Offset = "0x8C54", VA = "0x8C54")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x8C55", Offset = "0x8C55", VA = "0x8C55", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x8C56", Offset = "0x8C56", VA = "0x8C56", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x8C57", Offset = "0x8C57", VA = "0x8C57")]
		private void ClanInfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x8C58", Offset = "0x8C58", VA = "0x8C58", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x8C59", Offset = "0x8C59", VA = "0x8C59")]
		private Sprite GetStatusSprite(ClanData data)
		{
			return null;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x8C5A", Offset = "0x8C5A", VA = "0x8C5A", Slot = "10")]
		protected override void CallElementClickedEvent(ClanPolicyListElement.ClanPolicyListElementArgs args)
		{
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x8C5B", Offset = "0x8C5B", VA = "0x8C5B")]
		public ClanPolicyListElement()
		{
		}

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _statusIcon;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _shieldSprite;

		// Token: 0x0400226A RID: 8810
		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Sprite _blitzWarSprite;

		// Token: 0x0400226B RID: 8811
		[Token(Token = "0x400226B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _warSprite;

		// Token: 0x0400226C RID: 8812
		[Token(Token = "0x400226C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameImage _leagueBanner;

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameImage _leagueIcon;

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _clanInfoButton;

		// Token: 0x0400226F RID: 8815
		[Token(Token = "0x400226F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _restrictionsIndicator;

		// Token: 0x02000A25 RID: 2597
		[Token(Token = "0x2000A25")]
		public class ClanPolicyListElementArgs : ClanListElementArgs<ClanWarsOfficeModel.Policy, ClanPolicyListElement>
		{
			// Token: 0x06003D9D RID: 15773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x8C5C", Offset = "0x8C5C", VA = "0x8C5C")]
			public ClanPolicyListElementArgs()
			{
			}
		}
	}
}
