using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.WorldView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BBD RID: 3005
	[Token(Token = "0x2000BBD")]
	public class IsleBossViewMediator : AbstractViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, IsleBossView>
	{
		// Token: 0x060049B8 RID: 18872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x982A", Offset = "0x982A", VA = "0x982A")]
		public IsleBossViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_IsleBossViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a60888 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_IsleBossViewMediator_HealthChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_IsleBossViewMediator_InstanceStateChangedEvent__);
		    DAT_ram_00a60888 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_IsleBossViewMediator_InstanceStateChangedEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_IsleBossViewMediator_HealthChangedEvent__,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_IsleBossViewMediator_InstanceStateChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_IsleBossViewMediator_HealthChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000EE3 RID: 3811
		// (set) Token: 0x060049B9 RID: 18873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE3")]
		public override BossInstanceEvents Events
		{
			[Token(Token = "0x60049B9")]
			[Address(RVA = "0x982B", Offset = "0x982B", VA = "0x982B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BA")]
		[Address(RVA = "0x982C", Offset = "0x982C", VA = "0x982C")]
		private void HealthChangedEvent()
		{
		/* --- GHIDRA: HealthChangedEvent ---
		void Gameplay_Boss_Controller_IsleBossViewMediator__HealthChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_Controller_IsleBossViewMediator__set_View(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x982D", Offset = "0x982D", VA = "0x982D")]
		private void InstanceStateChangedEvent()
		{
		/* --- GHIDRA: InstanceStateChangedEvent ---
		void Gameplay_Boss_Controller_IsleBossViewMediator__InstanceStateChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a6088a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_IsleBossViewMediator_ViewOnClickEvent__);
		    DAT_ram_00a6088a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Boss_Controller_IsleBossViewMediator_ViewOnClickEvent__,
		               0);
		    Gameplay_Isles_User_View_BaseIsleMonsterView__add_ClickEvent(uVar1,uVar3,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Boss_Controller_IsleBossViewMediator__set_View(param1,param1);
		    Gameplay_Boss_Controller_IsleBossViewMediator__set_Events(param1,param1);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Boss_Controller_IsleBossViewMediator_ViewOnClickEvent__,
		               0);
		    Gameplay_Isles_User_View_BackClanIsleView___ctor(uVar1,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000EE4 RID: 3812
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE4")]
		public override IsleBossView View
		{
			[Token(Token = "0x60049BC")]
			[Address(RVA = "0x982E", Offset = "0x982E", VA = "0x982E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x982F", Offset = "0x982F", VA = "0x982F")]
		private void ShowCurrentState()
		{
		/* --- GHIDRA: ShowCurrentState ---
		void Gameplay_Boss_Controller_IsleBossViewMediator__ShowCurrentState(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a6088c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6088c = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1e0);
		        goto code_r0x81cf1a17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81cf1a17:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_BossManager__ShowBossWindow
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(param1 + 8) + 0x28) + 0x10),1,0);
		  return;
		}
		*/

		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x9830", Offset = "0x9830", VA = "0x9830")]
		private void ViewOnClickEvent()
		{
		/* --- GHIDRA: ViewOnClickEvent ---
		void Gameplay_Boss_Controller_IsleBossViewMediator__ViewOnClickEvent(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6088d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__Dispose__
		              );
		    DAT_ram_00a6088d = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Isles_User_View_BaseIsleMonsterView__remove_ClickEvent(param1_00,0,0);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x9831", Offset = "0x9831", VA = "0x9831", Slot = "14")]
		public override void Dispose()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Boss_Controller_IsleBossViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a60889 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__get_Model__
		              );
		    DAT_ram_00a60889 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar4 = *(int **)(iVar1 + 0x2c);
		    fVar2 = Gameplay_Boss_Model_BossInstanceModel__set_CurrentHealth(param1[2],0);
		    iVar1 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x108) * 4))
		              (piVar4,fVar2,*(undefined4 *)(iVar1 + 0x10c));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar4 = *(int **)(iVar1 + 0x30);
		    uVar3 = Gameplay_Boss_Model_BossInstanceModel__get_CurrentHealthPercent(param1[2],0);
		    iVar1 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar4,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Boss_Controller_IsleBossViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  uint *puVar5;
		  int *param1_01;
		  
		  if (DAT_ram_00a6088b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3676);
		    DAT_ram_00a6088b = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Boss_Model_BossInstance__Dispose(param1[2],0);
		    if ((iVar2 != 0) ||
		       (iVar2 = Gameplay_Boss_Model_BossInstanceModel__get_IsDead(param1[2],0), iVar2 != 0)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(iVar2 + 0x34),*(undefined4 *)(param1[2] + 0x34),0);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = Core_Extensions_Dict_AprDicExt__GetImageInfoAssetId
		                        (*(undefined4 *)(*(int *)(param1[2] + 0x30) + 8),0);
		      Gameplay_Isles_User_View_BaseIsleMonsterView__remove_ClickEvent(uVar3,uVar4,0);
		      return;
		    }
		    iVar2 = Gameplay_Boss_Model_BossInstanceModel__get_IsAlive(param1[2],0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar2 != 0) {
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(param1_00 + 0x34),*(undefined4 *)(param1[2] + 0x34),0);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar1 = 0;
		      param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *param1_01;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		            goto code_r0x81cf180b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf180b:
		      uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(param1_01,puVar5[1]);
		      uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		      uVar4 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar4,StringLiteral_3676,0);
		      Gameplay_Isles_User_View_BaseIsleMonsterView__remove_ClickEvent(uVar3,uVar4,0);
		      return;
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1_00,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		  }
		  return;
		}
		*/

}
