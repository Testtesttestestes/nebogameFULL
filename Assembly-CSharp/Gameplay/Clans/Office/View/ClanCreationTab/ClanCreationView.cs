using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanCreationTab
{
	// Token: 0x02000A3E RID: 2622
	[Token(Token = "0x2000A3E")]
	public class ClanCreationView : MonoBehaviour
	{
		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C6A")]
		public Button CreateButton
		{
			[Token(Token = "0x6003E0F")]
			[Address(RVA = "0x8CCE", Offset = "0x8CCE", VA = "0x8CCE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C6B")]
		public RequirementsView Requirements
		{
			[Token(Token = "0x6003E10")]
			[Address(RVA = "0x8CCF", Offset = "0x8CCF", VA = "0x8CCF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C6C")]
		public ClanTypeListElement PlayerCultClan
		{
			[Token(Token = "0x6003E11")]
			[Address(RVA = "0x8CD0", Offset = "0x8CD0", VA = "0x8CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C6D")]
		public FractionClanTypeListElement FractionCultClan
		{
			[Token(Token = "0x6003E12")]
			[Address(RVA = "0x8CD1", Offset = "0x8CD1", VA = "0x8CD1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C6E")]
		public PatternTextInput TitleInput
		{
			[Token(Token = "0x6003E13")]
			[Address(RVA = "0x8CD2", Offset = "0x8CD2", VA = "0x8CD2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C6F")]
		public PatternTextInput DescriptionInput
		{
			[Token(Token = "0x6003E14")]
			[Address(RVA = "0x8CD3", Offset = "0x8CD3", VA = "0x8CD3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x8CD4", Offset = "0x8CD4", VA = "0x8CD4")]
		public ClanCreationView()
		{
		}

		// Token: 0x040022D8 RID: 8920
		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x040022D9 RID: 8921
		[Token(Token = "0x40022D9")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _createButton;

		// Token: 0x040022DA RID: 8922
		[Token(Token = "0x40022DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClanTypeListElement _playerCultClan;

		// Token: 0x040022DB RID: 8923
		[Token(Token = "0x40022DB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private FractionClanTypeListElement _fractionCultClan;

		// Token: 0x040022DC RID: 8924
		[Token(Token = "0x40022DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PatternTextInput _titleField;

		// Token: 0x040022DD RID: 8925
		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private PatternTextInput _descriptionField;
	}
}
