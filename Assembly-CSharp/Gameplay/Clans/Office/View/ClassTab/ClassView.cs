using System;
using AssetContent;
using Gameplay.School.View;
using Gameplay.UserInfo.View.Equipment;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Elements.Buildings;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClassTab
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	public class ClassView : MonoBehaviourWithStates<ClassView.Tab>
	{
		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C26")]
		public GenericSubFilterView ClassFilter
		{
			[Token(Token = "0x6003D59")]
			[Address(RVA = "0x8C19", Offset = "0x8C19", VA = "0x8C19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C27")]
		public BaseUserEquipmentView Equipment
		{
			[Token(Token = "0x6003D5A")]
			[Address(RVA = "0x8C1A", Offset = "0x8C1A", VA = "0x8C1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C28")]
		public GameAssetViewRawImage Avatar
		{
			[Token(Token = "0x6003D5B")]
			[Address(RVA = "0x8C1B", Offset = "0x8C1B", VA = "0x8C1B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C29")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003D5C")]
			[Address(RVA = "0x8C1C", Offset = "0x8C1C", VA = "0x8C1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C2A")]
		public SpellList Spells
		{
			[Token(Token = "0x6003D5D")]
			[Address(RVA = "0x8C1D", Offset = "0x8C1D", VA = "0x8C1D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C2B")]
		public TitledListWithSpellTitle TitledList
		{
			[Token(Token = "0x6003D5E")]
			[Address(RVA = "0x8C1E", Offset = "0x8C1E", VA = "0x8C1E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C2C")]
		public Button CloseSpellDescButton
		{
			[Token(Token = "0x6003D5F")]
			[Address(RVA = "0x8C1F", Offset = "0x8C1F", VA = "0x8C1F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C2D")]
		public GameObject InfoBox
		{
			[Token(Token = "0x6003D60")]
			[Address(RVA = "0x8C20", Offset = "0x8C20", VA = "0x8C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C2E")]
		public DollSkillsInfoView SkillsInfoBox
		{
			[Token(Token = "0x6003D61")]
			[Address(RVA = "0x8C21", Offset = "0x8C21", VA = "0x8C21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C2F")]
		public Button InfoButton
		{
			[Token(Token = "0x6003D62")]
			[Address(RVA = "0x8C22", Offset = "0x8C22", VA = "0x8C22")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D63")]
		[Address(RVA = "0x8C23", Offset = "0x8C23", VA = "0x8C23")]
		public void UpdateDollInfo(DollsInfoDic doll)
		{
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D64")]
		[Address(RVA = "0x8C24", Offset = "0x8C24", VA = "0x8C24")]
		public ClassView()
		{
		}

		// Token: 0x0400222A RID: 8746
		[Token(Token = "0x400222A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x0400222B RID: 8747
		[Token(Token = "0x400222B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BaseUserEquipmentView _equipment;

		// Token: 0x0400222C RID: 8748
		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GenericSubFilterView _classFilter;

		// Token: 0x0400222D RID: 8749
		[Token(Token = "0x400222D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400222E RID: 8750
		[Token(Token = "0x400222E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400222F RID: 8751
		[Token(Token = "0x400222F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _traitsColumn;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SpellList _spells;

		// Token: 0x04002232 RID: 8754
		[Token(Token = "0x4002232")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TitledListWithSpellTitle _titledList;

		// Token: 0x04002233 RID: 8755
		[Token(Token = "0x4002233")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _closeSpellBlockButton;

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject _infoBox;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DollSkillsInfoView _skillsInfoBox;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x02000A15 RID: 2581
		[Token(Token = "0x2000A15")]
		public enum Tab : byte
		{
			// Token: 0x04002238 RID: 8760
			[Token(Token = "0x4002238")]
			UNKNOWN_TAB,
			// Token: 0x04002239 RID: 8761
			[Token(Token = "0x4002239")]
			DESCRIPTION,
			// Token: 0x0400223A RID: 8762
			[Token(Token = "0x400223A")]
			EQUIPMENT
		}
	}
}
