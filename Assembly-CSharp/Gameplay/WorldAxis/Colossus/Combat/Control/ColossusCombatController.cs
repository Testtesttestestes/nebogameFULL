using System;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Control;
using Gameplay.VortexCombat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Il2CppDummyDll;
using Protocol.Partycombat;
using ServicesNamespace;

namespace Gameplay.WorldAxis.Colossus.Combat.Control
{
	// Token: 0x0200033F RID: 831
	[Token(Token = "0x200033F")]
	public class ColossusCombatController : CombatController<ColossusCombatModel, ColossusCombatEvents>
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		public VortexCombatController VortexCombatController
		{
			[Token(Token = "0x6001320")]
			[Address(RVA = "0x6511", Offset = "0x6511", VA = "0x6511")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001321")]
			[Address(RVA = "0x6512", Offset = "0x6512", VA = "0x6512")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x6513", Offset = "0x6513", VA = "0x6513", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a58c21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents___ctor__
		              );
		    DAT_ram_00a58c21 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param3,param4,param5,
		             Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x6514", Offset = "0x6514", VA = "0x6514")]
		public ColossusCombatController(VortexCombatController vortexCombatController, ICombatService service, ColossusCombatModel model, ColossusCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58c22 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents__HandleRun__
		              );
		    DAT_ram_00a58c22 = '\x01';
		  }
		  uVar1 = Gameplay_VortexCombat_Factories_VortexCombatSpellDataFactory___ctor
		                    (*(undefined4 *)(param1 + 0x20),0);
		  uVar2 = unnamed_function_1417(System_Action_ProtoCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleCombatCompleteEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__remove_FieldChangedEvent(uVar1,uVar2,0);
		  iVar4 = **(int **)(param1 + 0x20);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                    (*(int **)(param1 + 0x20),*(undefined4 *)(iVar4 + 0x114));
		  uVar2 = *(undefined4 *)(iVar3 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleInitEvent__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  iVar4 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar3 + 8) = param1_00, *param1_00 != iVar4)) {
		    System_Activator__CreateInstance(param1_00,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleRewardsGot
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents__HandleRun__
		            );
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x6515", Offset = "0x6515", VA = "0x6515", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58c23 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents__HandleStop__
		              );
		    DAT_ram_00a58c23 = '\x01';
		  }
		  uVar1 = Gameplay_VortexCombat_Factories_VortexCombatSpellDataFactory___ctor
		                    (*(undefined4 *)(param1 + 0x20),0);
		  uVar2 = unnamed_function_1417(System_Action_ProtoCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleCombatCompleteEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__add_CombatCompleteEvent(uVar1,uVar2,0);
		  iVar4 = **(int **)(param1 + 0x20);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                    (*(int **)(param1 + 0x20),*(undefined4 *)(iVar4 + 0x114));
		  uVar2 = *(undefined4 *)(iVar3 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_HandleInitEvent__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar2,uVar1,0);
		  iVar4 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar3 + 8) = param1_00, *param1_00 != iVar4)) {
		    System_Activator__CreateInstance(param1_00,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleSpellAppliedServiceEvent
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents__HandleStop__
		            );
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001325")]
		[Address(RVA = "0x6516", Offset = "0x6516", VA = "0x6516", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x6517", Offset = "0x6517", VA = "0x6517")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController__HandleInitEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58c24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a58c24 = '\x01';
		  }
		  if (*(char *)(param2 + 0x24) != '\0') {
		    iVar4 = *(int *)(param2 + 0x28);
		    param1_00 = *(int *)(iVar4 + 0x14);
		    if (param1_00 == 0) {
		      uVar3 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		      *(undefined4 *)(iVar4 + 0x14) = uVar3;
		      param1_00 = *(int *)(*(int *)(param2 + 0x28) + 0x14);
		    }
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    param1_01 = *(int **)(*(int *)(iVar4 + 0x68) + 8);
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x80f8c8e0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,
		                                  Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                  ,4);
		code_r0x80f8c8e0:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(param1_00,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x6518", Offset = "0x6518", VA = "0x6518")]
		private void HandleCombatCompleteEvent(ProtoCombatCompleteEvt evt)
		{
		/* --- GHIDRA: HandleCombatCompleteEvent ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController__HandleCombatCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58c25 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatView__Dispose__
		              );
		    DAT_ram_00a58c25 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___DefineStonesSkins
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatView__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_VortexCombatController ---
		void Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController__set_VortexCombatController
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58c20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents__Dispose__
		              );
		    DAT_ram_00a58c20 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___CompleteQueueCallback
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

}
