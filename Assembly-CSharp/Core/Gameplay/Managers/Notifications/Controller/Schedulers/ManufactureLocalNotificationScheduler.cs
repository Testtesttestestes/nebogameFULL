using System;
using Gameplay.Assistants.Manufacture;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B9 RID: 4537
	[Token(Token = "0x20011B9")]
	public class ManufactureLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x00013F20 File Offset: 0x00012120
		[Token(Token = "0x17001606")]
		public override int Id
		{
			[Token(Token = "0x6006BD9")]
			[Address(RVA = "0xB6C9", Offset = "0xB6C9", VA = "0xB6C9", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x00013F38 File Offset: 0x00012138
		[Token(Token = "0x17001607")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BDA")]
			[Address(RVA = "0xB6CA", Offset = "0xB6CA", VA = "0xB6CA", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0xB6CB", Offset = "0xB6CB", VA = "0xB6CB", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDC")]
		[Address(RVA = "0xB6CC", Offset = "0xB6CC", VA = "0xB6CC")]
		private void DismantleStatusChangedEvent()
		{
		/* --- GHIDRA: DismantleStatusChangedEvent ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__DismantleStatusChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDD")]
		[Address(RVA = "0xB6CD", Offset = "0xB6CD", VA = "0xB6CD", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		/* --- GHIDRA: HandleSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__HandleSettingsChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  float fVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  undefined8 uVar12;
		  double dVar13;
		  int iVar14;
		  
		  if (DAT_ram_00a5a6a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_ArtifactInfo___);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a5a6a2 = '\x01';
		  }
		  piVar10 = (int *)param1[2];
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x148);
		        goto code_r0x81255a97;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar10,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81255a97:
		  uVar12 = CONCAT44(in_register_20000004,piVar10);
		  piVar10 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(uVar12,puVar3[1]);
		  uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),param1);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (uVar12,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = (undefined4)((ulonglong)uVar12 >> 0x20);
		  uVar1 = 0;
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 200);
		        goto code_r0x81255b33;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar10,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x81255b33:
		  (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar2,piVar10),uVar4,puVar3[1]);
		  iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0xf4));
		  if (iVar11 != 0) {
		    iVar11 = *(int *)param1[5];
		    iVar11 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                       ((int *)param1[5],*(undefined4 *)(iVar11 + 0x104));
		    if (*(int *)(iVar11 + 0x24) != 0) {
		      iVar11 = *(int *)param1[5];
		      iVar11 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                         ((int *)param1[5],*(undefined4 *)(iVar11 + 0x104));
		      if (*(int *)(iVar11 + 0x14) != 0) {
		        iVar11 = *(int *)param1[5];
		        iVar11 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                           ((int *)param1[5],*(undefined4 *)(iVar11 + 0x104));
		        if (*(int *)(*(int *)(iVar11 + 0x14) + 0xc) == 1) {
		          iVar11 = *(int *)param1[5];
		          iVar11 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                             ((int *)param1[5],*(undefined4 *)(iVar11 + 0x104));
		          uVar12 = *(undefined8 *)(*(int *)(iVar11 + 0x14) + 0x10);
		          if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Utils_TimeUtils_TypeInfo);
		          }
		          fVar5 = Utils_StringUtils___cctor(uVar12,0);
		          iVar11 = *(int *)param1[5];
		          uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),(int *)param1[5]);
		          iVar11 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                             (uVar12,*(undefined4 *)(iVar11 + 0x104));
		          dVar13 = *(double *)(*(int *)(iVar11 + 0x14) + 0x18);
		          uVar2 = (undefined4)((ulonglong)uVar12 >> 0x20);
		          uVar4 = unnamed_function_1417
		                            (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		          System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                    (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		          iVar11 = *(int *)param1[5];
		          uVar12 = CONCAT44(uVar2,(int *)param1[5]);
		          iVar11 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                             (uVar12,*(undefined4 *)(iVar11 + 0x104));
		          uVar2 = (undefined4)((ulonglong)uVar12 >> 0x20);
		          iVar11 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                             (*(undefined4 *)(*(int *)(iVar11 + 0x24) + 0x14),
		                              Method_System_Linq_Enumerable_FirstOrDefault_ArtifactInfo___);
		          if (iVar11 != 0) {
		            uVar6 = Unity_Properties_PropertyMember___ctor
		                              (0x17,Core_Gameplay_IGame_TypeInfo,param1[3]);
		            uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		            uVar6 = Gameplay_Inventory_Model_InventoryBaseModel__GetCount
		                              (uVar6,*(undefined4 *)(iVar11 + 0x18),0);
		            uVar6 = Core_Extensions_Dict_DictExt__GetArtikul(uVar6,0);
		            func_ii_2946(uVar4,StringLiteral_27734,uVar6,
		                         Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		          }
		          dVar13 = (1.0 - dVar13) * (double)fVar5;
		          uVar1 = 0;
		          uVar6 = Core_Extensions_Dict_ItemQualityDicExt__GetTitle(param1[4],0);
		          uVar7 = Core_Extensions_Dict_LocalNotificationDicExt__GetTitle(param1[4],0);
		          piVar10 = (int *)param1[2];
		          iVar11 = *piVar10;
		          if (*(ushort *)(iVar11 + 0xb6) != 0) {
		            do {
		              if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		                puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 +
		                                 0x148);
		                goto code_r0x81255d5a;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar10,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81255d5a:
		          uVar12 = CONCAT44(uVar2,piVar10);
		          piVar10 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(uVar12,puVar3[1]);
		          iVar11 = *param1;
		          uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),param1);
		          uVar8 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0xe8) * 4))
		                            (uVar12,*(undefined4 *)(iVar11 + 0xec));
		          uVar2 = (undefined4)((ulonglong)uVar12 >> 0x20);
		          uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar4,0);
		          uVar4 = Core_GameLocalization__GetTranslation(uVar7,uVar4,0);
		          uVar7 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                            (iVar11,iVar11,iVar11);
		          uVar12 = CONCAT44(uVar2,param1);
		          uVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                            (uVar12,*(undefined4 *)(*param1 + 0xfc));
		          uVar2 = (undefined4)((ulonglong)uVar12 >> 0x20);
		          iVar11 = *piVar10;
		          if (ABS(dVar13) < 2147483648.0) {
		            iVar14 = (int)dVar13;
		          }
		          else {
		            iVar14 = -0x80000000;
		          }
		          if (*(ushort *)(iVar11 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              if (Core_Application_Managers_INotificationManager_TypeInfo ==
		                  *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		                puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x81255e5a;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar10,
		                                        Core_Application_Managers_INotificationManager_TypeInfo,0);
		code_r0x81255e5a:
		          (**(code **)((ulonglong)*puVar3 * 4))
		                    (CONCAT44(uVar2,piVar10),uVar8,uVar6,uVar4,iVar14,uVar7,uVar9,puVar3[1]);
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDE")]
		[Address(RVA = "0xB6CE", Offset = "0xB6CE", VA = "0xB6CE")]
		private void ValidateNotification()
		{
		/* --- GHIDRA: ValidateNotification ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__ValidateNotification
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a6a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler_DismantleStatusChangedEvent__
		              );
		    DAT_ram_00a5a6a3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  piVar2 = *(int **)(*(int *)(param1 + 0x14) + 0x14);
		  iVar3 = *piVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                    (piVar2,*(undefined4 *)(iVar3 + 0x114));
		  param1_01 = *(undefined4 *)(iVar1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler_DismantleStatusChangedEvent__
		             ,0);
		  piVar2 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(iVar1 + 0x14) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDF")]
		[Address(RVA = "0xB6CF", Offset = "0xB6CF", VA = "0xB6CF", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE0")]
		[Address(RVA = "0xB6D0", Offset = "0xB6D0", VA = "0xB6D0")]
		public ManufactureLocalNotificationScheduler()
		{
		}

		// Token: 0x040038D4 RID: 14548
		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x14")]
		private ManufactureAssistant _manufactureAssistant;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Channel ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__get_Channel
		               (int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 param1_00;
		  int iVar6;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a5a6a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler_DismantleStatusChangedEvent__
		              );
		    DAT_ram_00a5a6a1 = '\x01';
		  }
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		            (param1,0);
		  piVar3 = *(int **)(param1 + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x210);
		        goto code_r0x81255876;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2a);
		code_r0x81255876:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  iVar6 = **(int **)(iVar4 + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar6 + 0x104));
		  piVar3 = (int *)Gameplay_Assistants_Model_AssistantsListModel__GetAssistant(uVar2,1,0);
		  iVar4 = Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x14) = 0;
		code_r0x8125591e:
		    iVar4 = *(int *)piVar3[5];
		    iVar6 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                      ((int *)piVar3[5],*(undefined4 *)(iVar4 + 0x114));
		    param1_00 = *(undefined4 *)(iVar6 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler_DismantleStatusChangedEvent__
		               ,0);
		    piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		    iVar4 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar6 + 0x14) = 0;
		      Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__HandleSettingsChanged
		                (param1,0);
		      return;
		    }
		    if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar6 + 0x14) = piVar3, *piVar3 == iVar4))
		    {
		      Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler__HandleSettingsChanged
		                (param1,piVar3);
		      return;
		    }
		    System_Activator__CreateInstance(piVar3,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = (uint)*(byte *)(Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo + 0xb8);
		  if ((uVar5 <= *(byte *)(*piVar3 + 0xb8)) &&
		     (*(int *)(*(int *)(*piVar3 + 100) + (uVar5 - 1) * 4) ==
		      Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo)) {
		    *(int **)(param1 + 0x14) = piVar3;
		    if ((uVar5 <= *(byte *)(*piVar3 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar3 + 100) + (uVar5 - 1) * 4) == iVar4)) goto code_r0x8125591e;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
