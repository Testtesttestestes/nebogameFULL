using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using Protocol.Tournaments;
using TMPro;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public class TournamentPlayerBattleView : PlayerBattleViewBase, IToolTipDataProvider
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000507")]
		public Fighter Fighter
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x6DC8", Offset = "0x6DC8", VA = "0x6DC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x6DC9", Offset = "0x6DC9", VA = "0x6DC9")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000508")]
		public UserData UserData
		{
			[Token(Token = "0x6001C4B")]
			[Address(RVA = "0x6DCA", Offset = "0x6DCA", VA = "0x6DCA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C4C")]
			[Address(RVA = "0x6DCB", Offset = "0x6DCB", VA = "0x6DCB")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x17000509")]
		protected override uint _totalHealth
		{
			[Token(Token = "0x6001C4D")]
			[Address(RVA = "0x6DCC", Offset = "0x6DCC", VA = "0x6DCC", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x6DCD", Offset = "0x6DCD", VA = "0x6DCD")]
		public void Init(Fighter fighter)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_View_TournamentPlayerBattleView__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  *(int *)(param1 + 0x3c) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x38);
		  local_4 = *(undefined4 *)(param2 + 0x18);
		  param2_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  if (*(char *)(param2 + 0x28) != '\0') {
		    iVar1 = **(int **)(param1 + 0x10);
		    local_10 = *(undefined8 *)(param1 + 0x28);
		    local_18 = *(undefined8 *)(param1 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1 + 0x10),&local_18,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x6DCE", Offset = "0x6DCE", VA = "0x6DCE")]
		public void SetFighter(Fighter fighter)
		{
		/* --- GHIDRA: SetFighter ---
		void Gameplay_Tournaments_View_TournamentPlayerBattleView__SetFighter
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x34),1,0);
		  param1_00 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x34),0);
		  local_4 = 0x3f800000;
		  local_10 = 0x3f800000;
		  local_8 = 1.0;
		  if (param2 == 0) {
		    local_8 = -1.0;
		  }
		  local_c = 0x3f800000;
		  local_18 = CONCAT44(local_8,0x3f800000);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(param1_00,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x6DCF", Offset = "0x6DCF", VA = "0x6DCF")]
		public void ShowResultImage(bool win)
		{
		/* --- GHIDRA: ShowResultImage ---
		int Gameplay_Tournaments_View_TournamentPlayerBattleView__ShowResultImage
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a584fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12544);
		    DAT_ram_00a584fe = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_UserData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12544,Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x40);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x6DD0", Offset = "0x6DD0", VA = "0x6DD0", Slot = "8")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Tournaments_View_TournamentPlayerBattleView__GetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_BlitzTournament_View_PlayerBattleViewBase__Init(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x6DD1", Offset = "0x6DD1", VA = "0x6DD1")]
		public TournamentPlayerBattleView()
		{
		}

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameObject _resultImage;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _bet;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_UserData ---
		undefined4
		Gameplay_Tournaments_View_TournamentPlayerBattleView__set_UserData(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x3c) + 0x24);
		}
		*/


		/* --- GHIDRA: get__totalHealth ---
		void Gameplay_Tournaments_View_TournamentPlayerBattleView__get__totalHealth
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a584fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a584fd = '\x01';
		  }
		  param1[0xf] = param2;
		  iVar4 = param1[0xe];
		  local_4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(iVar4,uVar2,0);
		  if (*(char *)(param2 + 0x28) != '\0') {
		    iVar4 = *(int *)param1[4];
		    local_10 = *(undefined8 *)(param1 + 10);
		    local_18 = *(undefined8 *)(param1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x178) * 4))
		              ((int *)param1[4],&local_18,*(undefined4 *)(iVar4 + 0x17c));
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80efb4c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80efb4c2:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x80efb574;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80efb574:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar1 = 0;
		  uVar6 = *(undefined4 *)(param2 + 0xc);
		  piVar5 = *(int **)(iVar4 + 0x14);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80efb600;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80efb600:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar6,puVar3[1]);
		  param1[0x10] = iVar4;
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x18);
		  uVar2 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                    (uVar2,*(undefined4 *)(*(int *)(param2 + 0xc) + 0x24),0);
		  uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(uVar2,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,uVar6,uVar2,*(undefined4 *)(param2 + 0x20),*(undefined4 *)(*param1 + 0xfc));
		  return;
		}
		*/

}
