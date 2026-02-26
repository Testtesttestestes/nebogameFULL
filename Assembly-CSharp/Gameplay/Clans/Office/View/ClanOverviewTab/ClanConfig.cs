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
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanOverviewTab_ClanConfig___ctor
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Clans_Office_View_ClanOfficeWindow_ClanOfficeWindowArgs___ctor
		            (*(undefined4 *)(param1 + 0x14),param3,0);
		  Gameplay_Clans_Office_View_ClanTitle__get_Text
		            (*(undefined4 *)(param1 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x1c) + 0x18),0);
		  Gameplay_Clans_Office_View_ClanRatingsGroup__Init
		            (*(undefined4 *)(param1 + 0x14),param3,*(undefined4 *)(*(int *)(param2 + 8) + 0x10),0);
		  Gameplay_Clans_Office_View_ClanOverviewTab_ClanInfoBox__Init(param1,param2,param1);
		  return;
		}
		*/

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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DescriptionInput ---
		void Gameplay_Clans_Office_View_ClanOverviewTab_ClanConfig__get_DescriptionInput
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  longlong lVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f6e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57f6e = '\x01';
		  }
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x1c) + 0x18),0);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(*(int *)(param2 + 8) + 0x14),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x80e84e22;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e84e22:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = Core_Gameplay_Managers_ClansManager__GetCultsByClan
		                    (uVar3,*(undefined4 *)(param3 + 0x4c),0);
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  uVar3 = Core_Gameplay_Managers_ClansManager__GetClanCultAssetId
		                    (uVar3,*(undefined4 *)(iVar6 + 0xc),0);
		  Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement___ctor(param1_01,iVar6,uVar3,iVar6)
		  ;
		  uVar1 = Gameplay_World_Model_ClanData__GetJoinPrice
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x1c) + 0x20),0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  lVar4 = Core_Data_UserData___ctor(param3,0);
		  lVar5 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(param2 + 0xc),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uVar1 ^ 1) & (uint)(lVar4 == lVar5),0);
		  return;
		}
		*/

}
