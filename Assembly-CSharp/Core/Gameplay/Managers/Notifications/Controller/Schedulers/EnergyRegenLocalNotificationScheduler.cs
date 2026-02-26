using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B8 RID: 4536
	[Token(Token = "0x20011B8")]
	public class EnergyRegenLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06006BD1 RID: 27601 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x17001604")]
		public override int Id
		{
			[Token(Token = "0x6006BD1")]
			[Address(RVA = "0xB6C1", Offset = "0xB6C1", VA = "0xB6C1", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x00013F08 File Offset: 0x00012108
		[Token(Token = "0x17001605")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BD2")]
			[Address(RVA = "0xB6C2", Offset = "0xB6C2", VA = "0xB6C2", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD3")]
		[Address(RVA = "0xB6C3", Offset = "0xB6C3", VA = "0xB6C3", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD4")]
		[Address(RVA = "0xB6C4", Offset = "0xB6C4", VA = "0xB6C4")]
		private void EnergyRegenStatusChangedEvent()
		{
		/* --- GHIDRA: EnergyRegenStatusChangedEvent ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__EnergyRegenStatusChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD5")]
		[Address(RVA = "0xB6C5", Offset = "0xB6C5", VA = "0xB6C5", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		/* --- GHIDRA: HandleSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__HandleSettingsChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  float fVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  int iVar11;
		  
		  if (DAT_ram_00a5a69f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    DAT_ram_00a5a69f = '\x01';
		  }
		  piVar9 = (int *)param1[2];
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x148);
		        goto code_r0x81255395;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81255395:
		  piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = 0;
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		        goto code_r0x81255431;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x81255431:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar9,uVar3,puVar2[1]);
		  iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0xf4));
		  if (iVar10 != 0) {
		    uVar1 = 0;
		    piVar9 = (int *)param1[3];
		    iVar10 = *piVar9;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x140);
		          goto code_r0x812554cb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812554cb:
		    iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		    iVar10 = *(int *)(*(int *)(iVar10 + 0x14) + 0x1c);
		    if (((iVar10 != 0) && (*(int *)(iVar10 + 0x10) != 0)) &&
		       (fVar4 = func_ii_7103(*(int *)(iVar10 + 0x10),0), 0.0 < fVar4)) {
		      uVar3 = Core_Extensions_Dict_ItemQualityDicExt__GetTitle(param1[4],0);
		      uVar5 = Core_Extensions_Dict_LocalNotificationDicExt__GetTitle(param1[4],0);
		      piVar9 = (int *)param1[2];
		      iVar11 = *piVar9;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x148
		                             );
		            goto code_r0x8125558e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,0x11);
		code_r0x8125558e:
		      piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		      iVar11 = *param1;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(iVar11 + 0xec));
		      fVar4 = func_ii_7103(*(undefined4 *)(iVar10 + 0x10),0);
		      uVar7 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                        (iVar11,iVar11,iVar11);
		      uVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xfc));
		      iVar10 = *piVar9;
		      if (ABS(fVar4) < 2.1474836e+09) {
		        iVar11 = (int)fVar4;
		      }
		      else {
		        iVar11 = -0x80000000;
		      }
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Application_Managers_INotificationManager_TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x8125567f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_Managers_INotificationManager_TypeInfo,0
		                                   );
		code_r0x8125567f:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar9,uVar6,uVar3,uVar5,iVar11,uVar7,uVar8,puVar2[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD6")]
		[Address(RVA = "0xB6C6", Offset = "0xB6C6", VA = "0xB6C6")]
		private void ValidateNotification()
		{
		/* --- GHIDRA: ValidateNotification ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__ValidateNotification
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a6a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler_EnergyRegenStatusChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6a0 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  piVar3 = *(int **)(param1 + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x81255745;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81255745:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x10);
		  param1_01 = *(undefined4 *)(iVar5 + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler_EnergyRegenStatusChangedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x1c) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x1c) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD7")]
		[Address(RVA = "0xB6C7", Offset = "0xB6C7", VA = "0xB6C7", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD8")]
		[Address(RVA = "0xB6C8", Offset = "0xB6C8", VA = "0xB6C8")]
		public EnergyRegenLocalNotificationScheduler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Channel ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__get_Channel
		               (int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_01;
		  uint uVar5;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a5a69e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler_EnergyRegenStatusChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a69e = '\x01';
		  }
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		            (param1,0);
		  piVar2 = *(int **)(param1 + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x8125525e;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125525e:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		  iVar4 = *(int *)(iVar3 + 0x10);
		  param1_01 = *(undefined4 *)(iVar4 + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler_EnergyRegenStatusChangedEvent__
		             ,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__HandleSettingsChanged
		              (param1,0);
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar2) && (*(int **)(iVar4 + 0x1c) = piVar2, *piVar2 == iVar3)) {
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler__HandleSettingsChanged
		              (param1,piVar2);
		    return;
		  }
		  System_Activator__CreateInstance(piVar2,iVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
