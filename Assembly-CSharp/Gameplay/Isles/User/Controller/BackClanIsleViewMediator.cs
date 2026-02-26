using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D2E RID: 3374
	[Token(Token = "0x2000D2E")]
	public class BackClanIsleViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, BackClanIsleView>
	{
		// Token: 0x06005287 RID: 21127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005287")]
		[Address(RVA = "0xA05D", Offset = "0xA05D", VA = "0xA05D")]
		public BackClanIsleViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58d88 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_HandleDisposeEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_IsCurrentChangedEvent__
		              );
		    DAT_ram_00a58d88 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_HandleDisposeEvent__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_HandleDisposeEvent__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010D4 RID: 4308
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D4")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6005288")]
			[Address(RVA = "0xA05E", Offset = "0xA05E", VA = "0xA05E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (set) Token: 0x06005289 RID: 21129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D5")]
		public override BackClanIsleView View
		{
			[Token(Token = "0x6005289")]
			[Address(RVA = "0xA05F", Offset = "0xA05F", VA = "0xA05F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528A")]
		[Address(RVA = "0xA060", Offset = "0xA060", VA = "0xA060")]
		private void RenderIsle()
		{
		/* --- GHIDRA: RenderIsle ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__RenderIsle
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58d8b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d8b = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x18) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		          goto code_r0x80fa63ad;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80fa63ad:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                          (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		    Core_Gameplay_Managers_WorldManager__GoToUserIsleById
		              (param1_00,
		               *(undefined8 *)
		                (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x34) + 0x40) + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528B")]
		[Address(RVA = "0xA061", Offset = "0xA061", VA = "0xA061")]
		private void ViewOnClickEvent()
		{
		/* --- GHIDRA: ViewOnClickEvent ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__ViewOnClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_ToolTip_ToolTip__get_enabled(*(undefined4 *)(iVar1 + 0x28),0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528C")]
		[Address(RVA = "0xA062", Offset = "0xA062", VA = "0xA062")]
		private void HandleDisposeEvent()
		{
		/* --- GHIDRA: HandleDisposeEvent ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__HandleDisposeEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_User_Controller_BackClanIsleViewMediator__set_View(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528D")]
		[Address(RVA = "0xA063", Offset = "0xA063", VA = "0xA063")]
		private void IsCurrentChangedEvent()
		{
		/* --- GHIDRA: IsCurrentChangedEvent ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__IsCurrentChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__Dispose__
		              );
		    DAT_ram_00a58d8c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar1 + 0x24),0,0);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528E")]
		[Address(RVA = "0xA064", Offset = "0xA064", VA = "0xA064", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58d8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView___ctor__
		              );
		    DAT_ram_00a58d8d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58d89 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_ViewOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58d89 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,param2,0);
		  if (iVar4 != 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		    if (iVar4 != 0) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_ViewOnClickEvent__,0
		                );
		      if (DAT_ram_00a58d18 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a58d18 = '\x01';
		      }
		      iVar2 = *(int *)(iVar4 + 0x30);
		      do {
		        piVar5 = (int *)func_ii_7048(iVar2,uVar3,0);
		        if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		          System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar6 = func_ii_4329(iVar4 + 0x30,piVar5,iVar2);
		        bVar1 = iVar6 != iVar2;
		        iVar2 = iVar6;
		      } while (bVar1);
		    }
		    param1[5] = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		    if (iVar4 != 0) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_ToolTip_ToolTip__get_enabled(*(undefined4 *)(iVar4 + 0x28),1,0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Isles_User_Controller_BackClanIsleViewMediator_ViewOnClickEvent__,0
		                );
		      if (DAT_ram_00a58d17 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a58d17 = '\x01';
		      }
		      iVar2 = *(int *)(iVar4 + 0x30);
		      do {
		        piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0);
		        if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		          System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar6 = func_ii_4329(iVar4 + 0x30,piVar5,iVar2);
		        bVar1 = iVar6 != iVar2;
		        iVar2 = iVar6;
		      } while (bVar1);
		      Gameplay_Isles_User_Controller_BackClanIsleViewMediator__set_View(param1,iVar6);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_BackClanIsleViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d8a = '\x01';
		  }
		  if (((*(char *)(param1[2] + 0x2c) != '\0') &&
		      (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c)), iVar2 != 0)) &&
		     (*(char *)(param1[2] + 0x18) == '\0')) {
		    if (*(int *)(*(int *)(param1[2] + 8) + 0x68) != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *param1_00;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		            goto code_r0x80fa6262;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fa6262:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		      uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		      uVar4 = Core_Extensions_Dict_DictExt__GetCult
		                        (uVar4,*(undefined4 *)
		                                (*(int *)(*(int *)(*(int *)(param1[2] + 8) + 0x34) + 0x40) + 0x1c),0
		                        );
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      param1_01 = *(undefined4 *)(iVar2 + 0x24);
		      uVar4 = Core_Extensions_Dict_ClanCultDicExt__GetIsleBgAssetId(uVar4,0);
		      AssetContent_GameAssetViewSpriteRenderer__get_AssetId(param1_01,uVar4,0);
		      return;
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar2 + 0x24),0,0);
		  }
		  return;
		}
		*/

}
