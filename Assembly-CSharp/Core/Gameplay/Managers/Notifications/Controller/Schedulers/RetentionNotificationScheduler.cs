using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011BA RID: 4538
	[Token(Token = "0x20011BA")]
	public class RetentionNotificationScheduler : AbstractBaseNotificationScheduler
	{
		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001608")]
		private protected LocalNotificationDic NotificationDic
		{
			[Token(Token = "0x6006BE1")]
			[Address(RVA = "0xB6D1", Offset = "0xB6D1", VA = "0xB6D1")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006BE2")]
			[Address(RVA = "0xB6D2", Offset = "0xB6D2", VA = "0xB6D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x17001609")]
		public override int Id
		{
			[Token(Token = "0x6006BE3")]
			[Address(RVA = "0xB6D3", Offset = "0xB6D3", VA = "0xB6D3", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x00013F68 File Offset: 0x00012168
		[Token(Token = "0x1700160A")]
		protected override bool IsNotificationEnabled
		{
			[Token(Token = "0x6006BE4")]
			[Address(RVA = "0xB6D4", Offset = "0xB6D4", VA = "0xB6D4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x1700160B")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BE5")]
			[Address(RVA = "0xB6D5", Offset = "0xB6D5", VA = "0xB6D5", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE6")]
		[Address(RVA = "0xB6D6", Offset = "0xB6D6", VA = "0xB6D6", Slot = "9")]
		protected override void HandleDispose()
		{
		/* --- GHIDRA: HandleDispose ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler__HandleDispose
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 == *(int *)(*(int *)(param1 + 0x14) + 0xc)) {
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler___ctor
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE7")]
		[Address(RVA = "0xB6D7", Offset = "0xB6D7", VA = "0xB6D7", Slot = "10")]
		protected override void OnSettingsChanged(uint notificationId)
		{
		/* --- GHIDRA: OnSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler__OnSettingsChanged
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *param2_00;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a6a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_IListExt_GetRandom_uint___);
		    DAT_ram_00a5a6a5 = '\x01';
		  }
		  uVar2 = Core_Extensions_IListExt__GetIndexRandom___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x18),
		                     Method_Core_Extensions_IListExt_GetRandom_uint___);
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81256461;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81256461:
		  uVar3 = (**(code **)((ulonglong)*param2_00 * 4))(param1_00,param2_00[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUIElementsDic(uVar3,uVar2,0);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler___ctor
		            (param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE8")]
		[Address(RVA = "0xB6D8", Offset = "0xB6D8", VA = "0xB6D8", Slot = "8")]
		protected override void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		undefined *
		Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler__HandleInit
		          (int param1,undefined4 param2)
		
		{
		  return &DAT_ram_000f4240 + param1;
		}
		*/

		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x00013F98 File Offset: 0x00012198
		[Token(Token = "0x6006BE9")]
		[Address(RVA = "0xB6D9", Offset = "0xB6D9", VA = "0xB6D9")]
		public static int GetNotificationIdByScheduleId(int scheduleId)
		{
		/* --- GHIDRA: GetNotificationIdByScheduleId ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler__GetNotificationIdByScheduleId
		               (int param1,int param2,undefined4 param3)
		
		{
		  *(int *)(param1 + 0x10) = param2;
		  *(undefined **)(param1 + 0x18) = &DAT_ram_000f4240 + *(int *)(param2 + 0xc);
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEA")]
		[Address(RVA = "0xB6DA", Offset = "0xB6DA", VA = "0xB6DA")]
		public RetentionNotificationScheduler(LocalNotificationScheduleDic scheduleDic)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  float fVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  undefined8 uVar11;
		  int iVar12;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a6a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26566);
		    DAT_ram_00a5a6a6 = '\x01';
		  }
		  piVar9 = (int *)param1[2];
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x148);
		        goto code_r0x81256107;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81256107:
		  uVar11 = CONCAT44(in_register_20000004,piVar9);
		  piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(uVar11,puVar2[1]);
		  uVar11 = CONCAT44((int)((ulonglong)uVar11 >> 0x20),param1);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (uVar11,*(undefined4 *)(*param1 + 0xec));
		  uVar6 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  uVar1 = 0;
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		        goto code_r0x812561a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x812561a3:
		  uVar11 = CONCAT44(uVar6,piVar9);
		  (**(code **)((ulonglong)*puVar2 * 4))(uVar11,uVar3,puVar2[1]);
		  uVar11 = CONCAT44((int)((ulonglong)uVar11 >> 0x20),param1);
		  iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (uVar11,*(undefined4 *)(*param1 + 0xf4));
		  if (iVar10 != 0) {
		    uVar6 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    uVar3 = Core_Extensions_Dict_ItemQualityDicExt__GetTitle(param1[5],0);
		    uVar4 = Core_Extensions_Dict_LocalNotificationDicExt__GetTitle(param1[5],0);
		    uVar1 = 0;
		    param1_00 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                          (0,0,0);
		    local_4 = *(undefined4 *)(param1[4] + 0xc);
		    uVar5 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    func_ii_2946(param1_00,StringLiteral_26566,uVar5,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    piVar9 = (int *)param1[2];
		    iVar10 = *piVar9;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x148);
		          goto code_r0x81256295;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81256295:
		    piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar6,piVar9),puVar2[1]);
		    uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    uVar11 = *(undefined8 *)(param1[4] + 0x10);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar7 = Utils_StringUtils___cctor(uVar11,0);
		    if (ABS(fVar7) < 2.1474836e+09) {
		      iVar10 = (int)fVar7;
		    }
		    else {
		      iVar10 = -0x80000000;
		    }
		    uVar11 = CONCAT44((int)((ulonglong)uVar11 >> 0x20),param1);
		    uVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                      (uVar11,*(undefined4 *)(*param1 + 0xfc));
		    uVar5 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    iVar12 = *piVar9;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Application_Managers_INotificationManager_TypeInfo ==
		            *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81256398;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_Managers_INotificationManager_TypeInfo,0);
		code_r0x81256398:
		    (**(code **)((ulonglong)*puVar2 * 4))
		              (CONCAT44(uVar5,piVar9),uVar6,uVar3,uVar4,iVar10,param1_00,uVar8,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEB")]
		[Address(RVA = "0xB6DB", Offset = "0xB6DB", VA = "0xB6DB")]
		private void ValidateNotification()
		{
		}

		// Token: 0x040038D5 RID: 14549
		[Token(Token = "0x40038D5")]
		public const int RetentionNotificationIdDelta = 1000000;

		// Token: 0x040038D6 RID: 14550
		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x10")]
		private LocalNotificationScheduleDic _scheduleDic;

		// Token: 0x040038D8 RID: 14552
		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x18")]
		private int _id;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Id ---
		uint Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler__get_Id
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5a6a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6a4 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x260);
		        goto code_r0x81255fd0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x34);
		code_r0x81255fd0:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = *(int *)(iVar3 + 0x14);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xc);
		  if (DAT_ram_00a5a67e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		    DAT_ram_00a5a67e = '\x01';
		  }
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar3 + 0x10),uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		  iVar3 = func_ii_8735(iVar3,uVar4,iVar3);
		  return (uint)*(byte *)(iVar3 + 0x10);
		}
		*/

}
