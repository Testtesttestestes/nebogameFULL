using System;
using Core.Data;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanOverviewTab
{
	// Token: 0x02000A34 RID: 2612
	[Token(Token = "0x2000A34")]
	public class ClanOverview : MonoBehaviourWithStates<ClanInfoWindow.State>
	{
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C58")]
		public ClanConfig ClanConfig
		{
			[Token(Token = "0x6003DDA")]
			[Address(RVA = "0x8C99", Offset = "0x8C99", VA = "0x8C99")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C59")]
		public Button ZigguratButton
		{
			[Token(Token = "0x6003DDB")]
			[Address(RVA = "0x8C9A", Offset = "0x8C9A", VA = "0x8C9A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x8C9B", Offset = "0x8C9B", VA = "0x8C9B")]
		public void Init(ClanOfficeData clanIsleData, UserData user, Dictionaries dict)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_ClanOverviewTab_ClanOverview__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f70 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_ClanInfoWindow_State___ctor__);
		    DAT_ram_00a57f70 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ClanInfoWindow_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x8C9C", Offset = "0x8C9C", VA = "0x8C9C")]
		public ClanOverview()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_View_ClanOverviewTab_ClanOverview___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_args__
		              );
		    DAT_ram_00a57f71 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x18);
		}
		*/

		}

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanConfig _config;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanInfoBox _infoBox;

		// Token: 0x040022AF RID: 8879
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _zigguratButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ZigguratButton ---
		void Gameplay_Clans_Office_View_ClanOverviewTab_ClanOverview__get_ZigguratButton
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x20);
		  Gameplay_Clans_Office_View_ClanOfficeWindow_ClanOfficeWindowArgs___ctor
		            (*(undefined4 *)(param1_00 + 0x14),param4,0);
		  Gameplay_Clans_Office_View_ClanTitle__get_Text
		            (*(undefined4 *)(param1_00 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x1c) + 0x18),0);
		  Gameplay_Clans_Office_View_ClanRatingsGroup__Init
		            (*(undefined4 *)(param1_00 + 0x14),param4,*(undefined4 *)(*(int *)(param2 + 8) + 0x10),0
		            );
		  Gameplay_Clans_Office_View_ClanOverviewTab_ClanInfoBox__Init(param1_00,param2,param2);
		  Gameplay_Clans_Office_View_ClanOverviewTab_ClanConfig__get_DescriptionInput
		            (*(undefined4 *)(param1 + 0x1c),param2,param3,param2);
		  return;
		}
		*/

}
