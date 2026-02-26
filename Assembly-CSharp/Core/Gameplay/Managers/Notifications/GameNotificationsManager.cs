using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Notifications.Controller;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Notifications
{
	// Token: 0x020011A5 RID: 4517
	[Token(Token = "0x20011A5")]
	public class GameNotificationsManager : IGameManager, IBaseManager
	{
		// Token: 0x140002BE RID: 702
		// (add) Token: 0x06006B56 RID: 27478 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B57 RID: 27479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BE")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006B56")]
			[Address(RVA = "0xB654", Offset = "0xB654", VA = "0xB654", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B57")]
			[Address(RVA = "0xB655", Offset = "0xB655", VA = "0xB655", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002BF RID: 703
		// (add) Token: 0x06006B58 RID: 27480 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B59 RID: 27481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BF")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006B58")]
			[Address(RVA = "0xB656", Offset = "0xB656", VA = "0xB656", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B59")]
			[Address(RVA = "0xB657", Offset = "0xB657", VA = "0xB657", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E0")]
		public GameNotificationsController Controller
		{
			[Token(Token = "0x6006B5A")]
			[Address(RVA = "0xB658", Offset = "0xB658", VA = "0xB658")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E1")]
		public GameNotificationsModel Model
		{
			[Token(Token = "0x6006B5B")]
			[Address(RVA = "0xB659", Offset = "0xB659", VA = "0xB659")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06006B5C RID: 27484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E2")]
		public GameNotificationsEvents Events
		{
			[Token(Token = "0x6006B5C")]
			[Address(RVA = "0xB65A", Offset = "0xB65A", VA = "0xB65A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5D")]
		[Address(RVA = "0xB65B", Offset = "0xB65B", VA = "0xB65B", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__Init
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Core_Gameplay_Managers_Notifications_GameNotificationsManager__InitEvent(param1,param1);
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5E")]
		[Address(RVA = "0xB65C", Offset = "0xB65C", VA = "0xB65C", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__Deinit
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a66c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Events_GameNotificationsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Notifications_GameNotificationsManager_InitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a66c = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar2 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Notifications_Events_GameNotificationsEvents_TypeInfo)
		    ;
		    *(undefined4 *)(param1 + 0x18) = uVar2;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x8124cf73;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8124cf73:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar2 = func_ii_7112(uVar2,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		          goto code_r0x8124d025;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124d025:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    param1_00 = unnamed_function_1417
		                          (
		                          Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel_TypeInfo
		                          );
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar2,0);
		    Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___ctor
		              (param1_00,uVar4,param1_00);
		    *(undefined4 *)(param1 + 0x14) = param1_00;
		    uVar4 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_TypeInfo
		                      );
		    Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator__set_View
		              (uVar2,param1_00,uVar4,param1_00);
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		    iVar7 = *(int *)(param1 + 0x18);
		    uVar4 = *(undefined4 *)(iVar7 + 8);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Core_Gameplay_Managers_Notifications_GameNotificationsManager_InitEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		    iVar6 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar7 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar7 + 8) = piVar5, *piVar5 != iVar6)) {
		      System_Activator__CreateInstance(piVar5,iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5F")]
		[Address(RVA = "0xB65D", Offset = "0xB65D", VA = "0xB65D")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__SetupMvc
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a66d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Notifications_GameNotificationsManager_InitEvent__);
		    DAT_ram_00a5a66d = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_GameNotificationsManager_InitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B60")]
		[Address(RVA = "0xB65E", Offset = "0xB65E", VA = "0xB65E")]
		private void InitEvent()
		{
		/* --- GHIDRA: InitEvent ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__InitEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a66e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Notifications_GameNotificationsManager_InitEvent__);
		    DAT_ram_00a5a66e = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    iVar1 = *(int *)(param1 + 0x18);
		    param1_02 = *(undefined4 *)(iVar1 + 8);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,
		               Method_Core_Gameplay_Managers_Notifications_GameNotificationsManager_InitEvent__,0);
		    param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		    iVar2 = System_Action_TypeInfo;
		    if (param1_01 == (int *)0x0) {
		      *(undefined4 *)(iVar1 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *param1_01) ||
		            (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		      System_Activator__CreateInstance(param1_01,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xec));
		    *(undefined4 *)(param1 + 0x18) = 0;
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B61")]
		[Address(RVA = "0xB65F", Offset = "0xB65F", VA = "0xB65F")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		undefined4
		Core_Gameplay_Managers_Notifications_GameNotificationsManager__DestroyMvc
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a66f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8437);
		    DAT_ram_00a5a66f = '\x01';
		  }
		  return StringLiteral_8437;
		}
		*/

		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E3")]
		public string Name
		{
			[Token(Token = "0x6006B62")]
			[Address(RVA = "0xB660", Offset = "0xB660", VA = "0xB660", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B63")]
		[Address(RVA = "0xB661", Offset = "0xB661", VA = "0xB661")]
		public GameNotificationsManager()
		{
		}

		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		[FieldOffset(Offset = "0x10")]
		private GameNotificationsController _controller;

		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		[FieldOffset(Offset = "0x14")]
		private GameNotificationsModel _model;

		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		[FieldOffset(Offset = "0x18")]
		private GameNotificationsEvents _events;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a669 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a669 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a66a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a66a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a66b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a66b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Events ---
		void Core_Gameplay_Managers_Notifications_GameNotificationsManager__get_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_GameNotificationsManager__Deinit(param1,param1);
		  return;
		}
		*/

}
