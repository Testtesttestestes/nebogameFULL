using System;
using Core.Data;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	public class ClanBuildingInfoView : BaseBuildingInfoView<ClanIsle>
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000259")]
		protected override UserData Owner
		{
			[Token(Token = "0x6001039")]
			[Address(RVA = "0x6243", Offset = "0x6243", VA = "0x6243", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x6244", Offset = "0x6244", VA = "0x6244", Slot = "6")]
		public override void OnInit(ClanIsle isle, uint buildingTypeId)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Windows_Buildings_ClanBuildingInfoView__OnInit(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a58aa9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__Dispose__);
		    DAT_ram_00a58aa9 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingInfoView_object___ClearContent
		            (param1,Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__Dispose__);
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x6245", Offset = "0x6245", VA = "0x6245", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Windows_Buildings_ClanBuildingInfoView__Dispose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58aaa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle___ctor__);
		    DAT_ram_00a58aaa = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x6246", Offset = "0x6246", VA = "0x6246")]
		public ClanBuildingInfoView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_Buildings_ClanBuildingInfoView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x24),*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x40")]
		private ClanBuildingInfoViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Owner ---
		void UI_Windows_Buildings_ClanBuildingInfoView__get_Owner
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int *param1_00;
		  undefined4 param4_00;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58aa8 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&UI_Windows_Buildings_ClanBuildingInfoViewMediator_TypeInfo);
		    DAT_ram_00a58aa8 = '\x01';
		  }
		  param4_00 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (UI_Windows_Buildings_ClanBuildingInfoViewMediator_TypeInfo);
		  if (DAT_ram_00a58aac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView___ctor__
		              );
		    DAT_ram_00a58aac = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4_00,
		             Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView___ctor__
		            );
		  param1_00[6] = param3;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

}
