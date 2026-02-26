using System;
using Core.Data;
using Gameplay.Isles.User;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	public class BuildingInfoView : BaseBuildingInfoView<UserIsle>
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000248")]
		protected override UserData Owner
		{
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x6216", Offset = "0x6216", VA = "0x6216", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x6217", Offset = "0x6217", VA = "0x6217", Slot = "6")]
		public override void OnInit(UserIsle isle, uint buildingTypeId)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Windows_Buildings_BuildingInfoView__OnInit(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a58a94 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__Dispose__);
		    DAT_ram_00a58a94 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingInfoView_object___ClearContent
		            (param1,Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__Dispose__);
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x40) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x6218", Offset = "0x6218", VA = "0x6218", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Windows_Buildings_BuildingInfoView__Dispose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a95 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle___ctor__);
		    DAT_ram_00a58a95 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x6219", Offset = "0x6219", VA = "0x6219")]
		public BuildingInfoView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_BuildingInfoView___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58a96 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param3,param4,param5,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param2;
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param3 + 0x24),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x40")]
		private BuildingInfoViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Owner ---
		void UI_Windows_Buildings_BuildingInfoView__get_Owner
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 param4_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58a93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_Buildings_BuildingInfoViewMediator_TypeInfo);
		    DAT_ram_00a58a93 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x3c);
		  param4_00 = *(undefined4 *)(iVar1 + 0x14);
		  param3_00 = *(undefined4 *)(iVar1 + 0xc);
		  iVar1 = *(int *)(iVar1 + 0x10);
		  param1_00 = (int *)unnamed_function_1417(UI_Windows_Buildings_BuildingInfoViewMediator_TypeInfo);
		  if (DAT_ram_00a58a96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58a96 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,iVar1,param3_00,param4_00,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView___ctor__
		            );
		  param1_00[6] = param3;
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0x24),param3,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  param1_00[7] = iVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

}
