using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D35 RID: 3381
	[Token(Token = "0x2000D35")]
	public class IsleAnimationViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleAnimationsView>
	{
		// Token: 0x060052AE RID: 21166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AE")]
		[Address(RVA = "0xA084", Offset = "0xA084", VA = "0xA084")]
		public IsleAnimationViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleAnimationViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58da5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleAnimationsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationViewMediator_AnimationStartedEvent__
		              );
		    DAT_ram_00a58da5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleAnimationViewMediator_AnimationStartedEvent__
		                  ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleAnimationViewMediator_AnimationStartedEvent__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x34) = iVar4;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010DA RID: 4314
		// (set) Token: 0x060052AF RID: 21167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DA")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052AF")]
			[Address(RVA = "0xA085", Offset = "0xA085", VA = "0xA085", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B0")]
		[Address(RVA = "0xA086", Offset = "0xA086", VA = "0xA086")]
		private void AnimationStartedEvent(uint animationId)
		{
		/* --- GHIDRA: AnimationStartedEvent ---
		void Gameplay_Isles_User_Controller_IsleAnimationViewMediator__AnimationStartedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58da7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView___ctor__
		              );
		    DAT_ram_00a58da7 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleAnimationViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param3_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58da6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58da6 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x80fa9429;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fa9429:
		  uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_01,param3_00[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetTournamentDic(uVar2,param2,0);
		  uVar2 = Core_Extensions_Dict_IsleAnimationsDicExt__GetButtonAssetId(uVar2,0);
		  Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_Args___ctor
		            (param1_00,uVar2,param3_00);
		  return;
		}
		*/

}
