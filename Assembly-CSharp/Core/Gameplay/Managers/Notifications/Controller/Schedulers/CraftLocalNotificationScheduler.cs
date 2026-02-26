using System;
using Core.Events.Scopes;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B6 RID: 4534
	[Token(Token = "0x20011B6")]
	public class CraftLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x170015FF")]
		public override int Id
		{
			[Token(Token = "0x6006BBF")]
			[Address(RVA = "0xB6B0", Offset = "0xB6B0", VA = "0xB6B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x17001600")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BC0")]
			[Address(RVA = "0xB6B1", Offset = "0xB6B1", VA = "0xB6B1", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0xB6B2", Offset = "0xB6B2", VA = "0xB6B2", Slot = "8")]
		protected override void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler__HandleInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler__HandleSettingsChanged
		            (param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0xB6B3", Offset = "0xB6B3", VA = "0xB6B3", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		/* --- GHIDRA: HandleSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler__HandleSettingsChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  float fVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  int iVar12;
		  int iVar13;
		  longlong param1_00;
		  
		  if (DAT_ram_00a5a698 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_UserCraftSlotInfo___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a5a698 = '\x01';
		  }
		  piVar11 = (int *)param1[2];
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x148);
		        goto code_r0x812539cb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar11,Core_Application_IApp_TypeInfo,0x11);
		code_r0x812539cb:
		  uVar2 = CONCAT44(in_register_20000004,piVar11);
		  piVar11 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(uVar2,puVar4[1]);
		  uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),param1);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar1 = 0;
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 200);
		        goto code_r0x81253a67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar11,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x81253a67:
		  (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(uVar3,piVar11),uVar5,puVar4[1]);
		  iVar12 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0xf4));
		  if ((((param2 != 0) && (iVar12 != 0)) &&
		      (iVar12 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                          (*(undefined4 *)(param2 + 0x10),
		                           Method_System_Linq_Enumerable_FirstOrDefault_UserCraftSlotInfo___),
		      iVar12 != 0)) && (param1_00 = *(longlong *)(iVar12 + 0x20), param1_00 != 0)) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar6 = Utils_StringUtils___cctor(param1_00,0);
		    uVar3 = (undefined4)((ulonglong)param1_00 >> 0x20);
		    uVar5 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar5,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    piVar11 = (int *)param1[3];
		    iVar13 = *piVar11;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x178);
		          goto code_r0x81253b63;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81253b63:
		    uVar1 = 0;
		    uVar2 = CONCAT44(uVar3,piVar11);
		    uVar7 = (**(code **)((ulonglong)*puVar4 * 4))(uVar2,puVar4[1]);
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		    uVar7 = Core_Extensions_Dict_DictExt__GetSeasonLeagueDic(uVar7,*(undefined4 *)(iVar12 + 0x18),0)
		    ;
		    uVar7 = Core_Extensions_Dict_CompetitionRatingKindDicExt__GetDescription(uVar7,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar5,StringLiteral_27734,uVar7,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar7 = Core_Extensions_Dict_ItemQualityDicExt__GetTitle(param1[4],0);
		    uVar8 = Core_Extensions_Dict_LocalNotificationDicExt__GetTitle(param1[4],0);
		    piVar11 = (int *)param1[2];
		    iVar12 = *piVar11;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x148);
		          goto code_r0x81253c31;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar11,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81253c31:
		    uVar2 = CONCAT44(uVar3,piVar11);
		    piVar11 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(uVar2,puVar4[1]);
		    iVar12 = *param1;
		    uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),param1);
		    uVar9 = (**(code **)((ulonglong)*(uint *)(iVar12 + 0xe8) * 4))
		                      (uVar2,*(undefined4 *)(iVar12 + 0xec));
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar7 = Core_GameLocalization__GetTranslation(uVar7,uVar5,0);
		    uVar5 = Core_GameLocalization__GetTranslation(uVar8,uVar5,0);
		    uVar8 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                      (iVar12,iVar12,iVar12);
		    uVar2 = CONCAT44(uVar3,param1);
		    uVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                       (uVar2,*(undefined4 *)(*param1 + 0xfc));
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    iVar12 = *piVar11;
		    if (ABS(fVar6) < 2.1474836e+09) {
		      iVar13 = (int)fVar6;
		    }
		    else {
		      iVar13 = -0x80000000;
		    }
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Application_Managers_INotificationManager_TypeInfo ==
		            *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81253d2d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar11,Core_Application_Managers_INotificationManager_TypeInfo,0)
		    ;
		code_r0x81253d2d:
		    (**(code **)((ulonglong)*puVar4 * 4))
		              (CONCAT44(uVar3,piVar11),uVar9,uVar7,uVar5,iVar13,uVar8,uVar10,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0xB6B4", Offset = "0xB6B4", VA = "0xB6B4")]
		private void CraftSlotsRequestedEvent(CraftScope.CraftSlotsEventArgs e)
		{
		/* --- GHIDRA: CraftSlotsRequestedEvent ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler__CraftSlotsRequestedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a699 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler_CraftSlotsRequestedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a5a699 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  param1_00 = *(int **)(param1 + 8);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		        goto code_r0x81253de8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,8);
		code_r0x81253de8:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(*(int *)(iVar5 + 0x10) + 0x78);
		  param1_01 = *(undefined4 *)(iVar6 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler_CraftSlotsRequestedEvent__
		             ,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0xc) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0xc) = iVar4;
		    uVar3 = System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0xB6B5", Offset = "0xB6B5", VA = "0xB6B5", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0xB6B6", Offset = "0xB6B6", VA = "0xB6B6")]
		public CraftLocalNotificationScheduler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Channel ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler__get_Channel
		               (int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  uint uVar6;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a5a697 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler_CraftSlotsRequestedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a5a697 = '\x01';
		  }
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		            (param1,0);
		  param1_00 = *(int **)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x81253850;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,8);
		code_r0x81253850:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  iVar5 = *(int *)(*(int *)(iVar4 + 0x10) + 0x78);
		  param1_01 = *(undefined4 *)(iVar5 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler_CraftSlotsRequestedEvent__
		             ,0);
		  iVar4 = UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  uVar2 = System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo;
		  if (iVar4 == 0) {
		    *(undefined4 *)(iVar5 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar4,System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar5 + 0xc) = iVar3;
		    uVar2 = System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo;
		    iVar5 = func_ii_1082(iVar4,System_Action_CraftScope_CraftSlotsEventArgs__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar4,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar4,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
