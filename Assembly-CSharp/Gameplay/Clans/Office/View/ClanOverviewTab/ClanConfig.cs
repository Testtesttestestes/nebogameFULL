using System;
using Core.Data;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanOverviewTab
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	public class ClanConfig : MonoBehaviour
	{
		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C54")]
		public ButtonWithCost ChangeClanButton
		{
			[Token(Token = "0x6003DD1")]
			[Address(RVA = "0x8C90", Offset = "0x8C90", VA = "0x8C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C55")]
		public FractionClanTypeListElement FractionClan
		{
			[Token(Token = "0x6003DD2")]
			[Address(RVA = "0x8C91", Offset = "0x8C91", VA = "0x8C91")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C56")]
		public PatternTextInput TitleInput
		{
			[Token(Token = "0x6003DD3")]
			[Address(RVA = "0x8C92", Offset = "0x8C92", VA = "0x8C92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C57")]
		public PatternTextInput DescriptionInput
		{
			[Token(Token = "0x6003DD4")]
			[Address(RVA = "0x8C93", Offset = "0x8C93", VA = "0x8C93")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x8C94", Offset = "0x8C94", VA = "0x8C94")]
		public void Init(ClanOfficeData clanIsleData, UserData user)
		{
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x8C95", Offset = "0x8C95", VA = "0x8C95")]
		public ClanConfig()
		{
		}

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PatternTextInput _titleInput;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PatternTextInput _descriptionInput;

		// Token: 0x040022A5 RID: 8869
		[Token(Token = "0x40022A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _changeButton;

		// Token: 0x040022A6 RID: 8870
		[Token(Token = "0x40022A6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FractionClanTypeListElement _fractionClan;
	}
}
