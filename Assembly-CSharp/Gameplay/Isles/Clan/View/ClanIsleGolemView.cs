using System;
using AssetContent;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.Clan.View
{
	// Token: 0x02000CF1 RID: 3313
	[Token(Token = "0x2000CF1")]
	public class ClanIsleGolemView : BaseIsleMonsterView, IToolTipDataProvider
	{
		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700104C")]
		public GameAssetViewSpriteRenderer Bubble
		{
			[Token(Token = "0x600509C")]
			[Address(RVA = "0x9EAB", Offset = "0x9EAB", VA = "0x9EAB")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509D")]
		[Address(RVA = "0x9EAC", Offset = "0x9EAC", VA = "0x9EAC")]
		public void Init(ClanIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_Clan_View_ClanIsleGolemView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x30);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600509E RID: 20638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509E")]
		[Address(RVA = "0x9EAD", Offset = "0x9EAD", VA = "0x9EAD")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Gameplay_Isles_Clan_View_ClanIsleGolemView__Deinit(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x14),0);
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  iVar1 = func_ii_4075(param1,0);
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta(param1_00,iVar1 + 1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600509F RID: 20639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509F")]
		[Address(RVA = "0x9EAE", Offset = "0x9EAE", VA = "0x9EAE", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_Clan_View_ClanIsleGolemView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  func_ii_7665(*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x18),0);
		  func_ii_7665(*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x9EAF", Offset = "0x9EAF", VA = "0x9EAF", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		int Gameplay_Isles_Clan_View_ClanIsleGolemView__ApplySortingLayerId(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int *param1_01;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58cae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanBuildingData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanBuildingData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanBuildingData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12529);
		    DAT_ram_00a58cae = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanBuildingData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12529,Method_UI_ToolTip_ToolTipData_ClanBuildingData___ctor__);
		  iVar1 = *(int *)(*(int *)(param1 + 0x30) + 8);
		  if (DAT_ram_00a58cb1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58cb1 = '\x01';
		  }
		  iVar2 = *(int *)(iVar1 + 0x24);
		  if (iVar2 != 0) {
		    iVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                      (iVar2,3,
		                       Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__ContainsKey__
		                      );
		    if (iVar2 == 0) {
		      param1_01 = (int *)0x0;
		    }
		    else {
		      param1_01 = (int *)System_Collections_Generic_List_object___get_Item
		                                   (*(undefined4 *)(iVar1 + 0x24),3,
		                                    Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                                   );
		      if (param1_01 == (int *)0x0) {
		        param1_01 = (int *)0x0;
		      }
		      else if (((uint)*(byte *)(*param1_01 + 0xb8) <
		                (uint)*(byte *)(Gameplay_World_Model_ClanBuildingData_TypeInfo + 0xb8)) ||
		              (*(int *)(*(int *)(*param1_01 + 100) +
		                        (uint)*(byte *)(Gameplay_World_Model_ClanBuildingData_TypeInfo + 0xb8) * 4 +
		                       -4) != Gameplay_World_Model_ClanBuildingData_TypeInfo)) {
		        System_Activator__CreateInstance(param1_01,Gameplay_World_Model_ClanBuildingData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(int **)(param1_00 + 0x1c) = param1_01;
		    return param1_00;
		  }
		  *(undefined4 *)(param1_00 + 0x1c) = 0;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x9EB0", Offset = "0x9EB0", VA = "0x9EB0", Slot = "12")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x9EB1", Offset = "0x9EB1", VA = "0x9EB1")]
		public ClanIsleGolemView()
		{
		}

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _bubble;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x30")]
		private ClanIsleGolemViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Bubble ---
		void Gameplay_Isles_Clan_View_ClanIsleGolemView__get_Bubble(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58cad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a58cad = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_TypeInfo);
		  if (DAT_ram_00a58cc9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView___ctor__
		              );
		    DAT_ram_00a58cc9 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView___ctor__
		            );
		  *(int **)(param1 + 0x30) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
